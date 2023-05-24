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
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "yyyy/MM/dd";
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.CustomFormat = "yyyy/MM/dd";
        }
        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Inventario(dtpInicio.Text, dtpFin.Text);
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Visible = false;
            btnFiltrar.Visible = false;
            cmbOpcion.SelectedIndex = -1;
            cmbOpcion.Text = "Seleccione opcion";
            CargarDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.InventarioPorNombre(txtBusqueda.Text, dtpInicio.Text, dtpFin.Text);
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbOpcion.SelectedIndex == 0)
            {
                txtBusqueda.Visible = true;
                btnFiltrar.Visible = true;
            }else if (cmbOpcion.SelectedIndex == 1)
            {
                //mostrar flujo menor a cero
                txtBusqueda.Visible = false;
                btnFiltrar.Visible = false;
                try
                {
                    datos.DataSource = DataManager.DBConsultas.FlujoMenor(dtpInicio.Text, dtpFin.Text);
                    dgvDatos.DataSource = datos;
                    dgvDatos.AutoGenerateColumns = false;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else if (cmbOpcion.SelectedIndex == 2)
            {
                //mostrar flujo>0=
                txtBusqueda.Visible = false;
                btnFiltrar.Visible = false;
                try
                {
                    datos.DataSource = DataManager.DBConsultas.FlujoMayor(dtpInicio.Text, dtpFin.Text);
                    dgvDatos.DataSource = datos;
                    dgvDatos.AutoGenerateColumns = false;
                }
                catch (Exception)
                {

                    throw;
                }

            }
            else
            {
                txtBusqueda.Visible = false;
                btnFiltrar.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count>0)
            {
                if (cmbOpcion.SelectedIndex == 0)
                {
                    DataTable datos = new DataTable();
                    Reportes.REP.Inventario oReporte = new Reportes.REP.Inventario();
                    datos = DataManager.DBConsultas.InventarioPorNombre(txtBusqueda.Text, dtpInicio.Text, dtpFin.Text);
                    oReporte.SetDataSource(datos);
                    Reportes.GUI.VisorInventario f = new Reportes.GUI.VisorInventario();
                    f.crvVisor.ReportSource = oReporte;
                    f.ShowDialog();
                }
                else if (cmbOpcion.SelectedIndex == 1)
                {
                    DataTable datos = new DataTable();
                    Reportes.REP.Inventario oReporte = new Reportes.REP.Inventario();
                    datos = DataManager.DBConsultas.FlujoMenor(dtpInicio.Text, dtpFin.Text);
                    oReporte.SetDataSource(datos);
                    Reportes.GUI.VisorInventario f = new Reportes.GUI.VisorInventario();
                    f.crvVisor.ReportSource = oReporte;
                    f.ShowDialog();
                }
                else if (cmbOpcion.SelectedIndex == 2)
                {
                    DataTable datos = new DataTable();
                    Reportes.REP.Inventario oReporte = new Reportes.REP.Inventario();
                    datos = DataManager.DBConsultas.FlujoMayor(dtpInicio.Text, dtpFin.Text);
                    oReporte.SetDataSource(datos);
                    Reportes.GUI.VisorInventario f = new Reportes.GUI.VisorInventario();
                    f.crvVisor.ReportSource = oReporte;
                    f.ShowDialog();
                }
                else
                {
                    DataTable datos = new DataTable();
                    Reportes.REP.Inventario oReporte = new Reportes.REP.Inventario();
                    datos = DataManager.DBConsultas.Inventario(dtpInicio.Text, dtpFin.Text);
                    oReporte.SetDataSource(datos);
                    Reportes.GUI.VisorInventario f = new Reportes.GUI.VisorInventario();
                    f.crvVisor.ReportSource = oReporte;
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay datos que mostrar en el reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
