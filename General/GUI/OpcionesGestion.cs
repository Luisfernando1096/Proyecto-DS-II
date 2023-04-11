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
    public partial class OpcionesGestion : Form
    {
        BindingSource datos = new BindingSource();

        public OpcionesGestion()
        {
            InitializeComponent();
        }
        private int CargarDatos()
        {
            int registros;
            datos.DataSource = DataManager.DBConsultas.VerOpciones();
            dgvDatosClasificaciones.DataSource = datos;
            dgvDatosClasificaciones.AutoGenerateColumns = false;
            registros = datos.Count;

            return registros;
        }

        private void OpcionesGestion_Load(object sender, EventArgs e)
        {
            lblRegistros.Text = CargarDatos().ToString() + " Registros encontrados";
        }
    }
}
