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
    public partial class ListEmpleados : Form
    {
        DataTable dataTable = new DataTable();

        BindingSource datos = new BindingSource();
        public string empleadoEnviar { get; set; }
        public string idEnviar { get; set; }
        public String apellidoEnviar { get; set; }

        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Empleados();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado
                //Codigo para insertar los datos en el datagrid

            }
            catch (Exception)
            {

                throw;
            }
        }
        public ListEmpleados()
        {
            InitializeComponent();
        }

        private void LisEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
            lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";

            // Suscribirse al evento ColumnAdded
            dgvDatos.ColumnAdded += dgvDatos_ColumnAdded;

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count != 0)
            {
                empleadoEnviar = dgvDatos.CurrentRow.Cells["Nombres"].Value.ToString();
                apellidoEnviar = dgvDatos.CurrentRow.Cells["Apellidos"].Value.ToString();
                idEnviar = dgvDatos.CurrentRow.Cells["ID"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Empleado.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBucarEmpleado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBucarEmpleado.Text != "")
                {
                    dgvDatos.CurrentCell = null;
                    foreach (DataGridViewRow r in dgvDatos.Rows)
                    {
                        r.Visible = false;
                    }
                    int filasVisibles = 0;
                    foreach (DataGridViewRow r in dgvDatos.Rows)
                    {

                        if (r.Cells["Nombres"].Value.ToString().ToUpper().IndexOf(txtBucarEmpleado.Text.ToUpper()) == 0)
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

        private void dgvDatos_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            // Deshabilitar el ordenamiento en la columna recién agregada
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}
