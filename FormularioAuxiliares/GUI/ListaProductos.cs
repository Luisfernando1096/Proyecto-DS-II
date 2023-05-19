using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioAuxiliares.GUI
{
    public partial class ListaProductos : Form
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
        public ListaProductos()
        {
            InitializeComponent();
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
