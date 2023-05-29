using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.GUI
{
    public partial class KardexGenerar : Form
    {
        BindingSource datos = new BindingSource();
        public KardexGenerar()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.ReporteKardex(txtBusqueda.Text);
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0)
            {
                DataTable datos = new DataTable();
                Reportes.REP.Kardex oReporte = new Reportes.REP.Kardex();
                datos = DataManager.DBConsultas.ReporteKardex(txtBusqueda.Text);
                oReporte.SetDataSource(datos);
                Reportes.GUI.VisorKardex f = new Reportes.GUI.VisorKardex();
                f.crvVisor.ReportSource = oReporte;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay datos que mostrar en el reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
