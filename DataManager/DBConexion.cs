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
        String _CadenaConexion = Utilidades.CLS.ConnectionStringEncryptor.DecryptConnectionString("hGs+/F9OcjXWiAsnWxEEsigOPd8fHQui0GNkO92jjE0FaUhQQpvbVFXSWle0EMTcqd50H2IUIP19/TLgpueFbd6/HRLsGp2XCtNoRWxZSNATak7xuhObUYgNpTUNViVC");
        
        protected MySqlConnection conexion = new MySqlConnection();

        public Boolean Conectar()
        {
            Console.WriteLine(_CadenaConexion);
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
