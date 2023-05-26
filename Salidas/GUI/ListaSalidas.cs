using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salidas.GUI
{
    public partial class ListaSalidas : Form
    {
        BindingSource datos = new BindingSource();
        private void CargarDatos()
        {

            try
            {
                datos.DataSource = DataManager.DBConsultas.SalidasLista();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ListaSalidas()
        {
            InitializeComponent();
        }

        private void ListaSalidas_Load(object sender, EventArgs e)
        {
            CargarDatos();
            //Codigo para mostrar cuantas filas se 
            lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
        }

        private void cmbOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOpcion.SelectedIndex == 0)
            {
                CargarDatos();
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
                lblFiltrar.Text = "| Todos";
            }
            else if (cmbOpcion.SelectedIndex == 1)
            {
                datos.DataSource = DataManager.DBConsultas.SalidaPorClientes();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
                lblFiltrar.Text = " |Ordenado por clientes ";
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
            }
            else if (cmbOpcion.SelectedIndex == 2)
            {
                datos.DataSource = DataManager.DBConsultas.SalidaPorDocumento();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
                lblFiltrar.Text = " |Ordenado por documento de salida ";
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
            }
            else if (cmbOpcion.SelectedIndex == 3)
            {
                datos.DataSource = DataManager.DBConsultas.SalidaPorFecha();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
                lblFiltrar.Text = " |Ordenado por fecha ";
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
            }
            else if (cmbOpcion.SelectedIndex == 4)
            {
                datos.DataSource = DataManager.DBConsultas.SalidaPorTotal();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
                lblFiltrar.Text = " |Ordenado por total ";
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
            }
            else if (cmbOpcion.SelectedIndex == 5)
            {
                datos.DataSource = DataManager.DBConsultas.SalidaPorUsuario();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
                lblFiltrar.Text = " |Ordenado por usuario ";
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
            }
            else if (cmbOpcion.SelectedIndex == 6)
            {
                datos.DataSource = DataManager.DBConsultas.SalidaPorListaDetalles();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
                lblFiltrar.Text = " |Ordenado por cantidad de detalles ";
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
            }
            else
            {
                MessageBox.Show("No se encontraron resultados", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
