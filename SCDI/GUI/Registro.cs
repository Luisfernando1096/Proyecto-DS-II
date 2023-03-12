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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void bntRegresar_Click(object sender, EventArgs e)
        {
            Close();
            var regresar = new Login();
            regresar.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String clave = textClave.Text;
            String ConnClave = textConfirmarClave.Text;

            if (clave.Equals(ConnClave))
            {
                MessageBox.Show("Registro exitoso");
                Close();

                var Login = new Login();
                Login.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
