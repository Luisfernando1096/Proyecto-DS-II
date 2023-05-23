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
    public partial class VisorExistencias : Form
    {
        public VisorExistencias()
        {
            InitializeComponent();
        }
        private void CargarReporte()
        {
            DataTable datos = new DataTable();
            Reportes.REP.Existencias oReporte = new REP.Existencias();
            datos = DataManager.DBConsultas.ReporteExistencias();
            oReporte.SetDataSource(datos);
            crvVisor.ReportSource = oReporte;
        }
        private void VisorExistencias_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
