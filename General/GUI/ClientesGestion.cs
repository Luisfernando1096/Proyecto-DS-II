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
    public partial class ClientesGestion : Form
    {
        BindingSource datos = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Clientes();
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
        public ClientesGestion()
        {
            InitializeComponent();
        }

        private void ClientesGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClientesEdicion f = new ClientesEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Clientes c = new CLS.Clientes();
                c.IdCliente = Int32.Parse(dgvDatos.CurrentRow.Cells["idCliente"].Value.ToString());
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea editar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClientesEdicion f = new ClientesEdicion();
                f.txtIdCliente.Text = dgvDatos.CurrentRow.Cells["idCliente"].Value.ToString();
                f.txtIdDireccion.Text = dgvDatos.CurrentRow.Cells["idDireccion"].Value.ToString();
                f.txtDireccion.Text = dgvDatos.CurrentRow.Cells["direccion"].Value.ToString();
                f.txtNombres.Text = dgvDatos.CurrentRow.Cells["nombres_cliente"].Value.ToString();
                f.txtApellidos.Text = dgvDatos.CurrentRow.Cells["apellidos_cliente"].Value.ToString();
                f.cmbGenero.SelectedItem = dgvDatos.CurrentRow.Cells["genero"].Value.ToString();
                f.dtpNacimiento.Text = dgvDatos.CurrentRow.Cells["nacimiento"].Value.ToString();
                f.txtDui.Text = dgvDatos.CurrentRow.Cells["dui"].Value.ToString();
                f.txtNit.Text = dgvDatos.CurrentRow.Cells["nit"].Value.ToString();
                f.ShowDialog();
            }
            CargarDatos();
        }
    }
}
