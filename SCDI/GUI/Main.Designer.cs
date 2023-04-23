
namespace SCDI.GUI
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConexionRed = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConexionGreen = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioDeDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEntradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeExistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClasificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeDireccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeSalidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeSalidasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEntradasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwConexion = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblRol,
            this.lblConexionRed,
            this.lblConexionGreen});
            this.statusStrip.Location = new System.Drawing.Point(0, 530);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(884, 31);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuario.Image")));
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 26);
            this.lblUsuario.Text = "Usuario";
            // 
            // lblConexionRed
            // 
            this.lblConexionRed.Image = ((System.Drawing.Image)(resources.GetObject("lblConexionRed.Image")));
            this.lblConexionRed.Name = "lblConexionRed";
            this.lblConexionRed.Size = new System.Drawing.Size(146, 26);
            this.lblConexionRed.Text = "Desconectado";
            this.lblConexionRed.Visible = false;
            // 
            // lblConexionGreen
            // 
            this.lblConexionGreen.Image = ((System.Drawing.Image)(resources.GetObject("lblConexionGreen.Image")));
            this.lblConexionGreen.Name = "lblConexionGreen";
            this.lblConexionGreen.Size = new System.Drawing.Size(118, 26);
            this.lblConexionGreen.Text = "Conectado";
            this.lblConexionGreen.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(884, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeUsuariosToolStripMenuItem,
            this.gestionDeEmpleadosToolStripMenuItem,
            this.gestioDeDepartamentosToolStripMenuItem,
            this.gestionDeEntradasToolStripMenuItem,
            this.gestionDeExistenciasToolStripMenuItem,
            this.gestionDeClasificacionesToolStripMenuItem,
            this.gestionDeRolesToolStripMenuItem,
            this.gestionDeClientesToolStripMenuItem,
            this.gestionDeDireccionesToolStripMenuItem,
            this.gestionDeSalidasToolStripMenuItem,
            this.gestionDeSalidasDeProductosToolStripMenuItem,
            this.gestionDeEntradasDeProductosToolStripMenuItem,
            this.gestionDePermisosToolStripMenuItem,
            this.gestionDeOpcionesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.gestionDeCategoriasToolStripMenuItem});
            this.generalToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios";
            this.gestionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click);
            // 
            // gestionDeEmpleadosToolStripMenuItem
            // 
            this.gestionDeEmpleadosToolStripMenuItem.Name = "gestionDeEmpleadosToolStripMenuItem";
            this.gestionDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDeEmpleadosToolStripMenuItem.Text = "Gestion de Empleados";
            this.gestionDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeEmpleadosToolStripMenuItem_Click);
            // 
            // gestioDeDepartamentosToolStripMenuItem
            // 
            this.gestioDeDepartamentosToolStripMenuItem.Name = "gestioDeDepartamentosToolStripMenuItem";
            this.gestioDeDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestioDeDepartamentosToolStripMenuItem.Text = "Gestion de Departamentos";
            this.gestioDeDepartamentosToolStripMenuItem.Click += new System.EventHandler(this.gestioDeDepartamentosToolStripMenuItem_Click);
            // 
            // gestionDeEntradasToolStripMenuItem
            // 
            this.gestionDeEntradasToolStripMenuItem.Name = "gestionDeEntradasToolStripMenuItem";
            this.gestionDeEntradasToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDeEntradasToolStripMenuItem.Text = "Gestion de Entradas";
            this.gestionDeEntradasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeEntradasToolStripMenuItem_Click);
            // 
            // gestionDeExistenciasToolStripMenuItem
            // 
            this.gestionDeExistenciasToolStripMenuItem.Name = "gestionDeExistenciasToolStripMenuItem";
            this.gestionDeExistenciasToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDeExistenciasToolStripMenuItem.Text = "Gestion de Existencias";
            this.gestionDeExistenciasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeExistenciasToolStripMenuItem_Click);
            // 
            // gestionDeClasificacionesToolStripMenuItem
            // 
            this.gestionDeClasificacionesToolStripMenuItem.Name = "gestionDeClasificacionesToolStripMenuItem";
            this.gestionDeClasificacionesToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDeClasificacionesToolStripMenuItem.Text = "Gestion de Clasificaciones";
            this.gestionDeClasificacionesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClasificacionesToolStripMenuItem_Click);
            // 
            // gestionDeRolesToolStripMenuItem
            // 
            this.gestionDeRolesToolStripMenuItem.Name = "gestionDeRolesToolStripMenuItem";
            this.gestionDeRolesToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDeRolesToolStripMenuItem.Text = "Gestion de Roles";
            this.gestionDeRolesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeRolesToolStripMenuItem_Click);
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes";
            this.gestionDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClientesToolStripMenuItem_Click);
            // 
            // gestionDeDireccionesToolStripMenuItem
            // 
            this.gestionDeDireccionesToolStripMenuItem.Name = "gestionDeDireccionesToolStripMenuItem";
            this.gestionDeDireccionesToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDeDireccionesToolStripMenuItem.Text = "Gestion de Direcciones";
            this.gestionDeDireccionesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeDireccionesToolStripMenuItem_Click);
            // 
            // gestionDeSalidasToolStripMenuItem
            // 
            this.gestionDeSalidasToolStripMenuItem.Name = "gestionDeSalidasToolStripMenuItem";
            this.gestionDeSalidasToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDeSalidasToolStripMenuItem.Text = "Gestion de Salidas";
            this.gestionDeSalidasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeSalidasToolStripMenuItem_Click);
            // 
            // gestionDeSalidasDeProductosToolStripMenuItem
            // 
            this.gestionDeSalidasDeProductosToolStripMenuItem.Name = "gestionDeSalidasDeProductosToolStripMenuItem";
            this.gestionDeSalidasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDeSalidasDeProductosToolStripMenuItem.Text = "Gestion de Salidas de Productos";
            this.gestionDeSalidasDeProductosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeSalidasDeProductosToolStripMenuItem_Click);
            // 
            // gestionDeEntradasDeProductosToolStripMenuItem
            // 
            this.gestionDeEntradasDeProductosToolStripMenuItem.Name = "gestionDeEntradasDeProductosToolStripMenuItem";
            this.gestionDeEntradasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDeEntradasDeProductosToolStripMenuItem.Text = "Gestion de Entradas de Productos";
            this.gestionDeEntradasDeProductosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeEntradasDeProductosToolStripMenuItem_Click);
            // 
            // gestionDePermisosToolStripMenuItem
            // 
            this.gestionDePermisosToolStripMenuItem.Name = "gestionDePermisosToolStripMenuItem";
            this.gestionDePermisosToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDePermisosToolStripMenuItem.Text = "Gestion de Permisos";
            this.gestionDePermisosToolStripMenuItem.Click += new System.EventHandler(this.gestionDePermisosToolStripMenuItem_Click);
            // 
            // gestionDeOpcionesToolStripMenuItem
            // 
            this.gestionDeOpcionesToolStripMenuItem.Name = "gestionDeOpcionesToolStripMenuItem";
            this.gestionDeOpcionesToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDeOpcionesToolStripMenuItem.Text = "Gestion de Opciones";
            this.gestionDeOpcionesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeOpcionesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(291, 24);
            this.toolStripMenuItem2.Text = "Gestion de Productos";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // gestionDeCategoriasToolStripMenuItem
            // 
            this.gestionDeCategoriasToolStripMenuItem.Name = "gestionDeCategoriasToolStripMenuItem";
            this.gestionDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gestionDeCategoriasToolStripMenuItem.Text = "Gestion de Categorias";
            this.gestionDeCategoriasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeCategoriasToolStripMenuItem_Click);
            // 
            // bgwConexion
            // 
            this.bgwConexion.WorkerReportsProgress = true;
            this.bgwConexion.WorkerSupportsCancellation = true;
            this.bgwConexion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConexion_DoWork);
            this.bgwConexion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConexion_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRol
            // 
            this.lblRol.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Image = ((System.Drawing.Image)(resources.GetObject("lblRol.Image")));
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(52, 26);
            this.lblRol.Text = "Rol";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblConexionRed;
        private System.ComponentModel.BackgroundWorker bgwConexion;
        private System.Windows.Forms.ToolStripMenuItem gestionDeRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioDeDepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeEntradasToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeExistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClasificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeDireccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeSalidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeSalidasDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeEntradasDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDePermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblConexionGreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
    }
}



