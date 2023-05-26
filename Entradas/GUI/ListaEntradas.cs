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
    public partial class ListaEntradas : Form
    {
        BindingSource datos = new BindingSource();
        private void CargarDatos()
        {

            try
            {
                datos.DataSource = DataManager.DBConsultas.EntradasLista();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ListaEntradas()
        {
            InitializeComponent();
        }

        private void ListaEntradas_Load(object sender, EventArgs e)
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
                datos.DataSource = DataManager.DBConsultas.EntradasPorProveedores();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
                lblFiltrar.Text = " |Ordenado por proveedores ";
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
            }
            else if (cmbOpcion.SelectedIndex == 2)
            {
                datos.DataSource = DataManager.DBConsultas.EntradasPorDocumento();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
                lblFiltrar.Text = " |Ordenado por documento de entrada ";
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
            }
            else if (cmbOpcion.SelectedIndex == 3)
            {
                datos.DataSource = DataManager.DBConsultas.EntradasPorFecha();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
                lblFiltrar.Text = " |Ordenado por fecha ";
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
            }
            else if (cmbOpcion.SelectedIndex == 4)
            {
                datos.DataSource = DataManager.DBConsultas.EntradasPorTotal();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
                lblFiltrar.Text = " |Ordenado por total ";
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
            }
            else if (cmbOpcion.SelectedIndex == 5)
            {
                datos.DataSource = DataManager.DBConsultas.EntradasPorUsuario();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
                lblFiltrar.Text = " |Ordenado por usuario ";
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
            }
            else if (cmbOpcion.SelectedIndex == 6)
            {
                datos.DataSource = DataManager.DBConsultas.EntradasPorListaDetalles();
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
