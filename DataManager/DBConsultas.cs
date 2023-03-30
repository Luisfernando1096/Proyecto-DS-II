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
        public static Boolean InsertarEmpleado(string nombres, string apellidos, string nacimiento, string genero)
        {
            Boolean resultado = false;
            try
            {
                
                String sentencia = "INSERT INTO empleados (nombres, apellidos, nacimiento, genero) VALUES ('" + nombres + "','" + apellidos + "','" + nacimiento + "','" + genero + "');";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();
                if(operacion.EjecutarSentencia(sentencia) > 0)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                
                
                return resultado;
            }
            catch (Exception)
            {
                return resultado;
                throw;
            }
        }
        public static Boolean ActualizarEmpleado(int id, string nombres, string apellidos, string nacimiento, string genero)
        {
            Boolean resultado = false;
            try
            {

                String sentencia = "UPDATE empleados SET nombres = '" + nombres + "', apellidos = '" + apellidos + "', nacimiento = '" + nacimiento + "', genero = '" + genero + "' where idEmpleado = " + id + "; ";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();
                if (operacion.EjecutarSentencia(sentencia) > 0)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }


                return resultado;
            }
            catch (Exception)
            {
                return resultado;
                throw;
            }
        }

        public static Boolean EliminarEmpleado(int id)
        {
            Boolean resultado = false;
            try
            {

                String sentencia = "DELETE FROM empleados where idEmpleado = '" + id + "';";
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();
                if (operacion.EjecutarSentencia(sentencia) > 0)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }


                return resultado;
            }
            catch (Exception)
            {
                return resultado;
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
        public static DataTable Clientes()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT idCliente, nombres_cliente, apellidos_cliente, nacimiento, genero, idDireccion, dui, nit FROM clientes;";
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
                String sentencia = @"SELECT idDireccion, idMunicipio, no_casa, no_calle FROM direcciones;";
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
    }
}
