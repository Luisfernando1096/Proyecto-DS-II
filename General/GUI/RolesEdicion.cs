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
    public partial class RolesEdicion : Form
    {
        public int idRol;
        public String rol = "";
        public RolesEdicion()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLS.Roles r = new CLS.Roles();
            r.Rol = txtRol.Text.ToString();

            if (txtIdRol.Text.ToString().Equals("0"))
            {
                if (r.Insertar())
                {
                    MessageBox.Show("Registro insertado");
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar");
                }
            }
            else
            {
                r.IdRol = Int32.Parse(txtIdRol.Text.ToString());
                if (r.Actualizar())
                {
                    MessageBox.Show("Registro actualizado");
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar");
                }
            }
        }

        private void RolesEdicion_Load(object sender, EventArgs e)
        {
            txtIdRol.Text = idRol.ToString();
            txtRol.Text = rol.ToString();
        }
    }
}
