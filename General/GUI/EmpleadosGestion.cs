using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class EmpleadosGestion : Form
    {
        BindingSource datos = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Empleados();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado
                //Codigo para insertar los datos en el datagrid

            }
            catch (Exception)
            {

                throw;
            }
        }
        public EmpleadosGestion()
        {
            InitializeComponent();
        }

        private void EmpleadosGestion_Load(object sender, EventArgs e)
        {
            int filas = 0;
            CargarDatos();
            //Codigo para mostrar cuantas filas se encontraron
            foreach (DataRowView item in datos)
            {
                filas++;
            }
            lblRegistros.Text = filas.ToString() + " Registros Encontrados";
        }
    }
}
