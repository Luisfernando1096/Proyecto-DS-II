using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosAux.GUI
{
    public partial class ListProductos : Form
    {
        BindingSource datos = new BindingSource();
        public DataGridViewRow datosProEnviar;

        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Productos();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado
                //Codigo para insertar los datos en el datagrid

            }
            catch (Exception)
            {

                throw;
            }
        }
        public ListProductos()
        {
            InitializeComponent();
        }

        private void ListProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";

            // Suscribirse al evento ColumnAdded
            dgvDatos.ColumnAdded += dgvDatos_ColumnAdded;

        }

        /* private void FiltrarDatos()
        {
            try
            {
                if (txtBuscarPorNombre.Text != "")
                {
                    dgvDatos.CurrentCell = null;
                    foreach (DataGridViewRow r in dgvDatos.Rows)
                    {
                        bool encontradoPorNombre = false;
                        if (r.Cells["nombre"].Value.ToString().ToUpper().IndexOf(txtBuscarPorNombre.Text.ToUpper()) == 0)
                        {
                            encontradoPorNombre = true;
                        }
                        r.Visible = encontradoPorNombre;
                    }
                }
                else
                {
                    CargarDatos();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtBuscarPorDoc_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void txtBuscarPorDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }*/


        private void txtBuscarPorNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarPorNombre.Text != "")
                {
                    dgvDatos.CurrentCell = null;
                    foreach (DataGridViewRow r in dgvDatos.Rows)
                    {
                        r.Visible = false;
                    }
                    int filasVisibles = 0;
                    foreach (DataGridViewRow r in dgvDatos.Rows)
                    {

                        if (r.Cells["nombre"].Value.ToString().ToUpper().IndexOf(txtBuscarPorNombre.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            filasVisibles++;
                        }
                    }
                    if (filasVisibles > 1)
                    {
                        lblRegistros.Text = filasVisibles + " Resultados";
                    }
                    else
                    {
                        lblRegistros.Text = filasVisibles + " Resultado";
                    }
                }
                else
                {
                    CargarDatos();
                    lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count != 0)
            {
                datosProEnviar = dgvDatos.CurrentRow;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Producto.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvDatos_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            // Deshabilitar el ordenamiento en la columna recién agregada
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}
