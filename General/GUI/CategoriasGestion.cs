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
    public partial class CategoriasGestion : Form
    {
        BindingSource datos = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.VerCategorias();
                dgvCategorias.DataSource = datos;
                dgvCategorias.AutoGenerateColumns = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CategoriasGestion()
        {
            InitializeComponent();
        }

        private void CategoriasGestion_Load(object sender, EventArgs e)
        {
            int var = DataManager.DBConsultas.NumeroRegistrosCategorias();
            CargarDatos();
            lblCategorias.Text = var + " Registros encontrados ";

        }
    }
}
