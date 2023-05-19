using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salidas.GUI
{
    public partial class SalidaNueva : Form
    {
        SessionManager.Session oUsuario = SessionManager.Session.Instancia;
        DataGridViewRow datosCliente = new DataGridViewRow();
        DataGridViewRow datosProducto = new DataGridViewRow();
        private int cantidad_productos;

        public SalidaNueva()
        {
            InitializeComponent();
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy/MM/dd";
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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
            General.GUI.ClientesGestion f = new General.GUI.ClientesGestion();
            f.btnSeleccionar.Visible = true;
            f.ShowDialog();
            datosCliente = f.datosCliEnviar;
            if (datosCliente != null)
            {
                txtDui.Text = datosCliente.Cells["dui"].Value.ToString();
                txtNombre.Text = datosCliente.Cells["nombres_cliente"].Value.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            General.GUI.ProductosGestion f = new General.GUI.ProductosGestion();
            f.btnSeleccionar.Visible = true;
            f.ShowDialog();
            datosProducto = f.datosProEnviar;
            if (datosCliente != null)
            {
                txtCodigo.Text = datosProducto.Cells["codigo"].Value.ToString();
                txtNombreProducto.Text = datosProducto.Cells["nombre"].Value.ToString();
                txtExistencia.Text = datosProducto.Cells["existencia"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtExistencia.Text.Trim() == "0")
            {
                MessageBox.Show("No hay existencia de este producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDui.Focus();
                txtNombre.Focus();
                return;
            }
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigo.Focus();
                txtNombreProducto.Focus();
                return;
            }
            if (txtCantidad.Text.Trim() == "")
            {
                MessageBox.Show("Debe colocar la cantidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return;
            }
            if (Int32.Parse(txtCantidad.Text.Trim()) > Int32.Parse(txtExistencia.Text.Trim()))
            {
                MessageBox.Show("La cantidad debe ser menor o igual a la existencia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return;
            }
            // Supongamos que tienes un DataGridView llamado "dataGridView" y quieres recorrer una columna específica

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
                        if (celda.Value.Equals(txtCodigo.Text.Trim()))
                        {
                            MessageBox.Show("No puede agregar de nuevo el mismo producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCodigo.Focus();
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
                datosProducto.Cells["precio_venta"].Value.ToString(),
                Double.Parse(txtCantidad.Text) * Double.Parse(datosProducto.Cells["precio_venta"].Value.ToString()),
                txtCantidad.Text,
                datosProducto.Cells["idExistencia"].Value.ToString()
            });
            //Calculando el total
            CalcularTotal();
            
            txtCodigo.Text = "";
            txtExistencia.Text = "";
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
            if (txtDui.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDui.Focus();
                txtNombre.Focus();
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
                aux = Int32.Parse(tSalidas.Rows[0][0].ToString()) + 1;
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
            salida.IdCliente = Int32.Parse(datosCliente.Cells["idCliente"].Value.ToString());
            salida.UsuarioAtendio = Int32.Parse(oUsuario.IdUsuario.ToString());
            salida.Total = Double.Parse(lblTotal.Text);
            if (salida.Insertar()) {
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

        private void GenerarVenta(string doc)
        {
            int idSalida = 0;
            DataTable tSalida = DataManager.DBConsultas.ObtenerUltimaSalida();
            List<CLS.Ventas> oLista = new List<CLS.Ventas>();
            List<CLS.Existencias> lstExistencias = new List<CLS.Existencias>();
            idSalida = Int32.Parse(tSalida.Rows[0][1].ToString());

            CLS.Existencias existencia = new CLS.Existencias();

            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                oLista.Add(new CLS.Ventas()
                {
                    IdSalida = idSalida,
                    IdProducto = Int32.Parse(row.Cells["idProducto"].Value.ToString()),
                    Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value.ToString()),
                    SubTotal = Double.Parse(row.Cells["sub_total"].Value.ToString())
                });
                lstExistencias.Add(new CLS.Existencias(){
                    IdExistencia = Int32.Parse(row.Cells["idExistencia"].Value.ToString()),
                    IdProducto = Int32.Parse(row.Cells["idProducto"].Value.ToString()),
                    Existencia = Int32.Parse(row.Cells["existencia"].Value.ToString()) - Convert.ToInt32(row.Cells["cantidad"].Value.ToString())
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
            //Insertamos las ventas
            bool controlV = false;
            foreach (var ventas in oLista)
            {
                if (!ventas.Insertar())
                {
                    controlV = true;
                }
            }
            if (controlV)
            {
                MessageBox.Show("Fallo in insertar venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dgvDatos.Rows.Clear();
            txtNombre.Text = "";
            txtDui.Text = "";
            txtNoDocumento.Text = "";
            txtCodigo.Text = "";
            txtExistencia.Text = "";
            txtCantidad.Text = "";
            txtNombreProducto.Text = "";
            lblTotal.Text = "0";
            MessageBox.Show("Se registro exitosamente...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Se genero numero de documento: " + doc, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void SalidaNueva_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvDatos.Rows.RemoveAt(dgvDatos.CurrentRow.Index);
                MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CalcularTotal();
                if (dgvDatos.Rows.Count<1)
                {
                    btnEliminar.Visible = false;
                }
            }
        }
    }
}
