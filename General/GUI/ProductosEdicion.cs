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
    public partial class ProductosEdicion : Form
    {
        public ProductosEdicion()
        {
            InitializeComponent();
        }

        private void CargarCategorias()
        {
            try
            {
                // Obtener los datos de categoría
                DataTable categoria = DataManager.DBConsultas.Categorias();

                // Crear un nuevo DataTable con la estructura de categoría
                DataTable dt = categoria.Clone();

                // Agregar la fila de "Seleccione" al nuevo DataTable
                dt.Rows.Add(0, "Seleccione una categoria");

                // Fusionar los datos de categoría con el nuevo DataTable
                dt.Merge(categoria);

                // Asignar el origen de datos al ComboBox
                cmbCategorias.DataSource = dt;
                cmbCategorias.DisplayMember = "categoria";
                cmbCategorias.ValueMember = "idCategoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ProductosEdicion_Load(object sender, EventArgs e)
        {
            cmbCategorias.SelectedValue = 0;
            CargarCategorias();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtPrecio_venta.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Aviso de selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!double.TryParse(txtPrecio_venta.Text, out _))
                {
                    MessageBox.Show("Error: Por favor, ingrese un número válido en el campo de precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(cmbCategorias.SelectedValue) == 0)
                {
                    MessageBox.Show("Debe seleccionar una categoría.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.CLS.Productos productos = new General.CLS.Productos();
                    productos.Nombre = txtNombre.Text;
                    productos.Codigo = txtCodigo.Text;
                    if (CompararCodigo(txtCodigo.Text))
                    {
                        MessageBox.Show("El codigo ya está agregado a un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    productos.Descripcion = txtDescripcion.Text;
                    productos.Precio_venta = double.Parse(txtPrecio_venta.Text);
                    productos.Idcategoria = Convert.ToInt32(cmbCategorias.SelectedValue);

                    CLS.Existencias existencia = new CLS.Existencias();
                    DataTable tProductos = new DataTable();
                    tProductos = DataManager.DBConsultas.ObtenerUltimoProducto();

                    if (txtIdProducto.TextLength > 0)
                    {
                        productos.IdProducto = Int32.Parse(txtIdProducto.Text);
                        if (productos.Actualizar())
                        {
                            MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("¡El registro no se actualizó correctamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (productos.Insertar())
                        {
                            existencia.Existencia = 0;
                            existencia.IdProducto = Int32.Parse(tProductos.Rows[0][0].ToString());
                            existencia.Insertar();
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

        private bool CompararCodigo(string codigo)
        {
            bool result = false;
            DataTable p = DataManager.DBConsultas.Productos();
            foreach (DataRow row in p.Rows)
            {   // Comparar ambos datos
                if (codigo.Equals(row[2].ToString()))
                {
                    result = true;
                }
            }
            return result;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
