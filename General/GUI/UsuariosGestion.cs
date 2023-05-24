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
    public partial class UsuariosGestion : Form
    {
        BindingSource datos = new BindingSource();


        public UsuariosGestion()
        {
            InitializeComponent();
        }
        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.VerUsuarios();
                dgvUsuarios.DataSource = datos;
                dgvUsuarios.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UsuariosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
            //Codigo para mostrar cuantas filas se 
            lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            General.GUI.UsuarioEdicion f = new General.GUI.UsuarioEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                General.CLS.Usuarios usuario = new General.CLS.Usuarios();
                usuario.IdUsuario = Int32.Parse(dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString());
                if (usuario.Eliminar())
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
                UsuarioEdicion usuarioEdicion = new UsuarioEdicion();
                usuarioEdicion.txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                usuarioEdicion.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["usuario"].Value.ToString();
                usuarioEdicion.txtClave.Text = dgvUsuarios.CurrentRow.Cells["clave"].Value.ToString();
                usuarioEdicion.txtIdEmpleado.Text = dgvUsuarios.CurrentRow.Cells["idEmpleado"].Value.ToString();
                usuarioEdicion.txtEmpleado.Text = dgvUsuarios.CurrentRow.Cells["nombres_empleado"].Value.ToString();
                usuarioEdicion.txtIdRol.Text = dgvUsuarios.CurrentRow.Cells["idRol"].Value.ToString();
                usuarioEdicion.txtRol.Text = dgvUsuarios.CurrentRow.Cells["rol"].Value.ToString();
                usuarioEdicion.btnBuscarEmpleado.Visible = false;

                usuarioEdicion.ShowDialog();
            }
            CargarDatos();
        }
    }
}
