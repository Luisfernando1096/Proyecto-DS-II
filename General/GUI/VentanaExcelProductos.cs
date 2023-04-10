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
    public partial class VentanaExcelProductos : Form
    {
        BindingSource datos = new BindingSource();

        public VentanaExcelProductos()
        {
            InitializeComponent();
        }

        private void VentanaExcelProductos_Load(object sender, EventArgs e)
        {
            grid.AutoGenerateColumns = false;
            int registros = grid.RowCount;
            Registros.Text = registros + " registros de Excel";
        }


        public void llenarDatos(DataTable dt) 
        {
            grid.DataSource = dt;
        }

        private void bntInsertarDeExcel_Click(object sender, EventArgs e)
        {
            ProductosGestion productosVentana = new ProductosGestion();
            try
            {
                int successCount = 0;
                int errorCount = 0;

                foreach (DataGridViewRow row in grid.Rows)
                {
                    // Obtener los valores de las celdas utilizando la propiedad DataPropertyName
                    string nombre = row.Cells["nombre"].Value?.ToString() ?? "";
                    string descripcion = row.Cells["descripcion"].Value?.ToString() ?? "";
                    double precio_compra = Convert.ToDouble(row.Cells["precio_compra"].Value);
                    double precio_venta = Convert.ToDouble(row.Cells["precio_venta"].Value);
                    int idCategoria = Convert.ToInt32(row.Cells["idCategoria"].Value);

                    var resultado = DataManager.DBConsultas.InsertarDatosExcel(nombre, descripcion, precio_compra, precio_venta, idCategoria);

                    if (resultado.existe == true && resultado.insertar == false)
                    {
                        MessageBox.Show("EL VALOR DE : " + nombre + " YA EXISTE EN LOS REGISTROS");
                    }
                    else if (resultado.existe == false && resultado.insertar == true )
                    {
                        successCount++;
                    }
                    else
                    {
                        errorCount++;
                    }
                }
                if (errorCount == 0)
                {
                    MessageBox.Show($"Se insertaron correctamente {successCount} fila(s).");
                }
                else
                {
                    MessageBox.Show($"{errorCount} fila(s) no se pudieron insertar correctamente. Se insertaron correctamente {successCount} fila(s).");
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }


        private void VentanaExcelProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel)
            {
                e.Cancel = false;
            }
        }
    }
}
