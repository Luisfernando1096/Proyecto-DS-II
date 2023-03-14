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
        Boolean autorizado = false;

        public bool Autorizado { get => autorizado;}//cntl + r + e
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
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
                try
                {
                    DataTable datosUsuario = new DataTable();
                    datosUsuario = DataManager.DBConsultas.IniciarSesion(txtUsuario.Text, txtClave.Text);
                    if (datosUsuario.Rows.Count == 1)
                    {
                        autorizado = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos");
                        autorizado = false;
                        txtClave.Focus();
                        txtClave.SelectAll();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error contactese con el programador!!");
                    autorizado = false;
                    throw;
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
