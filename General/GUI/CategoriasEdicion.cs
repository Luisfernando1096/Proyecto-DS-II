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
    public partial class CategoriasEdicion : Form
    {
        public CategoriasEdicion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                General.CLS.Categorias categoria = new General.CLS.Categorias();
                categoria.Categoria = txtCategoria.Text;
                if (txtCategoria.Text != "")
                {
                    if (txtIdCategoria.TextLength > 0)
                    {
                        categoria.IdCategoria = Int32.Parse(txtIdCategoria.Text);
                        if (categoria.Actualizar())
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
                        if (categoria.Insertar())
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
                else
                {
                    MessageBox.Show("El campo de categoria no puede estar vacío. Por favor, ingrese un valor.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
