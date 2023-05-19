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
    public partial class UsuarioEdicion : Form
    {
        public UsuarioEdicion()
        {
            InitializeComponent();
        }
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadosGestion f = new EmpleadosGestion();
            f.btnSeleccionar.Visible = true;
            var result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEmpleado.Text = f.empleadoEnviar + " - " + f.apellidoEnviar;
                txtIdEmpleado.Text = f.idEnviar;
            }
        }

        private void bntBuscarRol_Click(object sender, EventArgs e)
        {
            RolesGestion f = new RolesGestion();
            f.btnSeleccionar.Visible = true;
            var result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtRol.Text = f.rolEnviar;
                txtIdRol.Text = f.idEnviar;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Usuarios u = new CLS.Usuarios();

                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("¡El usuario no puede quedar vacio!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtClave.Text == "")
                {
                    MessageBox.Show("¡Porfavor, debe establecer una clave!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txtClave.Text.Length <= 8)
                {
                    MessageBox.Show("¡La clave debe tener mas caracteres!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtIdEmpleado.Text == "")
                {
                    MessageBox.Show("Por favor, debe seleccionar un empleado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtIdRol.Text == "")
                {
                    MessageBox.Show("Por favor, debe seleccionar un rol!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    u.Usuario = txtUsuario.Text;
                    u.Clave = txtClave.Text;
                    u.IdEmpleado = Int32.Parse(txtIdEmpleado.Text);
                    u.IdRol = Int32.Parse(txtIdRol.Text);

                    if (txtIdUsuario.TextLength > 0)
                    {
                        u.IdUsuario = Int32.Parse(txtIdUsuario.Text);
                        if (u.Actualizar())
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
                        (bool resultadoBusqueda, bool resultadoInsercion) = u.Insertar();
                        if (resultadoBusqueda == false && resultadoInsercion == true)
                        {
                            MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else if (resultadoBusqueda == true && resultadoInsercion == false)
                        {
                            MessageBox.Show("¡Registro no se ha podido ingresar, el empleado ya tiene una cuenta!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("¡El registro no fue insertado correctamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
