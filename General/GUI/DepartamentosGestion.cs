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
    public partial class DepartamentosGestion : Form
    {
        private void CargarDatos() 
        {
            BindingSource datos = new BindingSource();
            try
            {
                datos.DataSource = DataManager.DBConsultas.VerDepartamentos();
                dgvDepartamentos.DataSource = datos;
                dgvDepartamentos.AutoGenerateColumns = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DepartamentosGestion()
        {
            InitializeComponent();
        }

        private void DepartamentosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
            int var = DataManager.DBConsultas.NumeroRegistrosDepartamentos();
            lblDepartamentos.Text = var + " Registros encontrados ";
        }
    }
}
