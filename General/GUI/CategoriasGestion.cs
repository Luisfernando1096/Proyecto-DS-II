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
    public partial class CategoriasGestion : Form
    {
        BindingSource datos = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.VerCategorias();
                dgvCategorias.DataSource = datos;
                dgvCategorias.AutoGenerateColumns = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public CategoriasGestion()
        {
            InitializeComponent();
        }

        private void CategoriasGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
            //Codigo para mostrar cuantas filas se 
            lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriasEdicion categoria = new CategoriasEdicion();
            categoria.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CategoriasEdicion categoria = new CategoriasEdicion();
            if (MessageBox.Show("¿Esta seguro que desea editar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RolesEdicion f = new RolesEdicion();
                categoria.txtIdCategoria.Text = dgvCategorias.CurrentRow.Cells["idCategoria"].Value.ToString();
                categoria.txtCategoria.Text = dgvCategorias.CurrentRow.Cells["categoria"].Value.ToString();
                categoria.ShowDialog();
            }
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Categorias categoria = new CLS.Categorias();
                categoria.IdCategoria = Int32.Parse(dgvCategorias.CurrentRow.Cells["idCategoria"].Value.ToString());
                if (categoria.Eliminar())
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
