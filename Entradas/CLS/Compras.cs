using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entradas.CLS
{
    class Compras
    {
        int idCompra;
        int idProducto;
        int idEntrada;
        int cantidad;
        double precio_compra;
        double precio_venta;
        double sub_total;

        public int IdCompra { get => idCompra; set => idCompra = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdEntrada { get => idEntrada; set => idEntrada = value; }
        public double Precio_compra { get => precio_compra; set => precio_compra = value; }
        public double Precio_venta { get => precio_venta; set => precio_venta = value; }
        public double Sub_total { get => sub_total; set => sub_total = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Boolean Insertar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"INSERT INTO compras(idProducto, idEntrada, cantidad, precio_compra, precio_venta, sub_total) VALUES(" + idProducto + ", " + idEntrada + ", " + cantidad + ", " + precio_compra + ", " + precio_venta + ", " + sub_total + ");";

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
            sentencia = @"UPDATE existencias SET idProducto = " + idProducto + ", idEntrada = " + idEntrada + ", cantidad = " + cantidad + ", precio_compra = " + precio_compra + ", precio_venta = " + precio_venta + ", sub_total = " + sub_total + " " +
                "WHERE idCompra = " + idCompra + ";";

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
            sentencia = @"DELETE FROM compras " +
                "WHERE idCompra = " + idCompra + ";";

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
