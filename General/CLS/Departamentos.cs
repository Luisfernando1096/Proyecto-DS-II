using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Departamentos
    {
        int idDepartamento;
        string nombre;

        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Boolean Insertar()
        {
            Boolean resultado = false;
            String sentencia = @"INSERT INTO Departamentos(nombre) VALUES('" + nombre + "');";
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
        public Boolean Actuzalizar() 
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"UPDATE Departamentos SET nombre = '" + nombre + "' " +
                "WHERE idDepartamento = " + idDepartamento + ";";

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
            sentencia = @"DELETE FROM Departamentos " +
                "WHERE IdDepartamento = " + IdDepartamento + ";";
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
