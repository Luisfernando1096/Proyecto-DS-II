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
    public partial class PermisosGestion : Form
    {
        BindingSource datos = new BindingSource();

        private int CargarDatos() 
        {
            int registros;
            datos.DataSource = DataManager.DBConsultas.VerPermisos();
            dgvDatosPermisos.DataSource = datos;
            dgvDatosPermisos.AutoGenerateColumns = false;
            registros = datos.List.Count;

            return registros;
        }
        public PermisosGestion()
        {
            InitializeComponent();
        }

        private void PermisosGestion_Load(object sender, EventArgs e)
        {
            lblRegistros.Text = CargarDatos().ToString() + " Registros encontrados"; 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
