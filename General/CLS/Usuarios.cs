using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace General.CLS
{
    class Usuarios
    {
        int idUsuario;
        string usuario;
        string clave;
        int idEmpleado;
        int idRol;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int IdRol { get => idRol; set => idRol = value; }

        public (Boolean, Boolean) Insertar()
        {
            Boolean resultadoInsercion = false;
            Boolean resultadoBusqueda = false;
            DataManager.DBOperacion op = new DataManager.DBOperacion();

            try
            {
                DataTable resultado = new DataTable();
                string sentenciaConsulta = "SELECT * FROM usuarios WHERE idEmpleado =  '" + idEmpleado + "';";

                resultado = op.Consultar(sentenciaConsulta);

                if (resultado.Rows.Count > 0)
                {
                    resultadoBusqueda = true;
                    resultadoInsercion = false;
                }
                else
                {
                    string sentencia = @"INSERT INTO usuarios(usuario, clave, idEmpleado, idRol)" +
                        " VALUES('" + usuario + "', sha1(md5('" + clave + @"')), '" + idEmpleado + "', '" + idRol + "');";
                    Int32 filasInsertadas = 0;
                    filasInsertadas = op.EjecutarSentencia(sentencia);

                    if (filasInsertadas > 0)
                    {
                        resultadoBusqueda = false;
                        resultadoInsercion = true;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return (resultadoBusqueda,resultadoInsercion);
        }
        public Boolean Actualizar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"UPDATE Usuarios SET usuario = '" + usuario + "', clave = SHA2(CONCAT(MD5('" + clave + "')), 256), idEmpleado = '" +
                idEmpleado + "', idRol = '" + idRol + "' WHERE idUsuario = " + idUsuario + ";";

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
            sentencia = @"DELETE FROM Usuarios " +
                "WHERE idUsuario = " + idUsuario + ";";
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
