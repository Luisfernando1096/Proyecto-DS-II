using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Direcciones
    {
        int idDireccion;
        int idMunicipio;
        String noCasa;
        String noCalle;

        public int IdDireccion { get => idDireccion; set => idDireccion = value; }
        public int IdMunicipio { get => idMunicipio; set => idMunicipio = value; }
        public string NoCasa { get => noCasa; set => noCasa = value; }
        public string NoCalle { get => noCalle; set => noCalle = value; }

        public Boolean Insertar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"INSERT INTO direcciones(idMunicipio, no_casa, no_calle) VALUES(" + idMunicipio + ", '" + noCasa + "', '" + noCalle + "');";

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
            sentencia = @"UPDATE direcciones SET idMunicipio = " + IdMunicipio + ", no_casa = '" + noCasa + "', , no_calle = '" + noCalle + "' " +
                "WHERE idDireccion = " + idDireccion + ";";

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
            sentencia = @"DELETE FROM direcciones " +
                "WHERE idDireccion = " + idDireccion + ";";

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
