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
            General.GUI.ProveedoresGestion f = new General.GUI.ProveedoresGestion();
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
            General.GUI.ProductosGestion f = new General.GUI.ProductosGestion();
            f.btnSeleccionar.Visible = true;
            f.ShowDialog();
            datosProducto = f.datosProEnviar;
            if (datosProducto != null)
            {
                txtCodigoProducto.Text = datosProducto.Cells["codigo"].Value.ToString();
                txtNombreProducto.Text = datosProducto.Cells["nombre"].Value.ToString();
                txtPrecioVenta.Text = datosProducto.Cells["precio_venta"].Value.ToString();
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
                datosProducto.Cells["precio_compra"].Value.ToString(),
                datosProducto.Cells["precio_venta"].Value.ToString(),
                Double.Parse(txtCantidad.Text) * Double.Parse(datosProducto.Cells["precio_compra"].Value.ToString()),
                txtCantidad.Text,
                datosProducto.Cells["idExistencia"].Value.ToString()
            });
            //Calculando el total
            CalcularTotal();

            txtCodigoProducto.Text = "";
            txtCantidad.Text = "";
            txtNombreProducto.Text = "";
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
            if (txtDocumento.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar el proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDatos.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregar al menos una salida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CLS.Salidas salida = new CLS.Salidas();
            DataTable tSalidas = new DataTable();
            tSalidas = DataManager.DBConsultas.ObtenerUltimaSalida();
            int aux = 0;
            string aux2 = "";
            if (tSalidas.Rows.Count > 0)
            {
                aux = Int32.Parse(tSalidas.Rows[0][0].ToString());
            }
            else
            {
                aux = 1;
            }
            if (aux < 10)
            {
                aux2 = "0000" + aux.ToString();
            }
            else if (aux >= 10 && aux < 100)
            {
                aux2 = "000" + aux.ToString();
            }
            else if (aux >= 100 && aux < 1000)
            {
                aux2 = "00" + aux.ToString();
            }
            else if (aux >= 1000 && aux < 10000)
            {
                aux2 = "0" + aux.ToString();
            }
            else if (aux >= 10000 && aux < 100000)
            {
                aux2 = aux.ToString();
            }

            salida.Documento = aux2;
            salida.FechaSalida = dtpFecha.Text;
            //Calculos para la cantidad
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                cantidad_productos += Convert.ToInt32(row.Cells["cantidad"].Value.ToString());
            }

            salida.Cantidad = cantidad_productos;
            salida.IdCliente = Int32.Parse(datosProveedor.Cells["idProveedor"].Value.ToString());
            salida.UsuarioAtendio = Int32.Parse(oUsuario.IdUsuario.ToString());
            salida.Total = Double.Parse(lblTotal.Text);
            if (salida.Insertar())
            {
                GenerarVenta(aux2);
            }
            else
            {
                MessageBox.Show("Fallo");
                return;
            }
            lblTexto.Visible = false;
            btnEliminar.Visible = false;
        }
    }
}
