using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCDI.GUI
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            dtpNacimiento.Format = DateTimePickerFormat.Custom;
            dtpNacimiento.CustomFormat = "yyyy/MM/dd";
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            DataTable allEmpleados = DataManager.DBConsultas.VerEmpleados();
            dgvEmpleados.DataSource = allEmpleados;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MostrarListaCompletaEmpleados();
        }
        private void MostrarListaCompletaEmpleados()
        {
            DataTable allEmpleados = DataManager.DBConsultas.VerEmpleadosPorNombre(txtBusquedaEmpleado.Text);
            dgvEmpleados.DataSource = allEmpleados;
        }
        private void LimpiarCampos()
        {
            txtIdEmpleado.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            DateTime fecha = DateTime.Parse(DateTime.Now.ToString());
            dtpNacimiento.Value = fecha;
            cmbGenero.SelectedIndex = 0;
        }
        private Boolean CamposVacios()
        {
            Boolean resultado = false;

            if (txtNombres.Text.Equals("")) resultado = true;
            if (txtApellidos.Equals("")) resultado = true;
            if (cmbGenero.SelectedIndex < 0) resultado = true;

            return resultado;
        }

        private void dgvEmpleados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                List<String> valores = new List<string>();

                for (int i = 0; i < dgvEmpleados.Columns.Count; i++)
                {
                    valores.Add(dgvEmpleados.Rows[e.RowIndex].Cells[i].Value.ToString());
                }
                txtIdEmpleado.Text = valores[0];
                txtNombres.Text = valores[1];
                txtApellidos.Text = valores[2];
                DateTime fecha = DateTime.Parse(valores[3]);
                dtpNacimiento.Value = fecha;
                if (valores[4].Equals("Masculino"))
                {
                    cmbGenero.SelectedIndex = 0;
                }
                else
                {
                    cmbGenero.SelectedIndex = 1;
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!CamposVacios())
            {
                if (txtIdEmpleado.Text.Equals(""))
                {
                    Boolean insertado = false;
                    insertado = DataManager.DBConsultas.InsertarEmpleado(txtNombres.Text.ToString(), txtApellidos.Text.ToString(), dtpNacimiento.Text.ToString(), cmbGenero.Text.ToString());
                    if (insertado)
                    {
                        MessageBox.Show("Registro exitoso");
                        MostrarListaCompletaEmpleados();
                        LimpiarCampos();

                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar el registro");
                    }
                }
                else
                {
                    MessageBox.Show("El id ya esta en uso, limpie los campos e intente de nuevo");
                }
                
            }
            else
            {
                MessageBox.Show("Hay campos vacios o no seleccionados");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!txtIdEmpleado.Text.Equals(""))
            {
                Boolean eliminado = false;
                eliminado = DataManager.DBConsultas.EliminarEmpleado(Int32.Parse(txtIdEmpleado.Text.ToString()));
                if (eliminado)
                {
                    MessageBox.Show("Registro eliminado");
                    MostrarListaCompletaEmpleados();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operacion");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un empleado para eliminar");
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!txtIdEmpleado.Text.Equals(""))
            {
                Boolean modificado = false;
                modificado = DataManager.DBConsultas.ActualizarEmpleado(Int32.Parse(txtIdEmpleado.Text.ToString()), txtNombres.Text.ToString(), txtApellidos.Text.ToString(), dtpNacimiento.Text.ToString(), cmbGenero.Text.ToString());
                if (modificado)
                {
                    MessageBox.Show("Registro modificado");
                    MostrarListaCompletaEmpleados();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operacion");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un empleado para modificar");
            }
        }
    }
}
