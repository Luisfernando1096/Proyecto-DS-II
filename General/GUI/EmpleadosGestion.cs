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
            if (txtBucarEmpleado.Text != "")
            {
                dgvDatos.CurrentCell = null;
                foreach (DataGridViewRow r in dgvDatos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvDatos.Rows)
                {
                    if (r.Cells["Nombres"].Value.ToString().ToUpper().IndexOf(txtBucarEmpleado.Text.ToUpper()) == 0)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            General.GUI.EmpleadosEdicion f = new General.GUI.EmpleadosEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Empleados c = new CLS.Empleados();
                c.IdEmpleado = Int32.Parse(dgvDatos.CurrentRow.Cells["ID"].Value.ToString());
                if (c.Eliminar())
                {
                    MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡El registro no fue eliminado correctamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea editar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EmpleadosEdicion f = new EmpleadosEdicion();
                f.txtIdEmpleado.Text = dgvDatos.CurrentRow.Cells["ID"].Value.ToString();
                f.txtIdDireccion.Text = dgvDatos.CurrentRow.Cells["idDireccion"].Value.ToString();
                f.txtDireccion.Text = dgvDatos.CurrentRow.Cells["direccion"].Value.ToString();
                f.txtNombres.Text = dgvDatos.CurrentRow.Cells["Nombres"].Value.ToString();
                f.txtApellidos.Text = dgvDatos.CurrentRow.Cells["Apellidos"].Value.ToString();
                f.cmbGenero.SelectedItem = dgvDatos.CurrentRow.Cells["genero"].Value.ToString();
                f.dtpNacimiento.Text = dgvDatos.CurrentRow.Cells["nacimiento"].Value.ToString();
                f.txtDui.Text = dgvDatos.CurrentRow.Cells["dui"].Value.ToString();
                f.ShowDialog();
            }
            CargarDatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
