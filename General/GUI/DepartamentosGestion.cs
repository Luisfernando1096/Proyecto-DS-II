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
    public partial class DepartamentosGestion : Form
    {
        BindingSource datos = new BindingSource();
        private void CargarDatos() 
        {
            
            try
            {
                datos.DataSource = DataManager.DBConsultas.VerDepartamentos();
                dgvDepartamentos.DataSource = datos;
                dgvDepartamentos.AutoGenerateColumns = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DepartamentosGestion()
        {
            InitializeComponent();
        }

        private void DepartamentosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
            //Codigo para mostrar cuantas filas se 
            lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DepartamentosEdicion departamento = new DepartamentosEdicion();
            departamento.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea editar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DepartamentosEdicion departamento = new DepartamentosEdicion();
                departamento.txtIdDepartamento.Text = dgvDepartamentos.CurrentRow.Cells["idDepartamento"].Value.ToString();
                departamento.txtDepartamento.Text = dgvDepartamentos.CurrentRow.Cells["nombre"].Value.ToString();
                departamento.ShowDialog();
            }
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                General.CLS.Departamentos departamento= new General.CLS.Departamentos();
                departamento.IdDepartamento = Int32.Parse(dgvDepartamentos.CurrentRow.Cells["idDepartamento"].Value.ToString());
                if (departamento.Eliminar())
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
