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
            lblConexionGreen.Visible = true;
            lblUsuario.Text = oUsuario.Usuario.ToUpper();
            lblRol.Text = oUsuario.Rol.ToUpper();
            timer1.Start();
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            General.GUI.ProductosGestion f = new General.GUI.ProductosGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.CategoriasGestion f = new General.GUI.CategoriasGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!bgwConexion.IsBusy)
            {
                // Inicia el BackgroundWorker si no está ocupado
                bgwConexion.RunWorkerAsync();
            }
        }

        private void bgwConexion_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DataManager.DBConexion cn = new DataManager.DBConexion();
                if (cn.Conectar())
                {
                    e.Result = true;
                    cn.Desconectar();
                }
                else
                {
                    e.Result = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void bgwConexion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                lblConexionRed.Visible = false;
                lblConexionGreen.Visible = true;
            }
            else
            {
                lblConexionGreen.Visible = false;
                lblConexionRed.Visible = true;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void gestionDeMunicipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.MunicipiosGestion f = new General.GUI.MunicipiosGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.ProveedoresGestion f = new General.GUI.ProveedoresGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.GUI.VisorCliente f = new Reportes.GUI.VisorCliente();
            f.ShowDialog();
        }

        private void nuevaSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salidas.GUI.SalidaNueva f = new Salidas.GUI.SalidaNueva();
            f.MdiParent = this;
            f.Show();
        }

        private void buscarSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salidas.GUI.BuscarSalida f = new Salidas.GUI.BuscarSalida();
            f.MdiParent = this;
            f.Show();
        }

        private void nuevaEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entradas.GUI.NuevaEntrada f = new Entradas.GUI.NuevaEntrada();
            f.MdiParent = this;
            f.Show();
        }
    }
}
