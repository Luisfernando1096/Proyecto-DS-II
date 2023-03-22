using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCDI.GUI
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            dtpNacimiento.Format = DateTimePickerFormat.Custom;
            dtpNacimiento.CustomFormat = "yyyy/MM/dd";
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            DataTable allEmpleados = DataManager.DBConsultas.VerEmpleados();
            dgvEmpleados.DataSource = allEmpleados;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataTable allEmpleados = DataManager.DBConsultas.VerEmpleadosPorNombre(txtBusquedaEmpleado.Text);
            dgvEmpleados.DataSource = allEmpleados;
        }

        private void dgvEmpleados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<String> valores = new List<string>();

            for (int i = 0; i < dgvEmpleados.Columns.Count; i++)
            {
                valores.Add(dgvEmpleados.Rows[e.RowIndex].Cells[i].Value.ToString()); 
            }
            txtIdEmpleado.Text = valores[0];
            txtNombres.Text = valores[1];
            txtApellidos.Text = valores[2];
            DateTime fecha = DateTime.Parse(valores[3]);
            dtpNacimiento.Value = fecha;
            if (valores[4].Equals("Masculino"))
            {
                cmbGenero.SelectedIndex = 0;
            }
            else
            {
                cmbGenero.SelectedIndex = 1;
            }

        }

    }
}
