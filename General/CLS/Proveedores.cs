using System;

namespace General.CLS
{
    internal class Proveedores
    {
        int idProveedor;
        string documento;
        string nombre;
        string telefono;
        int idDireccion;

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int IdDireccion { get => idDireccion; set => idDireccion = value; }
        public string Documento { get => documento; set => documento = value; }

        public Boolean Insertar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"INSERT INTO proveedores(nombre, documento, telefono, idDireccion) VALUES('" + nombre + "', '" + documento + "', '" + telefono + "', " + idDireccion + ");";

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
            sentencia = @"UPDATE proveedores SET nombre = '" + nombre + "', documento = '" + documento + "', telefono = '" + telefono + "', idDireccion = " + idDireccion + " " +
                "WHERE idProveedor = " + idProveedor + ";";

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
            sentencia = @"DELETE FROM proveedores " +
                "WHERE idProveedor = " + idProveedor + ";";

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