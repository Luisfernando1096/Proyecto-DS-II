using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Productos
    {

        int idProducto;
        String codigo;
        String nombre;
        String descripcion ;
        double precio_venta;
        int idCategoria;
        

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio_venta { get => precio_venta; set => precio_venta = value; }
        public int Idcategoria { get => idCategoria; set => idCategoria = value; }
        public string Codigo { get => codigo; set => codigo = value; }

        public Boolean Insertar()
        {
            Boolean resultado = false;
            String sentencia = @"INSERT INTO Productos (nombre, codigo, descripcion, precio_venta, idCategoria) VALUES('" + nombre + "','" + codigo + "','" + descripcion + "','" + precio_venta + "','" + idCategoria + "');";
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
            sentencia = @"UPDATE Productos SET nombre = '" + nombre + "', codigo = '" + codigo + "', descripcion  = '" + descripcion + "', precio_venta  = '" + precio_venta + "',  idCategoria  = '" + idCategoria + "' " +
                "WHERE idProducto = " + idProducto + ";";

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
            string sentencia = @"START TRANSACTION;
                     DELETE FROM existencias WHERE idProducto = " + idProducto + @";
                     DELETE FROM productos WHERE idProducto = " + idProducto + @";
                     COMMIT;";
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
