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
            int totalWidth = 0;
            int totalHeight = 0;

            foreach (DataGridViewColumn column in dgvDatos.Columns)
            {
                totalWidth += column.Width;
            }

            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                totalHeight += row.Height;
            }

            // Ajustar el tamaño del formulario
            this.ClientSize = new System.Drawing.Size(totalWidth + 100, totalHeight + 500);
        }

        private void ListProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void FiltrarDatos()
        {
            try
            {
                if (txtBuscarPorNombre.Text == "")
                {
                    if (txtBuscarPorDoc.Text != "")
                    {
                        dgvDatos.CurrentCell = null;
                        foreach (DataGridViewRow r in dgvDatos.Rows)
                        {
                            r.Visible = false;
                        }
                        foreach (DataGridViewRow r in dgvDatos.Rows)
                        {
                            foreach (DataGridViewCell c in r.Cells)
                            {
                                if ((c.Value.ToString().ToUpper()).IndexOf(txtBuscarPorDoc.Text.ToUpper()) == 0)
                                {
                                    r.Visible = true;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        CargarDatos();
                    }
                }
                else
                {
                    if (txtBuscarPorNombre.Text != "")
                    {
                        dgvDatos.CurrentCell = null;
                        foreach (DataGridViewRow r in dgvDatos.Rows)
                        {
                            bool encontradoPorNombre = false;
                            foreach (DataGridViewCell c in r.Cells)
                            {
                                if ((c.Value.ToString().ToUpper()).IndexOf(txtBuscarPorNombre.Text.ToUpper()) == 0)
                                {
                                    encontradoPorNombre = true;
                                    break;
                                }
                            }
                            r.Visible = encontradoPorNombre;
                        }
                    }

                    if (txtBuscarPorDoc.Text != "")
                    {
                        foreach (DataGridViewRow r in dgvDatos.Rows)
                        {
                            if (r.Visible)
                            {
                                bool encontradoPorDoc = false;
                                foreach (DataGridViewCell c in r.Cells)
                                {
                                    string valorCelda = c.Value.ToString().ToUpper();
                                    string valorBuscado = txtBuscarPorDoc.Text.ToUpper();

                                    // Realizar comparación utilizando StartsWith() para ignorar los ceros iniciales o caracteres en blanco
                                    if (valorCelda.StartsWith(valorBuscado))
                                    {
                                        encontradoPorDoc = true;
                                        break;
                                    }
                                }
                                r.Visible = encontradoPorDoc;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtBuscarPorNombre_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatos();
            txtBuscarPorDoc.Text = "";
            txtBuscarPorNombre.Text = "";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            datosProEnviar = dgvDatos.CurrentRow;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
