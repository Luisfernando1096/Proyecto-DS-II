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
    public partial class ClasificacionesGestion : Form
    {
        BindingSource datos = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.Clasificaciones();
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;//Impide generar automaticamente las columnas de encabezado
                                                     //Codigo para insertar los datos en el datagrid
                lblRegistros.Text = datos.List.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

                throw;
            }
        }



        public ClasificacionesGestion()
        {
            InitializeComponent();
        }

        private void ClasificacionesGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
          
           
        }

       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClasificacionesEdicion f = new ClasificacionesEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea editar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClasificacionesEdicion f = new ClasificacionesEdicion();
                f.txtIdClasificacion.Text = dgvDatos.CurrentRow.Cells["idClasificacion"].Value.ToString();
                f.txtClasificacion.Text = dgvDatos.CurrentRow.Cells["clasificacion"].Value.ToString();
                f.ShowDialog();
            }
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Clasificaciones r = new CLS.Clasificaciones();
                r.IdClasificacion = Int32.Parse(dgvDatos.CurrentRow.Cells["idClasificacion"].Value.ToString());
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
