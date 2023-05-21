using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class EmpleadosGestion : Form
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
        public EmpleadosGestion()
        {
            InitializeComponent();
            ///Ajustar Tamaño
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

        private void EmpleadosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
            //Codigo para mostrar cuantas filas se 
            lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
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
                MessageBox.Show("Por favor, debe selecionar un empleado", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreBusqueda = txtBucarEmpleado.Text.Trim();

                if (!string.IsNullOrEmpty(nombreBusqueda))
                {
                    string valorNombre = dgvDatos.CurrentRow.Cells["Nombres"].Value.ToString();

                    DataView dv = dataTable.DefaultView;
                    dv.RowFilter = $"Nombres LIKE '%{valorNombre}%'";
                    dgvDatos.DataSource = dv;
                }
                else
                {
                    dgvDatos.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                string mensaje = $"Se produjo un error durante el filtrado de datos:\n\nTipo de error: {ex.GetType()}\n\nMensaje de error: {ex.Message}";

                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBucarEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (txtBucarEmpleado.Text!="")
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
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtBucarEmpleado.Text.ToUpper()) == 0)
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

        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatos();
            txtBucarEmpleado.Text = "";
        }
    }
}
