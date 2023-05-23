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
    public partial class ListClientes : Form
    {
        BindingSource datos = new BindingSource();
        public DataGridViewRow datosCliEnviar;

        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Clientes();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ListClientes()
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
            this.ClientSize = new System.Drawing.Size(totalWidth + 100, totalHeight + 600);
        }

        private void ListClientes_Load(object sender, EventArgs e)
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
                            if (r.Cells["dui"].Value.ToString().ToUpper().IndexOf(txtBuscarPorDoc.Text.ToUpper()) == 0)
                            {
                                r.Visible = true;
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
                            if (r.Cells["nombres_cliente"].Value.ToString().ToUpper().IndexOf(txtBuscarPorNombre.Text.ToUpper()) == 0)
                            {
                                encontradoPorNombre = true;
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
                                if (r.Cells["dui"].Value.ToString().ToUpper().StartsWith(txtBuscarPorDoc.Text.ToUpper()))
                                {
                                    encontradoPorDoc = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtBuscarPorDoc.Text = "";
            txtBuscarPorNombre.Text = "";
            CargarDatos();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            datosCliEnviar = dgvDatos.CurrentRow;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtBuscarPorDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
