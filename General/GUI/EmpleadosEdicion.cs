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
    public partial class EmpleadosEdicion : Form
    {
        public EmpleadosEdicion()
        {
            InitializeComponent();
            // Establecer el formato personalizado
            dtpNacimiento.Format = DateTimePickerFormat.Custom;
            dtpNacimiento.CustomFormat = "yyyy/MM/dd";
            cmbGenero.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DireccionesGestion f = new DireccionesGestion();
            f.btnSeleccionar.Visible = true;
            var result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDireccion.Text = f.direccionEnviar;
                txtIdDireccion.Text = f.idEnviar;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombres.Text == "")
                {
                    MessageBox.Show("El campo Nombres no puede estar vacío. Por favor, ingrese un valor.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtApellidos.Text == "")
                {
                    MessageBox.Show("El campo Apellidos no puede estar vacío. Por favor, ingrese un valor.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtDireccion.Text == "")
                {
                    MessageBox.Show("El campo Direccion no puede estar vacío. Por favor, Selecione una direccion.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtDui.Text == "")
                {
                    MessageBox.Show("Por favor, Ingrese su Numero de Identidad(DUI)", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Crear el objeto entidad
                    CLS.Empleados c = new CLS.Empleados();
                    //Sincronizar la entidad con la interfaz
                    c.Nombres = txtNombres.Text;
                    c.Apellidos = txtApellidos.Text;
                    c.Nacimiento = dtpNacimiento.Text.ToString();
                    c.Genero = cmbGenero.SelectedItem.ToString();
                    c.IdDireccion = Int32.Parse(txtIdDireccion.Text);
                    c.Dui = txtDui.Text;
                    //Realizar la operacion necesaria

                    if (txtIdEmpleado.TextLength > 0)
                    {
                        c.IdEmpleado = Int32.Parse(txtIdEmpleado.Text);
                        if (c.Actualizar())
                        {
                            MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("¡El registro no se actualizo correctamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (c.Insertar())
                        {
                            MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("¡El registro no fue insertado correctamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
