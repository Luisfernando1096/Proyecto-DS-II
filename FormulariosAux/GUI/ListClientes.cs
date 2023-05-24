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
        }

        private void ListClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void FiltrarDatos()
        {
            try
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


        private void txtBuscarPorNombre_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            datosCliEnviar = dgvDatos.CurrentRow;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
