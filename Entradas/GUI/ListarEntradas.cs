using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entradas.GUI
{
    public partial class ListarEntradas : Form
    {
        BindingSource datos = new BindingSource();
        public ListarEntradas()
        {
            InitializeComponent();
        }
        private int CargarDatos()
        {
            int registros;
            datos.DataSource = DataManager.DBConsultas.ConsultarEntradas();
            dgvDatos.DataSource = datos;
            dgvDatos.AutoGenerateColumns = false;
            registros = datos.Count;

            return registros;
        }
        private void CargarDatosPorFecha()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.RangoFechaEntradas(dtpInicio.Text, dtpFin.Text);
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ListarEntradas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatosPorFecha();
        }
    }
}
