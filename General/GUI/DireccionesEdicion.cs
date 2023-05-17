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
    public partial class DireccionesEdicion : Form
    {
        public int idReferenciaMun;
        public DireccionesEdicion()
        {
            InitializeComponent();
        }
        private void CargarMunicipios()
        {
            DataTable municipios = new DataTable();
            try
            {
                municipios = DataManager.DBConsultas.Municipios();
                cmbMunicipio.DataSource = municipios;
                cmbMunicipio.DisplayMember = "municipio";
                cmbMunicipio.ValueMember = "idMunicipio";
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

        private void DireccionesEdicion_Load(object sender, EventArgs e)
        {
            CargarMunicipios();
            if (idReferenciaMun > 0)
            {
                cmbMunicipio.SelectedIndex = idReferenciaMun - 1;
            }
        }

        private void txtNoCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNoCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear el objeto entidad
            CLS.Direcciones r = new CLS.Direcciones();
            //Sincronizar la entidad con la interfaz
            r.NoCasa = txtNoCasa.Text;
            r.NoCalle = txtNoCalle.Text;
            r.IdMunicipio = Int32.Parse(cmbMunicipio.SelectedValue.ToString());
            //Realizar la operacion necesaria

            if (txtIdDireccion.TextLength > 0)
            {
                r.IdDireccion = Int32.Parse(txtIdDireccion.Text);
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
    }
}
