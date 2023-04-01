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
    public partial class EntradasProductosGestion : Form
    {
        BindingSource datos = new BindingSource();

        public void CargarDatos(DataManager.DBConsultas.ResultadoConsulta resultadoConsulta) 
        {
            datos.DataSource = resultadoConsulta.Tabla;
            dgvDatos.DataSource = datos;
            dgvDatos.AutoGenerateColumns = false;
        }

        public EntradasProductosGestion()
        {
            InitializeComponent();
        }

        private void EntradasProductosGestion_Load(object sender, EventArgs e)
        {
            DataManager.DBConsultas.ResultadoConsulta resultadoConsulta = DataManager.DBConsultas.VerEntradasProductos();
            CargarDatos(resultadoConsulta);
            int numeroRegistros = resultadoConsulta.NumeroFilas;

            lblRegistros.Text = numeroRegistros.ToString() +  " Registros encontrados";

        }
    }
}
