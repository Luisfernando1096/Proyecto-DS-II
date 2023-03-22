using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SCDI.GUI
{
    public partial class Main : Form
    {
        SessionManager.Session oUsuario = SessionManager.Session.Instancia;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = oUsuario.Usuario.ToUpper();
            lblRol.Text = oUsuario.Rol.ToUpper();
        }

        private void gestionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioEmpleados();
        }
        //Codigo para mostrar dentro del mdi otro formulario
        private void MostrarFormularioEmpleados()
        {
            if (FormularioAbierto(new Empleados().GetType()))
            {

            }
            else
            {
                Empleados emp = new Empleados();
                emp.MdiParent = this;
                emp.Show();
            }
            
        }
        private bool FormularioAbierto(Type formType)
        {
            foreach (Empleados form in this.MdiChildren)
            {
                if (form.GetType() == formType)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
