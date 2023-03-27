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
        public static DataTable VerEmpleados()
        {
            try
            {
                DataTable resultado = new DataTable();
                String sentencia = @"SELECT idEmpleado, nombres_empleado, apellidos_empleado, nacimiento, genero, d.nombre, dui FROM empleados a, direcciones b, municipios c,
                                    departamentos d where a.idDireccion = b.idDireccion and b.idMunicipio = c.idMunicipio and d.idDepartamento = c.idDepartamento;";
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
    }
}
