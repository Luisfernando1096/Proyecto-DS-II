using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Empleados
    {
        int idEmpleado;
        String nombres;
        String apellidos;
        String nacimiento;
        String genero;
        int idDireccion;
        String dui;

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nacimiento { get => nacimiento; set => nacimiento = value; }
        public string Genero { get => genero; set => genero = value; }
        public int IdDireccion { get => idDireccion; set => idDireccion = value; }
        public string Dui { get => dui; set => dui = value; }

        public Boolean Insertar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"INSERT INTO empleados(nombres_empleado, apellidos_empleado, nacimiento, genero, idDireccion, dui)" +
                        " VALUES('" + nombres + "', '" + apellidos + "', '" + nacimiento + "', '" + genero + "', " + idDireccion + ", '" + dui + "');";

            try
            {
                DataManager.DBOperacion op = new DataManager.DBOperacion();
                Int32 filasInsertadas = 0;
                filasInsertadas = op.EjecutarSentencia(sentencia);
                if (filasInsertadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public Boolean Actualizar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"UPDATE empleados SET nombres_empleado = '" + nombres + "', apellidos_empleado = '" + apellidos +
                        "', nacimiento = '" + nacimiento + "', genero = '" + genero + "', idDireccion = " + idDireccion +
                        ", dui = '" + dui + "'" +
                        " WHERE idEmpleado = " + idEmpleado + ";";
            try
            {
                DataManager.DBOperacion op = new DataManager.DBOperacion();
                Int32 filasActualizadas = 0;
                filasActualizadas = op.EjecutarSentencia(sentencia);
                if (filasActualizadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return resultado;
        }

        public Boolean Eliminar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"DELETE FROM empleados " +
                "WHERE idEmpleado = " + idEmpleado + ";";
            try
            {
                DataManager.DBOperacion op = new DataManager.DBOperacion();
                Int32 filasEliminadas = 0;
                filasEliminadas = op.EjecutarSentencia(sentencia);
                if (filasEliminadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }
    }
}
