using ExcelDataReader;
using Magnum.FileSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
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
                dgvDatos.Refresh();
                //Codigo para insertar los datos en el datagrid

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Refrescar() 
        {
            CargarDatos();
        }

        public ProductosGestion()
        {
            InitializeComponent();
        }
 
        private void ProductosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
            //Codigo para mostrar cuantas filas se 
            lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
        }

        private void bntExcel_Click(object sender, EventArgs e)
        {
            General.GUI.VentanaExcelProductos ventana = new General.GUI.VentanaExcelProductos();

            try
            {
                // Abre el diálogo de archivo para seleccionar el archivo de Excel
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivo de Excel|*.xls;*.xlsx;*.csv";
                openFileDialog.Title = "Seleccionar archivo de Excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtiene el nombre del archivo seleccionado
                    string filePath = openFileDialog.FileName;

                    // Abre el archivo de Excel y carga los datos en un DataTable
                    using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            // Carga los datos del archivo de Excel en un DataSet
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration
                            {
                                ConfigureDataTable = _ => new ExcelDataTableConfiguration
                                {
                                    UseHeaderRow = true // Indica si la primera fila contiene los nombres de columna
                                }
                            });

                            // Obtiene el primer DataTable del DataSet
                            DataTable dt = result.Tables[0];

                            // Asigna el DataTable al DataGridView para mostrar los datos
                            ventana.llenarDatos(dt);
                            ventana.Show();
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show ("Ha ocurrido un problema");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
