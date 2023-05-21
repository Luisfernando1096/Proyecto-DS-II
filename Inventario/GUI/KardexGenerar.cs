using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.GUI
{
    public partial class KardexGenerar : Form
    {
        BindingSource datos = new BindingSource();
        public KardexGenerar()
        {
            InitializeComponent();
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "yyyy/MM/dd";
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.CustomFormat = "yyyy/MM/dd";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Inventario(dtpInicio.Text, dtpFin.Text);
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
