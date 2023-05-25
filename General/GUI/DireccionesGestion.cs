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
    public partial class DireccionesGestion : Form
    {
        BindingSource datos = new BindingSource();
        public string direccionEnviar { get; set; }
        public string idEnviar { get; set; }
        public DireccionesGestion()
        {
            InitializeComponent();
        }
        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Direcciones();
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

        private void DireccionesGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Direcciones r = new CLS.Direcciones();
                r.IdDireccion = Int32.Parse(dgvDatos.CurrentRow.Cells["idDireccion"].Value.ToString());
                if (r.Eliminar())
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
                DireccionesEdicion f = new DireccionesEdicion();
                f.txtIdDireccion.Text = dgvDatos.CurrentRow.Cells["idDireccion"].Value.ToString();
                f.txtNoCasa.Text = dgvDatos.CurrentRow.Cells["no_casa"].Value.ToString();
                f.txtNoCalle.Text = dgvDatos.CurrentRow.Cells["no_calle"].Value.ToString();
                f.idReferenciaMun = Int32.Parse(dgvDatos.CurrentRow.Cells["idMunicipio"].Value.ToString());
                f.ShowDialog();
            }
            CargarDatos();
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            DireccionesEdicion f = new DireccionesEdicion();
            f.ShowDialog();
            CargarDatos();
        }
    }
}
