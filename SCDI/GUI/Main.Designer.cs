
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
            this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConexionRed = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConexionGreen = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioDeDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeExistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClasificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeMunicipiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwConexion = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            // lblRol
            // 
            this.lblRol.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Image = ((System.Drawing.Image)(resources.GetObject("lblRol.Image")));
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(52, 26);
            this.lblRol.Text = "Rol";
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
            this.generalToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salidasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(884, 72);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeUsuariosToolStripMenuItem,
            this.gestionDeEmpleadosToolStripMenuItem,
            this.gestioDeDepartamentosToolStripMenuItem,
            this.gestionDeExistenciasToolStripMenuItem,
            this.gestionDeClasificacionesToolStripMenuItem,
            this.gestionDeRolesToolStripMenuItem,
            this.gestionDeClientesToolStripMenuItem,
            this.toolStripMenuItem8,
            this.toolStripMenuItem7,
            this.toolStripMenuItem6,
            this.toolStripMenuItem5,
            this.gestionDePermisosToolStripMenuItem,
            this.gestionDeOpcionesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.gestionDeCategoriasToolStripMenuItem,
            this.gestionDeMunicipiosToolStripMenuItem,
            this.gestionDeProveedoresToolStripMenuItem});
            this.generalToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generalToolStripMenuItem.Image")));
            this.generalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(156, 68);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios";
            this.gestionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click);
            // 
            // gestionDeEmpleadosToolStripMenuItem
            // 
            this.gestionDeEmpleadosToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeEmpleadosToolStripMenuItem.Name = "gestionDeEmpleadosToolStripMenuItem";
            this.gestionDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.gestionDeEmpleadosToolStripMenuItem.Text = "Gestion de Empleados";
            this.gestionDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeEmpleadosToolStripMenuItem_Click);
            // 
            // gestioDeDepartamentosToolStripMenuItem
            // 
            this.gestioDeDepartamentosToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestioDeDepartamentosToolStripMenuItem.Name = "gestioDeDepartamentosToolStripMenuItem";
            this.gestioDeDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.gestioDeDepartamentosToolStripMenuItem.Text = "Gestion de Departamentos";
            this.gestioDeDepartamentosToolStripMenuItem.Click += new System.EventHandler(this.gestioDeDepartamentosToolStripMenuItem_Click);
            // 
            // gestionDeExistenciasToolStripMenuItem
            // 
            this.gestionDeExistenciasToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeExistenciasToolStripMenuItem.Name = "gestionDeExistenciasToolStripMenuItem";
            this.gestionDeExistenciasToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.gestionDeExistenciasToolStripMenuItem.Text = "Gestion de Existencias";
            this.gestionDeExistenciasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeExistenciasToolStripMenuItem_Click);
            // 
            // gestionDeClasificacionesToolStripMenuItem
            // 
            this.gestionDeClasificacionesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeClasificacionesToolStripMenuItem.Name = "gestionDeClasificacionesToolStripMenuItem";
            this.gestionDeClasificacionesToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.gestionDeClasificacionesToolStripMenuItem.Text = "Gestion de Clasificaciones";
            this.gestionDeClasificacionesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClasificacionesToolStripMenuItem_Click);
            // 
            // gestionDeRolesToolStripMenuItem
            // 
            this.gestionDeRolesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeRolesToolStripMenuItem.Name = "gestionDeRolesToolStripMenuItem";
            this.gestionDeRolesToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.gestionDeRolesToolStripMenuItem.Text = "Gestion de Roles";
            this.gestionDeRolesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeRolesToolStripMenuItem_Click);
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes";
            this.gestionDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(286, 28);
            this.toolStripMenuItem8.Text = "Gestion de Direcciones";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.gestionDeDireccionesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(286, 28);
            this.toolStripMenuItem7.Text = "Gestion de Clientes";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.gestionDeClientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(286, 28);
            this.toolStripMenuItem6.Text = "Gestion de Roles";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.gestionDeRolesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(286, 28);
            this.toolStripMenuItem5.Text = "Gestion de Clasificaciones";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.gestionDeClasificacionesToolStripMenuItem_Click);
            // 
            // gestionDePermisosToolStripMenuItem
            // 
            this.gestionDePermisosToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDePermisosToolStripMenuItem.Name = "gestionDePermisosToolStripMenuItem";
            this.gestionDePermisosToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.gestionDePermisosToolStripMenuItem.Text = "Gestion de Permisos";
            this.gestionDePermisosToolStripMenuItem.Click += new System.EventHandler(this.gestionDePermisosToolStripMenuItem_Click);
            // 
            // gestionDeOpcionesToolStripMenuItem
            // 
            this.gestionDeOpcionesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeOpcionesToolStripMenuItem.Name = "gestionDeOpcionesToolStripMenuItem";
            this.gestionDeOpcionesToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.gestionDeOpcionesToolStripMenuItem.Text = "Gestion de Opciones";
            this.gestionDeOpcionesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeOpcionesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(286, 28);
            this.toolStripMenuItem2.Text = "Gestion de Productos";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // gestionDeCategoriasToolStripMenuItem
            // 
            this.gestionDeCategoriasToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeCategoriasToolStripMenuItem.Name = "gestionDeCategoriasToolStripMenuItem";
            this.gestionDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.gestionDeCategoriasToolStripMenuItem.Text = "Gestion de Categorias";
            this.gestionDeCategoriasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeCategoriasToolStripMenuItem_Click);
            // 
            // gestionDeMunicipiosToolStripMenuItem
            // 
            this.gestionDeMunicipiosToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeMunicipiosToolStripMenuItem.Name = "gestionDeMunicipiosToolStripMenuItem";
            this.gestionDeMunicipiosToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.gestionDeMunicipiosToolStripMenuItem.Text = "Gestion de municipios";
            this.gestionDeMunicipiosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeMunicipiosToolStripMenuItem_Click);
            // 
            // gestionDeProveedoresToolStripMenuItem
            // 
            this.gestionDeProveedoresToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeProveedoresToolStripMenuItem.Name = "gestionDeProveedoresToolStripMenuItem";
            this.gestionDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.gestionDeProveedoresToolStripMenuItem.Text = "Gestion de proveedores";
            this.gestionDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.gestionDeProveedoresToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(186, 68);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(145, 28);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaSalidaToolStripMenuItem,
            this.buscarSalidaToolStripMenuItem,
            this.listarSalidaToolStripMenuItem});
            this.salidasToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salidasToolStripMenuItem.Image")));
            this.salidasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(151, 68);
            this.salidasToolStripMenuItem.Text = "Salidas";
            // 
            // nuevaSalidaToolStripMenuItem
            // 
            this.nuevaSalidaToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaSalidaToolStripMenuItem.Name = "nuevaSalidaToolStripMenuItem";
            this.nuevaSalidaToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.nuevaSalidaToolStripMenuItem.Text = "Nueva Salida";
            this.nuevaSalidaToolStripMenuItem.Click += new System.EventHandler(this.nuevaSalidaToolStripMenuItem_Click);
            // 
            // buscarSalidaToolStripMenuItem
            // 
            this.buscarSalidaToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarSalidaToolStripMenuItem.Name = "buscarSalidaToolStripMenuItem";
            this.buscarSalidaToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.buscarSalidaToolStripMenuItem.Text = "Buscar Salida";
            this.buscarSalidaToolStripMenuItem.Click += new System.EventHandler(this.buscarSalidaToolStripMenuItem_Click);
            // 
            // listarSalidaToolStripMenuItem
            // 
            this.listarSalidaToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarSalidaToolStripMenuItem.Name = "listarSalidaToolStripMenuItem";
            this.listarSalidaToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.listarSalidaToolStripMenuItem.Text = "Listar Salida";
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        //private System.Windows.Forms.ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeExistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClasificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDePermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblConexionGreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
        private System.Windows.Forms.ToolStripMenuItem gestionDeMunicipiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaSalidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarSalidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarSalidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}



