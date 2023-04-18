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
    public partial class RolesGestion : Form
    {

        BindingSource datos = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Roles();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado
                                                     //Codigo para mostrar cuantas filas se 
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";

            }
            catch (Exception)
            {

                throw;
            }
        }

        public RolesGestion()
        {
            InitializeComponent();
        }

        private void RolesGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RolesEdicion f = new RolesEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea editar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                RolesEdicion f = new RolesEdicion();
                f.txtIdRol.Text = dgvDatos.CurrentRow.Cells["idRol"].Value.ToString();
                f.txtRol.Text = dgvDatos.CurrentRow.Cells["rol"].Value.ToString();
                f.ShowDialog();
            }
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Roles r = new CLS.Roles();
                r.IdRol = Int32.Parse(dgvDatos.CurrentRow.Cells["idRol"].Value.ToString());
                if (r.Eliminar())
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
    }
}
