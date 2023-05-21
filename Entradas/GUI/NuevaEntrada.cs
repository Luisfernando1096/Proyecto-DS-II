using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entradas.GUI
{
    public partial class NuevaEntrada : Form
    {
        SessionManager.Session oUsuario = SessionManager.Session.Instancia;
        DataGridViewRow datosProveedor = new DataGridViewRow();
        DataGridViewRow datosProducto = new DataGridViewRow();
        private int cantidad_productos;
        public NuevaEntrada()
        {
            InitializeComponent();
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy/MM/dd";
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número, un punto decimal o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Evita que se ingrese el carácter no permitido
            }

            // Verificar si ya se ha ingresado un punto decimal y se intenta ingresar otro
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Evita que se ingrese el segundo punto decimal
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número, un punto decimal o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Evita que se ingrese el carácter no permitido
            }

            // Verificar si ya se ha ingresado un punto decimal y se intenta ingresar otro
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Evita que se ingrese el segundo punto decimal
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            txtNombreProveedor.Text = "";
            FormulariosAux.GUI.ListProveedores f = new FormulariosAux.GUI.ListProveedores();
            f.btnSeleccionar.Visible = true;
            f.ShowDialog();
            datosProveedor = f.datosProvEnviar;
            if (datosProveedor != null)
            {
                txtDocumento.Text = datosProveedor.Cells["documento"].Value.ToString();
                txtNombreProveedor.Text = datosProveedor.Cells["nombre"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            FormulariosAux.GUI.ListProductos f = new FormulariosAux.GUI.ListProductos();
            f.btnSeleccionar.Visible = true;
            f.ShowDialog();
            datosProducto = f.datosProEnviar;
            if (datosProducto != null)
            {
                txtCodigoProducto.Text = datosProducto.Cells["codigo"].Value.ToString();
                txtNombreProducto.Text = datosProducto.Cells["nombre"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigoProducto.Focus();
                txtNombreProducto.Focus();
                return;
            }
            if (txtPrecioCompra.Text.Trim() == "")
            {
                MessageBox.Show("Debe colocar el precio de la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioCompra.Focus();
                return;
            }
            if (txtPrecioVenta.Text.Trim() == "")
            {
                MessageBox.Show("Debe colocar el precio de venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioVenta.Focus();
                return;
            }
            if (txtCantidad.Text.Trim() == "")
            {
                MessageBox.Show("Debe colocar la cantidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return;
            }
            // Verificar si la columna existe en el DataGridView
            if (dgvDatos.Columns.Contains("codigo"))
            {
                // Obtener la columna deseada
                DataGridViewColumn columna = dgvDatos.Columns["codigo"];

                // Verificar que la columna sea de tipo DataGridViewTextBoxColumn (o un tipo compatible)
                if (columna is DataGridViewTextBoxColumn)
                {
                    // Recorrer las filas del DataGridView
                    foreach (DataGridViewRow fila in dgvDatos.Rows)
                    {
                        // Obtener el valor de la celda en la columna deseada de la fila actual
                        DataGridViewCell celda = fila.Cells[columna.Index];
                        if (celda.Value.Equals(txtCodigoProducto.Text.Trim()))
                        {
                            MessageBox.Show("No puede agregar de nuevo el mismo producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCodigoProducto.Focus();
                            txtNombreProducto.Focus();
                            return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("La columna 'NombreColumna' no es de tipo DataGridViewTextBoxColumn.");
                }
            }

            dgvDatos.Rows.Add(new object[] {
                datosProducto.Cells["idProducto"].Value.ToString(),
                datosProducto.Cells["existencia"].Value.ToString(),
                datosProducto.Cells["codigo"].Value.ToString(),
                datosProducto.Cells["nombre"].Value.ToString(),
                datosProducto.Cells["descripcion"].Value.ToString(),
                txtPrecioCompra.Text.ToString(),
                txtPrecioVenta.Text.ToString(),
                txtCantidad.Text,
                Double.Parse(txtCantidad.Text) * Double.Parse(txtPrecioCompra.Text.ToString()),
                datosProducto.Cells["idExistencia"].Value.ToString(),
                datosProducto.Cells["idCategoria"].Value.ToString(),
            });
            //Calculando el total
            CalcularTotal();

            txtCodigoProducto.Text = "";
            txtCantidad.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            lblTexto.Visible = true;
            btnEliminar.Visible = true;
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if (dgvDatos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["sub_total"].Value.ToString());
                }
            }
            lblTotal.Text = total.ToString("0.00");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDocumentoEntrada.Text.Trim() == "")
            {
                MessageBox.Show("Debe colocar el numero de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtDocumentoEntrada.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDatos.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregar al menos una entrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable tDoc = DataManager.DBConsultas.ObtenerListaDocumentos();
            bool docIgual = false;
            foreach (DataRow item in tDoc.Rows)
            {
                if (txtDocumentoEntrada.Text.Equals(item["documento_entrada"].ToString()))
                {
                    docIgual = true;
                }
            }
            if (docIgual)
            {
                MessageBox.Show("Debe colocar un numero de documento distinto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDatos.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregar al menos una entrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CLS.Entradas entrada = new CLS.Entradas();

            entrada.Documento_entrada = txtDocumentoEntrada.Text;
            entrada.Fecha_entrada = dtpFecha.Text;
            //Calculos para la cantidad
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                cantidad_productos += Convert.ToInt32(row.Cells["cantidad"].Value.ToString());
            }

            entrada.Cantidad = cantidad_productos;
            entrada.IdProveedor = Int32.Parse(datosProveedor.Cells["idProveedor"].Value.ToString());
            entrada.IdUsuario = Int32.Parse(oUsuario.IdUsuario.ToString());
            entrada.Total = Double.Parse(lblTotal.Text);
            if (entrada.Insertar())
            {
                GenerarCompra(txtDocumento.Text);
            }
            else
            {
                MessageBox.Show("Fallo");
                return;
            }
            lblTexto.Visible = false;
            btnEliminar.Visible = false;
        }

        private void GenerarCompra(string text)
        {
            int idEntrada = 0;
            DataTable tEntrada = DataManager.DBConsultas.ObtenerUltimaEntrada();
            List<CLS.DetalleEntradas> oLista = new List<CLS.DetalleEntradas>();
            List<CLS.Existencias> lstExistencias = new List<CLS.Existencias>();
            List<General.CLS.Productos> lstProductos = new List<General.CLS.Productos>();
            idEntrada = Int32.Parse(tEntrada.Rows[0][0].ToString());

            CLS.Existencias existencia = new CLS.Existencias();

            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                oLista.Add(new CLS.DetalleEntradas()
                {
                    IdProducto = Int32.Parse(row.Cells["idProducto"].Value.ToString()),
                    IdEntrada = idEntrada,
                    Cantidad = Int32.Parse(row.Cells["cantidad"].Value.ToString()),
                    Precio_compra = Double.Parse(row.Cells["precio_compra"].Value.ToString()),
                    Sub_total = Double.Parse(row.Cells["sub_total"].Value.ToString())
                });
                lstExistencias.Add(new CLS.Existencias()
                {
                    IdExistencia = Int32.Parse(row.Cells["idExistencia"].Value.ToString()),
                    IdProducto = Int32.Parse(row.Cells["idProducto"].Value.ToString()),
                    Existencia = Int32.Parse(row.Cells["existencia"].Value.ToString()) + Convert.ToInt32(row.Cells["cantidad"].Value.ToString())
                });
                lstProductos.Add(new General.CLS.Productos()
                {
                    IdProducto = Int32.Parse(row.Cells["idProducto"].Value.ToString()),
                    Nombre = row.Cells["nombre_producto"].Value.ToString(),
                    Codigo = row.Cells["codigo"].Value.ToString(),
                    Descripcion = row.Cells["descripcion"].Value.ToString(),
                    Precio_venta = Double.Parse(row.Cells["precio_venta"].Value.ToString()),
                    Idcategoria = Int32.Parse(row.Cells["idCategoria"].Value.ToString()),
                });

            }
            //Actualizamos las existencias
            bool controlE = false;
            foreach (var existencias in lstExistencias)
            {
                if (!existencias.Actualizar())
                {
                    controlE = true;
                }
            }
            if (controlE)
            {
                MessageBox.Show("Fallo en actualizar existencia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Insertamos las detalle_entradas
            bool controlV = false;
            foreach (var detalle_entradas in oLista)
            {
                if (!detalle_entradas.Insertar())
                {
                    controlV = true;
                }
            }
            if (controlV)
            {
                MessageBox.Show("Fallo al insertar venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Actualizamos las existencias
            bool controlP = false;
            foreach (var productos in lstProductos)
            {
                if (!productos.Actualizar())
                {
                    controlE = true;
                }
            }
            if (controlP)
            {
                MessageBox.Show("Fallo en actualizar productos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dgvDatos.Rows.Clear();
            txtNombreProveedor.Text = "";
            txtDocumento.Text = "";
            txtDocumentoEntrada.Text = "";
            txtCodigoProducto.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtCantidad.Text = "";
            txtNombreProducto.Text = "";
            lblTotal.Text = "0.00";
            txtDocumento.Text = "";
            MessageBox.Show("Se registro exitosamente...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvDatos.Rows.RemoveAt(dgvDatos.CurrentRow.Index);
                MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CalcularTotal();
                if (dgvDatos.Rows.Count < 1)
                {
                    btnEliminar.Visible = false;
                }
            }
        }
    }
}
