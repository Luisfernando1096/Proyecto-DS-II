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
    public partial class ProductosGestion : Form
    {
        BindingSource datos = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Productos();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado
                //Codigo para insertar los datos en el datagrid

            }
            catch (Exception)
            {

                throw;
            }
        }

        public ProductosGestion()
        {
            InitializeComponent();
            ///Ajustar Tamaño
            int totalWidth = 0;
            int totalHeight = 0;

            foreach (DataGridViewColumn column in dgvDatos.Columns)
            {
                totalWidth += column.Width;
            }

            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                totalHeight += row.Height;
            }

            // Ajustar el tamaño del formulario
            this.ClientSize = new System.Drawing.Size(totalWidth + 100, totalHeight + 500);
        }

        private void ProductosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
            //Codigo para mostrar cuantas filas se 
            lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
            dgvDatos.Height = 70000;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProductosEdicion producto = new ProductosEdicion();
            producto.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea editar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProductosEdicion producto = new ProductosEdicion();
                producto.txtIdProducto .Text = dgvDatos.CurrentRow.Cells["idProducto"].Value.ToString();
                producto.txtCodigo.Text = dgvDatos.CurrentRow.Cells["codigo"].Value.ToString();
                producto.txtNombre.Text = dgvDatos.CurrentRow.Cells["nombre"].Value.ToString();
                producto.txtDescripcion.Text = dgvDatos.CurrentRow.Cells["descripcion"].Value.ToString();
                producto.txtPrecio_venta.Text = dgvDatos.CurrentRow.Cells["precio_venta"].Value.ToString();
                producto.ShowDialog();
            }
            CargarDatos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                General.CLS.Productos productos = new General.CLS.Productos();
                productos.IdProducto = Int32.Parse(dgvDatos.CurrentRow.Cells["idProducto"].Value.ToString());
                if (productos.Eliminar())
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
