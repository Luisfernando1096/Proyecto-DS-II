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
            try
            {
                General.GUI.EmpleadosGestion f = new General.GUI.EmpleadosGestion();
                f.MdiParent = this;//No permite que salgan los formularios del form MDI
                f.Show();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gestionDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.RolesGestion f = new General.GUI.RolesGestion();
                f.MdiParent = this;//No permite que salgan los formularios del form MDI
                f.Show();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.ClientesGestion f = new General.GUI.ClientesGestion();
                f.MdiParent = this;//No permite que salgan los formularios del form MDI
                f.Show();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
