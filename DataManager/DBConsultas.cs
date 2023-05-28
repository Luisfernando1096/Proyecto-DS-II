using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public static class DBConsultas
    {
        public static DataTable IniciarSesion(string pUsuario, string pClave)
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select 
                a.idUsuario, a.usuario, a.clave, c.idEmpleado, c.nombres_empleado, a.idRol, b.rol 
                from usuarios a, roles b, empleados c where a.idRol = b.idRol 
                and c.idEmpleado = a.idEmpleado and usuario = '" + pUsuario + @"' 
                and clave = sha1(md5('" + pClave + @"')); ";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
            
        }

        public static DataTable ReporteExistencias()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT * FROM existencias";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable ReporteInventario(string inicio, string fin)
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT
                                        productos.codigo AS codigo_producto,
                                        productos.nombre AS nombre_producto,
                                        productos.descripcion AS descripcion_producto,
                                        entradas.suma_sub_total AS subTotalCompras,
                                        COALESCE(salidas.suma_sub_total, 0) AS subTotalVentas,
                                        entradas.suma_cantidad AS cantidad_entradas,
                                        entradas.precio_compra AS precio_compra,
                                        COALESCE(salidas.suma_cantidad, 0) AS cantidad_salidas,
                                        COALESCE(salidas.precio_venta, 0) AS precio_venta,
                                        (existencias.existencia) AS stock_actual,
                                        (COALESCE(salidas.suma_sub_total, 0) - COALESCE(entradas.suma_sub_total, 0)) AS flujo_actual
                                    FROM
                                        productos
                                    INNER JOIN
                                        (
                                            SELECT
                                                detalle_entradas.idProducto,
                                                COALESCE(SUM(detalle_entradas.sub_total), 0) AS suma_sub_total,
                                                COALESCE(SUM(detalle_entradas.cantidad), 0) AS suma_cantidad,
                                                detalle_entradas.precio_compra
                                            FROM
                                                detalle_entradas
                                            INNER JOIN
                                                entradas ON entradas.idEntrada = detalle_entradas.idEntrada
                                            WHERE
                                                entradas.fecha_entrada BETWEEN '" + inicio + @"' AND '" + fin + @"'
                                            GROUP BY
                                                detalle_entradas.idProducto, detalle_entradas.precio_compra
                                        ) AS entradas ON productos.idProducto = entradas.idProducto
                                        INNER JOIN
                                        (
                                            SELECT
                                                existencias.idProducto,
                                                existencias.existencia
                                            FROM
                                                existencias
                                            GROUP BY
                                                existencias.idProducto, existencias.existencia
                                        ) AS existencias ON productos.idProducto = existencias.idProducto
                                        LEFT JOIN
                                        (
                                            SELECT
                                                detalle_salidas.idProducto,
                                                COALESCE(SUM(detalle_salidas.sub_total), 0) AS suma_sub_total,
                                                COALESCE(SUM(detalle_salidas.cantidad), 0) AS suma_cantidad,
                                                detalle_salidas.precio_venta
                                            FROM
                                                detalle_salidas
                                            INNER JOIN
                                                salidas ON salidas.idSalida = detalle_salidas.idSalida
                                            WHERE
                                                salidas.fecha_salida BETWEEN '" + inicio + @"' AND '" + fin + @"'
                                            GROUP BY
                                                detalle_salidas.idProducto, detalle_salidas.precio_venta
                                        ) AS salidas ON productos.idProducto = salidas.idProducto
                                        WHERE (COALESCE(salidas.suma_sub_total, 0) - COALESCE(entradas.suma_sub_total, 0)) >= 0;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable VerRegistroSalidas(string doc)
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT d.documento_salida, a.codigo, a.nombre, a.descripcion, a.precio_venta, b.categoria, c.cantidad, e.dui, e.nombres_cliente, d.fecha_salida, c.sub_total, d.total, f.usuario
                                    FROM productos a, categorias b, detalle_salidas c, salidas d, clientes e, usuarios f
                                    WHERE a.idCategoria=b.idCategoria AND c.idProducto=a.idProducto AND c.idSalida=d.idSalida
                                    AND d.idCliente=e.idCliente AND f.idUsuario=d.idUsuario AND d.documento_salida='" + doc + "';";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable SalidasLista()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT d.idSalida, d.documento_salida, CONCAT(e.nombres_cliente, ' ', e.apellidos_cliente) AS nombre_cliente, e.dui, d.fecha_salida, 
                                   (SELECT COUNT(*) FROM detalle_salidas WHERE idSalida = d.idSalida) AS ListaDetalles, 
                                   d.total, f.usuario
                                    FROM salidas d, clientes e, usuarios f
                                    WHERE d.idCliente = e.idCliente AND d.idUsuario = f.idUsuario ORDER BY d.idSalida asc;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable SalidaPorClientes()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT d.idSalida, d.documento_salida, CONCAT(e.nombres_cliente, ' ', e.apellidos_cliente) AS nombre_cliente, e.dui, d.fecha_salida, 
                                   (SELECT COUNT(*) FROM detalle_salidas WHERE idSalida = d.idSalida) AS ListaDetalles, 
                                   d.total, f.usuario
                                    FROM salidas d, clientes e, usuarios f
                                    WHERE d.idCliente = e.idCliente AND d.idUsuario = f.idUsuario
                                    ORDER BY e.nombres_cliente ASC;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();


                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable SalidaPorDocumento()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT d.idSalida, d.documento_salida, CONCAT(e.nombres_cliente, ' ', e.apellidos_cliente) AS nombre_cliente, e.dui, d.fecha_salida, 
                                   (SELECT COUNT(*) FROM detalle_salidas WHERE idSalida = d.idSalida) AS ListaDetalles, 
                                   d.total, f.usuario
                                    FROM salidas d, clientes e, usuarios f
                                    WHERE d.idCliente = e.idCliente AND d.idUsuario = f.idUsuario
                                    ORDER BY d.documento_salida ASC;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();


                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable SalidaPorFecha()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT d.idSalida, d.documento_salida, CONCAT(e.nombres_cliente, ' ', e.apellidos_cliente) AS nombre_cliente, e.dui, d.fecha_salida, 
                                   (SELECT COUNT(*) FROM detalle_salidas WHERE idSalida = d.idSalida) AS ListaDetalles, 
                                   d.total, f.usuario
                                    FROM salidas d, clientes e, usuarios f
                                    WHERE d.idCliente = e.idCliente AND d.idUsuario = f.idUsuario
                                    ORDER BY d.fecha_salida ASC;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();


                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable SalidaPorTotal()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT d.idSalida, d.documento_salida, CONCAT(e.nombres_cliente, ' ', e.apellidos_cliente) AS nombre_cliente, e.dui, d.fecha_salida, 
                                   (SELECT COUNT(*) FROM detalle_salidas WHERE idSalida = d.idSalida) AS ListaDetalles, 
                                   d.total, f.usuario
                                    FROM salidas d, clientes e, usuarios f
                                    WHERE d.idCliente = e.idCliente AND d.idUsuario = f.idUsuario
                                    ORDER BY d.total desc;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();


                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable SalidaPorUsuario()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT d.idSalida, d.documento_salida, CONCAT(e.nombres_cliente, ' ', e.apellidos_cliente) AS nombre_cliente, e.dui, d.fecha_salida, 
                                   (SELECT COUNT(*) FROM detalle_salidas WHERE idSalida = d.idSalida) AS ListaDetalles, 
                                   d.total, f.usuario
                                    FROM salidas d, clientes e, usuarios f
                                    WHERE d.idCliente = e.idCliente AND d.idUsuario = f.idUsuario
                                    ORDER BY f.usuario asc;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();


                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable SalidaPorListaDetalles()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT d.idSalida, d.documento_salida, CONCAT(e.nombres_cliente, ' ', e.apellidos_cliente) AS nombre_cliente, e.dui, d.fecha_salida, 
                               (SELECT COUNT(*) FROM detalle_salidas WHERE idSalida = d.idSalida) AS ListaDetalles, 
                               d.total, f.usuario
                                FROM salidas d, clientes e, usuarios f
                                WHERE d.idCliente = e.idCliente AND d.idUsuario = f.idUsuario
                                ORDER BY ListaDetalles desc;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();


                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable EntradasLista()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT e.idEntrada, e.documento_entrada, pro.nombre, pro.documento, e.fecha_entrada, 
                                    (SELECT COUNT(*) FROM detalle_entradas de WHERE idEntrada = e.idEntrada) AS ListaDetalles, e.total, u.usuario
                                    FROM entradas e, usuarios u, proveedores pro
                                    WHERE e.idProveedor = pro.idProveedor AND e.idUsuario = u.idUsuario 
                                    order by e.idEntrada asc;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable EntradasPorProveedores()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT e.idEntrada, e.documento_entrada, pro.nombre, pro.documento, e.fecha_entrada, 
                                    (SELECT COUNT(*) FROM detalle_entradas de WHERE idEntrada = e.idEntrada) AS ListaDetalles, e.total, u.usuario
                                    FROM entradas e, usuarios u, proveedores pro
                                    WHERE e.idProveedor = pro.idProveedor AND e.idUsuario = u.idUsuario
                                    order by pro.nombre asc;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();


                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable EntradasPorDocumento()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT e.idEntrada, e.documento_entrada, pro.nombre, pro.documento, e.fecha_entrada, 
                                    (SELECT COUNT(*) FROM detalle_entradas de WHERE idEntrada = e.idEntrada) AS ListaDetalles, e.total, u.usuario
                                    FROM entradas e, usuarios u, proveedores pro
                                    WHERE e.idProveedor = pro.idProveedor AND e.idUsuario = u.idUsuario
                                    order by e.documento_entrada asc;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();


                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable EntradasPorFecha()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT e.idEntrada, e.documento_entrada, pro.nombre, pro.documento, e.fecha_entrada, 
                                    (SELECT COUNT(*) FROM detalle_entradas de WHERE idEntrada = e.idEntrada) AS ListaDetalles, e.total, u.usuario
                                    FROM entradas e, usuarios u, proveedores pro
                                    WHERE e.idProveedor = pro.idProveedor AND e.idUsuario = u.idUsuario
                                    order by e.fecha_entrada asc;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();


                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable EntradasPorTotal()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT e.idEntrada, e.documento_entrada, pro.nombre, pro.documento, e.fecha_entrada, 
                                    (SELECT COUNT(*) FROM detalle_entradas de WHERE idEntrada = e.idEntrada) AS ListaDetalles, e.total, u.usuario
                                    FROM entradas e, usuarios u, proveedores pro
                                    WHERE e.idProveedor = pro.idProveedor AND e.idUsuario = u.idUsuario
                                    order by e.total desc;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();


                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable EntradasPorUsuario()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT e.idEntrada, e.documento_entrada, pro.nombre, pro.documento, e.fecha_entrada, 
                                    (SELECT COUNT(*) FROM detalle_entradas de WHERE idEntrada = e.idEntrada) AS ListaDetalles, e.total, u.usuario
                                    FROM entradas e, usuarios u, proveedores pro
                                    WHERE e.idProveedor = pro.idProveedor AND e.idUsuario = u.idUsuario
                                    order by u.usuario asc;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();


                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable EntradasPorListaDetalles()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT e.idEntrada, e.documento_entrada, pro.nombre, pro.documento, e.fecha_entrada, 
                                    (SELECT COUNT(*) FROM detalle_entradas de WHERE idEntrada = e.idEntrada) AS ListaDetalles, e.total, u.usuario
                                    FROM entradas e, usuarios u, proveedores pro
                                    WHERE e.idProveedor = pro.idProveedor AND e.idUsuario = u.idUsuario
                                    order by ListaDetalles desc;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();


                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable InventarioPorNombre(string nombre, string inicio, string fin)
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT
                                        productos.codigo AS codigo_producto,
                                        productos.nombre AS nombre_producto,
                                        productos.descripcion AS descripcion_producto,
                                        entradas.suma_sub_total AS subTotalCompras,
                                        COALESCE(salidas.suma_sub_total, 0) AS subTotalVentas,
                                        entradas.suma_cantidad AS cantidad_entradas,
                                        entradas.precio_compra AS precio_compra,
                                        COALESCE(salidas.suma_cantidad, 0) AS cantidad_salidas,
                                        COALESCE(salidas.precio_venta, 0) AS precio_venta,
                                        (existencias.existencia) AS stock_actual,
                                        (COALESCE(salidas.suma_sub_total, 0) - COALESCE(entradas.suma_sub_total, 0)) AS flujo_actual
                                    FROM
                                        productos
                                    INNER JOIN
                                        (
                                            SELECT
                                                detalle_entradas.idProducto,
                                                COALESCE(SUM(detalle_entradas.sub_total), 0) AS suma_sub_total,
                                                COALESCE(SUM(detalle_entradas.cantidad), 0) AS suma_cantidad,
                                                detalle_entradas.precio_compra
                                            FROM
                                                detalle_entradas
                                            INNER JOIN
                                                entradas ON entradas.idEntrada = detalle_entradas.idEntrada
                                            WHERE
                                                entradas.fecha_entrada BETWEEN '" + inicio + @"' AND '" + fin + @"'
                                            GROUP BY
                                                detalle_entradas.idProducto, detalle_entradas.precio_compra
                                        ) AS entradas ON productos.idProducto = entradas.idProducto
                                        INNER JOIN
                                        (
                                            SELECT
                                                existencias.idProducto,
                                                existencias.existencia
                                            FROM
                                                existencias
                                            GROUP BY
                                                existencias.idProducto, existencias.existencia
                                        ) AS existencias ON productos.idProducto = existencias.idProducto
                                        LEFT JOIN
                                        (
                                            SELECT
                                                detalle_salidas.idProducto,
                                                COALESCE(SUM(detalle_salidas.sub_total), 0) AS suma_sub_total,
                                                COALESCE(SUM(detalle_salidas.cantidad), 0) AS suma_cantidad,
                                                detalle_salidas.precio_venta
                                            FROM
                                                detalle_salidas
                                            INNER JOIN
                                                salidas ON salidas.idSalida = detalle_salidas.idSalida
                                            WHERE
                                                salidas.fecha_salida BETWEEN '" + inicio + @"' AND '" + fin + @"'
                                            GROUP BY
                                                detalle_salidas.idProducto, detalle_salidas.precio_venta
                                        ) AS salidas ON productos.idProducto = salidas.idProducto
                                        WHERE productos.nombre like '%" + nombre + "%';";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable FlujoMayor(string inicio, string fin)
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT
                                        productos.codigo AS codigo_producto,
                                        productos.nombre AS nombre_producto,
                                        productos.descripcion AS descripcion_producto,
                                        entradas.suma_sub_total AS subTotalCompras,
                                        COALESCE(salidas.suma_sub_total, 0) AS subTotalVentas,
                                        entradas.suma_cantidad AS cantidad_entradas,
                                        entradas.precio_compra AS precio_compra,
                                        COALESCE(salidas.suma_cantidad, 0) AS cantidad_salidas,
                                        COALESCE(salidas.precio_venta, 0) AS precio_venta,
                                        (existencias.existencia) AS stock_actual,
                                        (COALESCE(salidas.suma_sub_total, 0) - COALESCE(entradas.suma_sub_total, 0)) AS flujo_actual
                                    FROM
                                        productos
                                    INNER JOIN
                                        (
                                            SELECT
                                                detalle_entradas.idProducto,
                                                COALESCE(SUM(detalle_entradas.sub_total), 0) AS suma_sub_total,
                                                COALESCE(SUM(detalle_entradas.cantidad), 0) AS suma_cantidad,
                                                detalle_entradas.precio_compra
                                            FROM
                                                detalle_entradas
                                            INNER JOIN
                                                entradas ON entradas.idEntrada = detalle_entradas.idEntrada
                                            WHERE
                                                entradas.fecha_entrada BETWEEN '" + inicio + @"' AND '" + fin + @"'
                                            GROUP BY
                                                detalle_entradas.idProducto, detalle_entradas.precio_compra
                                        ) AS entradas ON productos.idProducto = entradas.idProducto
                                        INNER JOIN
                                        (
                                            SELECT
                                                existencias.idProducto,
                                                existencias.existencia
                                            FROM
                                                existencias
                                            GROUP BY
                                                existencias.idProducto, existencias.existencia
                                        ) AS existencias ON productos.idProducto = existencias.idProducto
                                        LEFT JOIN
                                        (
                                            SELECT
                                                detalle_salidas.idProducto,
                                                COALESCE(SUM(detalle_salidas.sub_total), 0) AS suma_sub_total,
                                                COALESCE(SUM(detalle_salidas.cantidad), 0) AS suma_cantidad,
                                                detalle_salidas.precio_venta
                                            FROM
                                                detalle_salidas
                                            INNER JOIN
                                                salidas ON salidas.idSalida = detalle_salidas.idSalida
                                            WHERE
                                                salidas.fecha_salida BETWEEN '" + inicio + @"' AND '" + fin + @"'
                                            GROUP BY
                                                detalle_salidas.idProducto, detalle_salidas.precio_venta
                                        ) AS salidas ON productos.idProducto = salidas.idProducto
                                        WHERE (COALESCE(salidas.suma_sub_total, 0) - COALESCE(entradas.suma_sub_total, 0)) >= 0;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable IdDetalleSalidas()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select idDetalleSalida, idProducto from detalle_salidas;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable FlujoMenor(string inicio, string fin)
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT
                                        productos.codigo AS codigo_producto,
                                        productos.nombre AS nombre_producto,
                                        productos.descripcion AS descripcion_producto,
                                        entradas.suma_sub_total AS subTotalCompras,
                                        COALESCE(salidas.suma_sub_total, 0) AS subTotalVentas,
                                        entradas.suma_cantidad AS cantidad_entradas,
                                        entradas.precio_compra AS precio_compra,
                                        COALESCE(salidas.suma_cantidad, 0) AS cantidad_salidas,
                                        COALESCE(salidas.precio_venta, 0) AS precio_venta,
                                        (existencias.existencia) AS stock_actual,
                                        (COALESCE(salidas.suma_sub_total, 0) - COALESCE(entradas.suma_sub_total, 0)) AS flujo_actual
                                    FROM
                                        productos
                                    INNER JOIN
                                        (
                                            SELECT
                                                detalle_entradas.idProducto,
                                                COALESCE(SUM(detalle_entradas.sub_total), 0) AS suma_sub_total,
                                                COALESCE(SUM(detalle_entradas.cantidad), 0) AS suma_cantidad,
                                                detalle_entradas.precio_compra
                                            FROM
                                                detalle_entradas
                                            INNER JOIN
                                                entradas ON entradas.idEntrada = detalle_entradas.idEntrada
                                            WHERE
                                                entradas.fecha_entrada BETWEEN '" + inicio + @"' AND '" + fin + @"'
                                            GROUP BY
                                                detalle_entradas.idProducto, detalle_entradas.precio_compra
                                        ) AS entradas ON productos.idProducto = entradas.idProducto
                                        INNER JOIN
                                        (
                                            SELECT
                                                existencias.idProducto,
                                                existencias.existencia
                                            FROM
                                                existencias
                                            GROUP BY
                                                existencias.idProducto, existencias.existencia
                                        ) AS existencias ON productos.idProducto = existencias.idProducto
                                        LEFT JOIN
                                        (
                                            SELECT
                                                detalle_salidas.idProducto,
                                                COALESCE(SUM(detalle_salidas.sub_total), 0) AS suma_sub_total,
                                                COALESCE(SUM(detalle_salidas.cantidad), 0) AS suma_cantidad,
                                                detalle_salidas.precio_venta
                                            FROM
                                                detalle_salidas
                                            INNER JOIN
                                                salidas ON salidas.idSalida = detalle_salidas.idSalida
                                            WHERE
                                                salidas.fecha_salida BETWEEN '" + inicio + @"' AND '" + fin + @"'
                                            GROUP BY
                                                detalle_salidas.idProducto, detalle_salidas.precio_venta
                                        ) AS salidas ON productos.idProducto = salidas.idProducto
                                        WHERE (COALESCE(salidas.suma_sub_total, 0) - COALESCE(entradas.suma_sub_total, 0)) < 0;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable IdDetalleEntradas()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select idDetalleEntrada, idProducto from detalle_entradas;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable Municipios()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select idMunicipio, municipio, b.nombre, a.idDepartamento from municipios a, departamentos b where a.idDepartamento=b.idDepartamento;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable Inventario(string inicio, string fin)
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT
                                        productos.codigo AS codigo_producto,
                                        productos.nombre AS nombre_producto,
                                        productos.descripcion AS descripcion_producto,
                                        entradas.suma_sub_total AS subTotalCompras,
                                        COALESCE(salidas.suma_sub_total, 0) AS subTotalVentas,
                                        entradas.suma_cantidad AS cantidad_entradas,
                                        entradas.precio_compra AS precio_compra,
                                        COALESCE(salidas.suma_cantidad, 0) AS cantidad_salidas,
                                        COALESCE(salidas.precio_venta, 0) AS precio_venta,
                                        (existencias.existencia) AS stock_actual,
                                        (COALESCE(salidas.suma_sub_total, 0) - COALESCE(entradas.suma_sub_total, 0)) AS flujo_actual
                                    FROM
                                        productos
                                    INNER JOIN
                                        (
                                            SELECT
                                                detalle_entradas.idProducto,
                                                COALESCE(SUM(detalle_entradas.sub_total), 0) AS suma_sub_total,
                                                COALESCE(SUM(detalle_entradas.cantidad), 0) AS suma_cantidad,
                                                detalle_entradas.precio_compra
                                            FROM
                                                detalle_entradas
                                            INNER JOIN
                                                entradas ON entradas.idEntrada = detalle_entradas.idEntrada
                                            WHERE
                                                entradas.fecha_entrada BETWEEN '" + inicio + @"' AND '" + fin + @"'
                                            GROUP BY
                                                detalle_entradas.idProducto, detalle_entradas.precio_compra
                                        ) AS entradas ON productos.idProducto = entradas.idProducto
                                        INNER JOIN
                                        (
                                            SELECT
                                                existencias.idProducto,
                                                existencias.existencia
                                            FROM
                                                existencias
                                            GROUP BY
                                                existencias.idProducto, existencias.existencia
                                        ) AS existencias ON productos.idProducto = existencias.idProducto
                                        LEFT JOIN
                                        (
                                            SELECT
                                                detalle_salidas.idProducto,
                                                COALESCE(SUM(detalle_salidas.sub_total), 0) AS suma_sub_total,
                                                COALESCE(SUM(detalle_salidas.cantidad), 0) AS suma_cantidad,
                                                detalle_salidas.precio_venta
                                            FROM
                                                detalle_salidas
                                            INNER JOIN
                                                salidas ON salidas.idSalida = detalle_salidas.idSalida
                                            WHERE
                                                salidas.fecha_salida BETWEEN '" + inicio + @"' AND '" + fin + @"'
                                            GROUP BY
                                                detalle_salidas.idProducto, detalle_salidas.precio_venta
                                        ) AS salidas ON productos.idProducto = salidas.idProducto;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable DocumentoProveedor()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT documento FROM proveedores order by documento desc limit 1;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable Roles()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select idRol, rol from roles;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable Categorias()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select idCategoria, categoria from categorias;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable ReporteClientes()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select * from clientes;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable Productos()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT a.idProducto, a.nombre, a.codigo, a.descripcion, a.precio_venta, c.idExistencia, c.existencia, b.idCategoria, b.categoria
                                    FROM productos a, categorias b, existencias c
                                    WHERE a.idCategoria=b.idCategoria and c.idProducto=a.idProducto order by a.idProducto asc;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable ObtenerUltimoProducto()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select p.idProducto 
                                    from productos p
                                    order by p.idProducto desc limit 1;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable Existencias()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select e.idExistencia, p.nombre , e.existencia from existencias e, productos p
                                    where e.idProducto = p.idProducto;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }


        public static DataTable Clasificaciones()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select  idClasificacion,clasificacion from clasificaciones;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        ///CRUD DE USUARIOS
        public static DataTable VerUsuarios() 
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select u.idusuario, u.usuario, u.clave,e.idEmpleado, e.nombres_empleado,r.idRol, r.rol   from usuarios u, empleados e, roles r
                                     where u.idEmpleado = e.idEmpleado and u.idRol = r.idRol;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable ObtenerUltimaSalida()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT (documento_salida + 1), idSalida FROM salidas
                                    order by documento_salida desc limit 1;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable ObtenerListaDocumentos()
        {
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                DataTable tabla = new DataTable();
                String sentencia = @"SELECT documento_entrada FROM entradas;";
                tabla = operacion.Consultar(sentencia);

                return tabla;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable Departamentos()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select idDepartamento, nombre from departamentos; ";

                DBOperacion operacion = new DBOperacion();
                resultado = operacion.Consultar(sentencia);

                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable ObtenerUltimaEntrada()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT idEntrada FROM entradas
                                    order by idEntrada desc limit 1;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable ExistenciasPorIdProducto(int idProducto)
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select idExistencia,existencia,idProducto from existencias " +
                                    "WHERE idProducto = " + idProducto + ";";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static DataTable VerCategorias()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select idCategoria, categoria from Categorias;" ;
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable VerEntradas()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"select e.idEntrada, e.fecha_entrada, e.cantidad, p.nombre, pro.nombre_proveedor, e.usuario_atendio from entradas e, productos p, proveedores pro
                where e.idProducto=p.idProducto and e.idProveedor = pro.idProveedor;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

        public static ResultadoConsulta VerEntradasProductos() 
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT a.idEntradasProductos,b.cantidad ,c.nombre, b.fecha_entrada FROM entradas_productos a, entradas b, productos c
                                      where a.idEntrada = b.idEntrada and a.idProducto = c.idProducto;";
                DBOperacion operacion = new DBOperacion();
                resultado = operacion.Consultar(sentencia);

                int Count = resultado.Rows.Count;

                ResultadoConsulta resultadoconsulta = new ResultadoConsulta();
                resultadoconsulta.Tabla = resultado;
                resultadoconsulta.NumeroFilas = Count;

                return resultadoconsulta;
            }
            catch (Exception)
            {
                return new ResultadoConsulta();
                throw;
            }
        }
        public class ResultadoConsulta
        {
            public DataTable Tabla { get; set; }
            public int NumeroFilas { get; set; }
        }

       
        public static DataTable Clientes()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT idCliente, nombres_cliente, apellidos_cliente, nacimiento, genero, a.idDireccion, dui, nit, 
                                    concat(b.municipio, ', ', c.nombre, ', Casa N° ', 
                                    ifnull(no_casa, 'No establecida'), ', Calle N° ', ifnull(no_calle, 'No establecida')) direccion 
                                    FROM direcciones a, municipios b, departamentos c, clientes d
                                    WHERE a.idMunicipio=b.idMunicipio and b.idDepartamento=c.idDepartamento and a.idDireccion=d.idDireccion;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable Proveedores()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT d.idProveedor, a.idDireccion, d.nombre, d.documento, d.telefono, 
                                    concat(b.municipio, ', ', c.nombre, ', Casa N° ', 
                                    ifnull(no_casa, 'No establecida'), ', Calle N° ', ifnull(no_calle, 'No establecida')) direccion 
                                    FROM direcciones a, municipios b, departamentos c, proveedores d
                                    WHERE a.idMunicipio=b.idMunicipio and b.idDepartamento=c.idDepartamento and a.idDireccion=d.idDireccion;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable Empleados()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT d.idEmpleado, a.idDireccion, d.nombres_empleado, d.apellidos_empleado, d.nacimiento,d.genero, d.dui, 
                                    concat(b.municipio, ', ', c.nombre, ', Casa N° ', 
                                    ifnull(no_casa, 'No establecida'), ', Calle N° ', ifnull(no_calle, 'No establecida')) direccion 
                                    FROM direcciones a, municipios b, departamentos c, empleados d
                                    WHERE a.idMunicipio=b.idMunicipio and b.idDepartamento=c.idDepartamento and a.idDireccion=d.idDireccion;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable Direcciones()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT idDireccion, a.idMunicipio, a.no_casa, a.no_calle, concat(b.municipio, ', ', c.nombre, ', Casa N° ', 
                                    ifnull(no_casa, 'No establecida'), ', Calle N° ', ifnull(no_calle, 'No establecida')) direccion
                                    FROM direcciones a, municipios b, departamentos c
                                    WHERE a.idMunicipio=b.idMunicipio and b.idDepartamento=c.idDepartamento;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable Salidas()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT idSalida, fecha_salida, cantidad, b.nombres_cliente, usuario_atendio " +
                    "FROM salidas a, clientes b where a.idCliente=b.idCliente;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable SalidasProductos()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT a.idSalida, c.nombre, b.cantidad, b.fecha_salida FROM salidas_productos a, salidas b, productos c;";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        
        public static DataTable VerOpciones()
        {
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                DataTable tabla = new DataTable();
                String sentencia = @"select op.idOpcion, op.opcion, cla.clasificacion from opciones op, clasificaciones cla 
                                    where op.idClasificacion = cla.idClasificacion;";
                tabla = operacion.Consultar(sentencia);

                return tabla;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable Permisos(string idRol)
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"Select a.idOpcion, a.opcion, b.clasificacion, 
                                    IFNULL((SELECT z.idPermiso FROM permisos z where z.idRol=" + idRol + @" and z.idOpcion=a.idOpcion),0) idPermiso, 
                                    IF(IFNULL((SELECT z.idPermiso FROM permisos z where z.idRol=" + idRol + @" and z.idOpcion=a.idOpcion),0)>0,1,0) asignado
                                    From opciones a, clasificaciones b 
                                    where a.idClasificacion=b.idClasificacion;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable Entradas(string doc)
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT e.idEntrada, e.documento_entrada, e.fecha_entrada, u.idUsuario, u.usuario, pro.idProveedor, pro.documento, pro.nombre AS nombre_proveedor,
                                    dt.idDetalleEntrada, dt.idProducto, p.codigo, p.nombre AS nombre_producto, dt.precio_compra, dt.cantidad, dt.sub_total, e.total, p.descripcion
                                    FROM entradas e, usuarios u, proveedores pro, detalle_entradas dt, productos p
                                    WHERE e.idUsuario = u.idUsuario
                                    AND e.idProveedor = pro.idProveedor
                                    AND dt.idEntrada = e.idEntrada
                                    AND dt.idProducto = p.idProducto AND e.documento_entrada='" + doc + "';";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable ConsultarEntradas()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT e.idEntrada, e.documento_entrada, e.fecha_entrada, u.idUsuario, u.usuario, pro.idProveedor, pro.documento, pro.nombre AS nombre_proveedor,
                                    dt.idDetalleEntrada, dt.idProducto, p.codigo, p.nombre AS nombre_producto, dt.precio_compra, e.cantidad, dt.sub_total, e.total
                                    FROM entradas e, usuarios u, proveedores pro, detalle_entradas dt, productos p
                                    WHERE e.idUsuario = u.idUsuario
                                    AND e.idProveedor = pro.idProveedor
                                    AND dt.idEntrada = e.idEntrada
                                    AND dt.idProducto = p.idProducto;";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }
        public static DataTable RangoFechaEntradas(string inicio, string fin)
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT e.idEntrada, e.documento_entrada, e.fecha_entrada, u.idUsuario, u.usuario, pro.idProveedor, pro.documento, pro.nombre AS nombre_proveedor,
                            dt.idDetalleEntrada, dt.idProducto, p.codigo, p.nombre AS nombre_producto, dt.precio_compra, e.cantidad, dt.sub_total, e.total
                            FROM entradas e, usuarios u, proveedores pro, detalle_entradas dt, productos p
                            WHERE e.idUsuario = u.idUsuario
                            AND e.idProveedor = pro.idProveedor
                            AND dt.idEntrada = e.idEntrada
                            AND dt.idProducto = p.idProducto
                            AND e.fecha_entrada BETWEEN '" + inicio + @"' AND '" + fin + @"';";
                DBOperacion operacion = new DBOperacion();

                resultado = operacion.Consultar(sentencia);
                return resultado;
            }
            catch (Exception)
            {
                return new DataTable();
                throw;
            }
        }

    }
}
