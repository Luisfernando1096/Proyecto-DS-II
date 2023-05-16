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
    public partial class VisorCliente : Form
    {
        private void CargarReporte()
        {
            DataTable datos = new DataTable();
            Reportes.REP.Clientes oReporte = new REP.Clientes();
            datos = DataManager.DBConsultas.ReporteClientes();
            oReporte.SetDataSource(datos);
            crvVisor.ReportSource = oReporte;
        }
        public VisorCliente()
        {
            InitializeComponent();
        }

        private void crvVisor_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
