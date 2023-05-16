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
    public partial class MunicipiosGestion : Form
    {
        BindingSource datos = new BindingSource();
        public MunicipiosGestion()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Municipios();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado
                                                     //Codigo para mostrar cuantas filas se 
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MunicipiosEdicion f = new MunicipiosEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void MunicipiosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea editar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MunicipiosEdicion f = new MunicipiosEdicion();
                f.txtIdMunicipio.Text = dgvDatos.CurrentRow.Cells["idMunicipio"].Value.ToString();
                f.txtMunicipio.Text = dgvDatos.CurrentRow.Cells["municipio"].Value.ToString();
                f.idReferencia = Int32.Parse(dgvDatos.CurrentRow.Cells["idDepartamento"].Value.ToString());
                f.ShowDialog();
            }
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Municipios r = new CLS.Municipios();
                r.IdMunicipio = Int32.Parse(dgvDatos.CurrentRow.Cells["idMunicipio"].Value.ToString());
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
    }
}
