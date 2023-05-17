using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Clientes
    {
        int idCliente;
        String nombres;
        String apellidos;
        String nacimiento;
        String genero;
        int idDireccion;
        String dui;
        String nit;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public String Nacimiento { get => nacimiento; set => nacimiento = value; }
        public string Genero { get => genero; set => genero = value; }
        public int IdDireccion { get => idDireccion; set => idDireccion = value; }
        public string Dui { get => dui; set => dui = value; }
        public string Nit { get => nit; set => nit = value; }

        public Boolean Insertar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"INSERT INTO clientes(nombres_cliente, apellidos_cliente, nacimiento, genero, idDireccion, dui, nit)" +
                        " VALUES('" + nombres + "', '" + apellidos + "', '" + nacimiento + "', '" + genero + "', " + idDireccion + ", '" + dui + "', '" + nit + "');";

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
            sentencia = @"UPDATE clientes SET nombres_cliente = '" + nombres + "', apellidos_cliente = '" + apellidos +
                        "', nacimiento = '" + nacimiento + "', genero = '" + genero + "', idDireccion = " + idDireccion +
                        ", dui = '" + dui + "', nit = '" + nit + "'" +
                        " WHERE idCliente = " + idCliente + ";";
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
            sentencia = @"DELETE FROM clientes " +
                "WHERE idCliente = " + idCliente + ";";

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
