﻿using MySql.Data.MySqlClient;
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
        
        public static DataTable VerEmpleadosPorNombre(String nombre)
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = "SELECT idEmpleado, nombres, apellidos, nacimiento, genero FROM empleados where nombres like '%" + nombre + "%';";
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
                String sentencia = @"select idProducto,nombre,descripcion,precio_compra,precio_venta,idCategoria from productos;";
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
                String sentencia = @"select idExistencia,existencia,idProducto from existencias;";
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
                String sentencia = @"select u.idusuario, u.usuario, u.clave, e.nombres_empleado, rol   from usuarios u, empleados e, roles r
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
        public static DataTable Empleados()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT idEmpleado, nombres_empleado, apellidos_empleado, nacimiento, genero, idDireccion, dui FROM empleados;";
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
        public static DataTable VerPermisos() 
        {
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                DataTable tabla = new DataTable();
                String sentencia = @"select a.idPermiso, r.rol, op.opcion from permisos a, roles r, opciones op
                                     where a.idRol =r.idRol and a.idOpcion = op.idOpcion order by a.idPermiso;";
                tabla = operacion.Consultar(sentencia);

                return tabla;
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
    }
}
