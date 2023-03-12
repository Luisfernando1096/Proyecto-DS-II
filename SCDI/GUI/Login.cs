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
    public partial class Login : Form
    {
        public static String usuario = "";
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            String clave = txtClave.Text;
            bool validacion = false;
            if (txtClave.Text.Length == 0)
            {
                validacion = true;
            }
            if (txtUsuario.Text.Length == 0)
            {
                validacion = true;
            }

            if (!validacion)
            {
                DataManager.DBOperacion operacion = new DataManager.DBOperacion();
                DataTable u = operacion.Consultar("select usuario from usuarios where usuario = '" 
                    + usuario + "' and clave = '" + clave + "';");
                if (u.Rows.Count != 0)
                {
                    Close();
                    var Main = new Main();
                    Main.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Debe llenar los campos Usuario y Contraseña");
            }
            
        }

        private void bntRegistrarse_Click(object sender, EventArgs e)
        {
            Close();
            var registro = new Registro();
            registro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataManager.DBConexion o = new DataManager.DBConexion();
            if (o.Conectar())
            {
                MessageBox.Show("Conectado");
                o.Desconectar();
            }
        }

    }
}
