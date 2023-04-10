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

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.UsuariosGestion f = new General.GUI.UsuariosGestion();
            f.MdiParent = this;//No permite que salgan los formularios del form MDI
            f.Show();
        }

        private void gestioDeDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.DepartamentosGestion f = new General.GUI.DepartamentosGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.CategoriasGestion f = new General.GUI.CategoriasGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.EntradasGestion f = new General.GUI.EntradasGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDeExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.ExistenciasGestion f = new General.GUI.ExistenciasGestion();
                f.MdiParent = this;//No permite que salgan los formularios del form MDI
                f.Show();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gestionDeClasificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                General.GUI.ClasificacionesGestion f = new General.GUI.ClasificacionesGestion();
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

        private void gestionDeDireccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.DireccionesGestion f = new General.GUI.DireccionesGestion();
                f.MdiParent = this;//No permite que salgan los formularios del form MDI
                f.Show();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gestionDeSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.SalidasGestion f = new General.GUI.SalidasGestion();
                f.MdiParent = this;//No permite que salgan los formularios del form MDI
                f.Show();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gestionDeSalidasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.SalidasProductosGestion f = new General.GUI.SalidasProductosGestion();
                f.MdiParent = this;//No permite que salgan los formularios del form MDI
                f.Show();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gestionDeEntradasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.EntradasProductosGestion f = new General.GUI.EntradasProductosGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.PermisosGestion f = new General.GUI.PermisosGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDeOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.OpcionesGestion f = new General.GUI.OpcionesGestion();
            f.MdiParent = this;
            f.Show();
        }
    }
}
