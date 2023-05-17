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
    public partial class ProveedoresGestion : Form
    {
        BindingSource datos = new BindingSource();
        public ProveedoresGestion()
        {
            InitializeComponent();
        }
        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Proveedores();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado
                                                     //Codigo para insertar los datos en el datagrid
                                                     //Codigo para mostrar cuantas filas se 
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Proveedores c = new CLS.Proveedores();
                c.IdProveedor = Int32.Parse(dgvDatos.CurrentRow.Cells["idProveedor"].Value.ToString());
                if (c.Eliminar())
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProveedoresEdicion f = new ProveedoresEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea editar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProveedoresEdicion f = new ProveedoresEdicion();
                f.txtIdProveedor.Text = dgvDatos.CurrentRow.Cells["idProveedor"].Value.ToString();
                f.txtIdDireccion.Text = dgvDatos.CurrentRow.Cells["idDireccion"].Value.ToString();
                f.txtDocumento.Text = dgvDatos.CurrentRow.Cells["documento"].Value.ToString();
                f.txtDireccion.Text = dgvDatos.CurrentRow.Cells["direccion"].Value.ToString();
                f.txtnombre.Text = dgvDatos.CurrentRow.Cells["nombre"].Value.ToString();
                f.txtTelefono.Text = dgvDatos.CurrentRow.Cells["telefono"].Value.ToString();
                f.ShowDialog();
            }
            CargarDatos();
        }

        private void ProveedoresGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
