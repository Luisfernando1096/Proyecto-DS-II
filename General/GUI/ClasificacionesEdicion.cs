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
    public partial class ClasificacionesEdicion : Form
    {
        public ClasificacionesEdicion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear el objeto entidad
            CLS.Clasificaciones r = new CLS.Clasificaciones();
            //Sincronizar la entidad con la interfaz
            r.Clasificacion = txtClasificacion.Text;
            //Realizar la operacion necesaria

            if (txtIdClasificacion.TextLength > 0)
            {
                r.IdClasificacion  = Int32.Parse(txtIdClasificacion.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClasificacionesEdicion_Load(object sender, EventArgs e)
        {

        }
    }
}
