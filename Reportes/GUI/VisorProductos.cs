using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes.GUI
{
    public partial class VisorProductos : Form
    {

        private void CargarReporte()
        {
            DataTable datos = new DataTable();
            Reportes.REP.Productos oReporte = new REP.Productos();
            datos = DataManager.DBConsultas.ReporteProductos();
            oReporte.SetDataSource(datos);
            crvVisor1.ReportSource = oReporte;
        }
        public VisorProductos()
        {
            InitializeComponent();
        }

        private void crvVisor1_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
