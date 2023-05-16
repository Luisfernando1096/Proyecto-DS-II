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
    public partial class MunicipiosEdicion : Form
    {
        public int idReferencia;
        public MunicipiosEdicion()
        {
            idReferencia = 0;
            InitializeComponent();
        }
        private void CargarDepartamentos()
        {
            DataTable roles = new DataTable();
            try
            {
                roles = DataManager.DBConsultas.Departamentos();
                cmbDepartamento.DataSource = roles;
                cmbDepartamento.DisplayMember = "nombre";
                cmbDepartamento.ValueMember = "idDepartamento";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear el objeto entidad
            CLS.Municipios r = new CLS.Municipios();
            //Sincronizar la entidad con la interfaz
            r.Municipio = txtMunicipio.Text;
            r.IdDepartamento = Int32.Parse(cmbDepartamento.SelectedValue.ToString());
            //Realizar la operacion necesaria

            if (txtIdMunicipio.TextLength > 0)
            {
                r.IdMunicipio = Int32.Parse(txtIdMunicipio.Text);
                if (r.Actualizar())
                {
                    MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no se actualizo correctamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (r.Insertar())
                {
                    MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue insertado correctamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void MunicipiosEdicion_Load(object sender, EventArgs e)
        {
            
            CargarDepartamentos();
            if (idReferencia > 0)
            {
                cmbDepartamento.SelectedIndex = idReferencia - 1;
            }
        }
    }
}
