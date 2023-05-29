using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;
using System.IO;

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

        private bool FormularioEstaAbierto(Type tipoFormulario) /*Recorre toda la colección de formularios abiertos sin encontrar una coincidencia, significa que el formulario buscado no está abierto y no se ha encontrado 
                                                                 ninguna instancia de ese tipo en Application.OpenForms. En ese caso, se devuelve false para indicar que el formulario no está abierto*/
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == tipoFormulario)
                {
                    return true;
                }
            }
            return false;
        }

        private void gestionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(General.GUI.EmpleadosGestion)))
                {
                    MessageBox.Show("La ventana de gestión de Empleados ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.GUI.EmpleadosGestion f = new General.GUI.EmpleadosGestion();
                    f.MdiParent = this;//No permite que salgan los formularios del form MDI
                    f.Show();
                }
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
                if (FormularioEstaAbierto(typeof(General.GUI.RolesGestion)))
                {
                    MessageBox.Show("La ventana de gestión de Roles ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.GUI.RolesGestion f = new General.GUI.RolesGestion();
                    f.MdiParent = this;//No permite que salgan los formularios del form MDI
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(General.GUI.UsuariosGestion)))
                {
                    MessageBox.Show("La ventana de gestión de Usuarios ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.GUI.UsuariosGestion f = new General.GUI.UsuariosGestion();
                    f.MdiParent = this; // No permite que salgan los formularios del form MDI
                    f.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gestioDeDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(General.GUI.DepartamentosGestion)))
                {
                    MessageBox.Show("La ventana de gestión de Departamentos ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.GUI.DepartamentosGestion f = new General.GUI.DepartamentosGestion();
                    f.MdiParent = this;
                    f.Show();
                }
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
                if (FormularioEstaAbierto(typeof(General.GUI.ClasificacionesGestion)))
                {
                    MessageBox.Show("La ventana de gestión de Clasificaciones ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.GUI.ClasificacionesGestion f = new General.GUI.ClasificacionesGestion();
                    f.MdiParent = this;//No permite que salgan los formularios del form MDI
                    f.Show();
                }
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
                if (FormularioEstaAbierto(typeof(General.GUI.ClientesGestion)))
                {
                    MessageBox.Show("La ventana de gestión de Clientes ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.GUI.ClientesGestion f = new General.GUI.ClientesGestion();
                    f.MdiParent = this;//No permite que salgan los formularios del form MDI
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void gestionDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(General.GUI.PermisosGestion)))
                {
                    MessageBox.Show("La ventana de gestión de Permisos ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.GUI.PermisosGestion f = new General.GUI.PermisosGestion();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void gestionDeOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(General.GUI.OpcionesGestion)))
                {
                    MessageBox.Show("La ventana de gestión de Opciones ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.GUI.OpcionesGestion f = new General.GUI.OpcionesGestion();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(General.GUI.ProductosGestion)))
                {
                    MessageBox.Show("La ventana de gestión de Productos ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.GUI.ProductosGestion f = new General.GUI.ProductosGestion();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void gestionDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(General.GUI.CategoriasGestion)))
                {
                    MessageBox.Show("La ventana de gestión de Categoria ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.GUI.CategoriasGestion f = new General.GUI.CategoriasGestion();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
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
            try
            {
                if (FormularioEstaAbierto(typeof(General.GUI.MunicipiosGestion)))
                {
                    MessageBox.Show("La ventana de gestión de Municipio ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.GUI.MunicipiosGestion f = new General.GUI.MunicipiosGestion();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void gestionDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(General.GUI.ProveedoresGestion)))
                {
                    MessageBox.Show("La ventana de gestión de Proveedores ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.GUI.ProveedoresGestion f = new General.GUI.ProveedoresGestion();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.GUI.VisorCliente f = new Reportes.GUI.VisorCliente();
            f.ShowDialog();
        }

        private void nuevaEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(Entradas.GUI.NuevaEntrada)))
                {
                    MessageBox.Show("La ventana de Registro de Entradas ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Entradas.GUI.NuevaEntrada f = new Entradas.GUI.NuevaEntrada();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(Salidas.GUI.SalidaNueva)))
                {
                    MessageBox.Show("La ventana de Registro de Salidas ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Salidas.GUI.SalidaNueva f = new Salidas.GUI.SalidaNueva();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(Salidas.GUI.BuscarSalida)))
                {
                    MessageBox.Show("La ventana de Busqueda de Salidas ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Salidas.GUI.BuscarSalida f = new Salidas.GUI.BuscarSalida();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void kardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario.GUI.InventarioGenerar f = new Inventario.GUI.InventarioGenerar();
            f.MdiParent = this;
            f.Show();
        }

        private void buscarEntradaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(Entradas.GUI.BuscarEntradas)))
                {
                    MessageBox.Show("La ventana de Busqueda de Salidas ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Entradas.GUI.BuscarEntradas f = new Entradas.GUI.BuscarEntradas();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar sesion?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void respaldarBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "bd_inventario";
            string backupFilePath = @"C:\Users\fruiz\OneDrive\Escritorio\Respaldos\bd_inventario" + DateTime.Now.Year.ToString().Trim() + "_" + DateTime.Now.Month.ToString().Trim() + "_" + DateTime.Now.Second.ToString().Trim() + ".sql";

            string mysqldumpPath = @"C:\Program Files\MySQL\MySQL Server 5.7\bin\mysqldump.exe";
            string command = $"\"{mysqldumpPath}\" --defaults-file=\"C:\\MysqlDump\\backup.cnf\" --host={server} {database} > {backupFilePath}";

            
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = Process.Start(psi);
            process.StandardInput.WriteLine(command);
            process.StandardInput.Close();
            process.WaitForExit();

            int exitCode = process.ExitCode; // Obtener el código de salida del proceso

            if (exitCode == 0)
            {
                MessageBox.Show("¡Respaldo de base de datos completado!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡Upss! ocurrio un error", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Ocurrió un error durante el respaldo de la base de datos. Código de salida: " + exitCode);
            }

            
        }

        private string RutaOut()
        {
            string desktopPath = "";
            desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            return desktopPath;

        }

        private string RutaMysql()
        {
            // Buscar la ruta al ejecutable mysqldump en el registro del sistema
            string mysqldumpPath = "";

            // Intentar encontrar la ruta en la clave de registro predeterminada de MySQL
            string mysqlRegistryPath = @"SOFTWARE\MySQL AB";
            using (RegistryKey mysqlKey = Registry.LocalMachine.OpenSubKey(mysqlRegistryPath))
            {
                if (mysqlKey != null)
                {
                    string[] subKeyNames = mysqlKey.GetSubKeyNames();
                    if (subKeyNames.Length > 0)
                    {
                        string mysqlVersion = subKeyNames[subKeyNames.Length - 1]; // Obtener la última versión instalada
                        using (RegistryKey versionKey = mysqlKey.OpenSubKey(mysqlVersion))
                        {
                            if (versionKey != null)
                            {
                                object installLocation = versionKey.GetValue("Location");
                                if (installLocation != null)
                                {
                                    string mysqlBinPath = System.IO.Path.Combine(installLocation.ToString(), "bin");
                                    mysqldumpPath = System.IO.Path.Combine(mysqlBinPath, "mysqldump.exe");
                                }
                            }
                        }
                    }
                }
            }
            if (!string.IsNullOrEmpty(mysqldumpPath))
            {
                Console.WriteLine($"Ruta al ejecutable mysqldump: {mysqldumpPath}");
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la ruta al ejecutable mysqldump.");
            }
            return mysqldumpPath;
        }

        private void gestionDeDireccionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(General.GUI.DireccionesGestion)))
                {
                    MessageBox.Show("La ventana de gestión de Direcciones ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    General.GUI.DireccionesGestion f = new General.GUI.DireccionesGestion();
                    f.MdiParent = this;//No permite que salgan los formularios del form MDI
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void listaSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(Salidas.GUI.ListaSalidas)))
                {
                    MessageBox.Show("La ventana ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Salidas.GUI.ListaSalidas f = new Salidas.GUI.ListaSalidas();
                    f.MdiParent = this;//No permite que salgan los formularios del form MDI
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void listaEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioEstaAbierto(typeof(Entradas.GUI.ListaEntradas)))
                {
                    MessageBox.Show("La ventana ya está abierta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Entradas.GUI.ListaEntradas f = new Entradas.GUI.ListaEntradas();
                    f.MdiParent = this;//No permite que salgan los formularios del form MDI
                    f.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void kardexToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inventario.GUI.KardexGenerar f = new Inventario.GUI.KardexGenerar();
            f.MdiParent = this;
            f.Show();
        }
    }
}
