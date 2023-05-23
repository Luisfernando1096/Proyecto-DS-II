using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salidas.CLS
{
    public class DatalleSalidas
    {
        int idDetalleSalida;
        int idSalida;
        int idProducto;
        int cantidad;
        double precio_venta;
        double subTotal;

        public int IdSalida { get => idSalida; set => idSalida = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double SubTotal { get => subTotal; set => subTotal = value; }
        public double Precio_venta { get => precio_venta; set => precio_venta = value; }
        public int IdDetalleSalida { get => idDetalleSalida; set => idDetalleSalida = value; }

        public Boolean Insertar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"INSERT INTO detalle_salidas(idSalida, idProducto, cantidad, precio_venta, sub_total) VALUES(" + idSalida + ", " + idProducto + ", " + cantidad + ", " + precio_venta + ", " + subTotal + ");";

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
            sentencia = @"UPDATE detalle_salidas SET idSalida = " + idSalida + ", idProducto = " + idProducto + ", cantidad = '" + cantidad + "', precio_venta = " + precio_venta + " , sub_total = " + subTotal + " " +
                "WHERE idDetalleSalida = " + idDetalleSalida + ";";

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
            sentencia = @"DELETE FROM detalle_salidas " +
                "WHERE idDetalleSalida = " + idDetalleSalida + ";";

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

        public bool ActualizarPrecio()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"UPDATE detalle_salidas SET precio_venta = " + precio_venta + " " +
                "WHERE idDetalleSalida = " + idDetalleSalida + ";";

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
    }
}
