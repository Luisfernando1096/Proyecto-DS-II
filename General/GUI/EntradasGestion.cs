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
    public partial class EntradasGestion : Form
    {
        BindingSource datos = new BindingSource();
        public EntradasGestion()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            datos.DataSource = DataManager.DBConsultas.VerEntradas();
            dgvEntradas.DataSource = datos;
            dgvEntradas.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado

        }

        private void EntradasGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
            //Codigo para mostrar cuantas filas se 
            lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
        }
    }
}
