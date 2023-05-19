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
    public partial class BuscarSalida : Form
    {
        BindingSource datos = new BindingSource();
        public BuscarSalida()
        {
            InitializeComponent();
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy/MM/dd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.VerRegistroSalidas(txtDocumento.Text);
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado
                                                     //Codigo para mostrar cuantas filas se
                if (dgvDatos.RowCount>0)
                {
                    txtDui.Text = dgvDatos.Rows[0].Cells[7].Value.ToString();
                    txtNombre.Text = dgvDatos.Rows[0].Cells[8].Value.ToString();
                    dtpFecha.Text = dgvDatos.Rows[0].Cells[9].Value.ToString();
                    txtUsuario.Text = dgvDatos.Rows[0].Cells[11].Value.ToString();
                    lblTotal.Text = dgvDatos.Rows[0].Cells[10].Value.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
