using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Salidas
    {
        int idSalida;
        String fechaSalida;
        int cantidad;
        int idCliente;
        String usuarioAtendio;

        public int IdSalida { get => idSalida; set => idSalida = value; }
        public string FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string UsuarioAtendio { get => usuarioAtendio; set => usuarioAtendio = value; }
        public Boolean Insertar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"INSERT INTO salidas(fecha_salida, cantidad, idCliente, usuario_atendio) VALUES('" + fechaSalida + "', " + cantidad + ", " + idCliente + ", '" + usuarioAtendio + "');";

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
            sentencia = @"UPDATE sañidas SET fecha_salida = '" + fechaSalida + "', cantidad = '" + cantidad + "', idCliente = " + idCliente + ", usuario_atendio = '" + usuarioAtendio + "' " +
                "WHERE idSalida = " + idSalida + ";";

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
            sentencia = @"DELETE FROM salidas " +
                "WHERE idSalida = " + idSalida + ";";

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
