using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class DBConexion
    {
        String _CadenaConexion = "Server=localhost;Port=3306;Database=bd_inventario;Uid=userInventario;Pwd=Pa55word;";
        protected MySqlConnection conexion = new MySqlConnection();


        public Boolean Conectar()
        {
            Boolean result = false;
            try
            {
                conexion.ConnectionString = _CadenaConexion;
                conexion.Open();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public void Desconectar()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception)
            {

            }
        }

    }
}
