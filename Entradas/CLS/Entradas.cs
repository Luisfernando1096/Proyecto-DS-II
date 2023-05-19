using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entradas.CLS
{
    class Entradas
    {
        int idEntrada;
        string documento_entrada;
        string fecha_entrada;
        int idUsuario;
        int cantidad;
        int idProveedor;
        double total;

        public int IdEntrada { get => idEntrada; set => idEntrada = value; }
        public string Documento_entrada { get => documento_entrada; set => documento_entrada = value; }
        public string Fecha_entrada { get => fecha_entrada; set => fecha_entrada = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public double Total { get => total; set => total = value; }
        public Boolean Insertar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"INSERT INTO entradas(documento_entrada, fecha_entrada, idUsuario, cantidad, idProveedor, total) VALUES('" + documento_entrada + "', '" + fecha_entrada + "', " + idUsuario + ", " + cantidad + ", " + idProveedor + ", " + total + ");";

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
            sentencia = @"UPDATE entradas SET documento_entrada = '" + documento_entrada + "', fecha_entrada = '" + fecha_entrada + "', idUsuario = " + idUsuario + ", cantidad = " + cantidad + ", idProveedor = " + idProveedor + ", total = " + total + " " +
                "WHERE idEntrada = " + idEntrada + ";";

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
            sentencia = @"DELETE FROM entradas " +
                "WHERE idEntrada = " + idEntrada + ";";

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
