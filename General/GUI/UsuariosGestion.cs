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
    public partial class UsuariosGestion : Form
    {
        BindingSource datos = new BindingSource();

        private void CargarUsuarios()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.VerUsuarios();
                dgvUsuarios.DataSource = datos;
                dgvUsuarios.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado
            }
            catch (Exception)
            {

                throw;
            }
        }

        public UsuariosGestion()
        {
            InitializeComponent();
        }

        private void UsuariosGestion_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            int var = DataManager.DBConsultas.NumeroRegistrosUsuarios();

            lblRegistrosUsuarios.Text = var + " Registros encontrados ";
        }
    }
}
