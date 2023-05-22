using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entradas.CLS
{
    class DetalleEntradas
    {
        int idDetalleEntradas;
        int idProducto;
        int idEntrada;
        int cantidad;
        double precio_compra;
        double sub_total;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdEntrada { get => idEntrada; set => idEntrada = value; }
        public double Precio_compra { get => precio_compra; set => precio_compra = value; }
        public double Sub_total { get => sub_total; set => sub_total = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int IdDetalleEntradas { get => idDetalleEntradas; set => idDetalleEntradas = value; }

        public Boolean Insertar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"INSERT INTO detalle_entradas(idProducto, idEntrada, cantidad, precio_compra, sub_total) VALUES(" + idProducto + ", " + idEntrada + ", " + cantidad + ", " + precio_compra + ", " + sub_total + ");";

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
            sentencia = @"UPDATE detalle_entradas SET idProducto = " + idProducto + ", idEntrada = " + idEntrada + ", cantidad = " + cantidad + ", precio_compra = " + precio_compra + ", sub_total = " + sub_total + " " +
                "WHERE idDetalleEntrada = " + idDetalleEntradas + ";";

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
        public Boolean ActualizarPrecio()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"UPDATE detalle_entradas SET precio_compra = " + precio_compra + " " +
                "WHERE idDetalleEntrada = " + idDetalleEntradas + ";";

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
            sentencia = @"DELETE FROM detalle_entradas " +
                "WHERE idDetalleEntrada = " + idDetalleEntradas + ";";

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
