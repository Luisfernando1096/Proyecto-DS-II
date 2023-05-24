
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
            this.gestionDePermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeMunicipiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripMenuItem1,
            this.entradaToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 68);
            this.toolStripMenuItem1.Text = "Salidas";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(188, 28);
            this.toolStripMenuItem3.Text = "Nueva Salida";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(188, 28);
            this.toolStripMenuItem4.Text = "Buscar Salida";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(188, 28);
            this.toolStripMenuItem5.Text = "Listar Salida";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaEntradaToolStripMenuItem,
            this.buscarEntradaToolStripMenuItem,
            this.listarEntradaToolStripMenuItem});
            this.entradaToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("entradaToolStripMenuItem.Image")));
            this.entradaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(173, 68);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // nuevaEntradaToolStripMenuItem
            // 
            this.nuevaEntradaToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaEntradaToolStripMenuItem.Name = "nuevaEntradaToolStripMenuItem";
            this.nuevaEntradaToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.nuevaEntradaToolStripMenuItem.Text = "Nueva Entrada";
            this.nuevaEntradaToolStripMenuItem.Click += new System.EventHandler(this.nuevaEntradaToolStripMenuItem_Click);
            // 
            // buscarEntradaToolStripMenuItem
            // 
            this.buscarEntradaToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarEntradaToolStripMenuItem.Name = "buscarEntradaToolStripMenuItem";
            this.buscarEntradaToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.buscarEntradaToolStripMenuItem.Text = "Buscar Entrada";
            this.buscarEntradaToolStripMenuItem.Click += new System.EventHandler(this.buscarEntradaToolStripMenuItem_Click_1);
            // 
            // listarEntradaToolStripMenuItem
            // 
            this.listarEntradaToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarEntradaToolStripMenuItem.Name = "listarEntradaToolStripMenuItem";
            this.listarEntradaToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.listarEntradaToolStripMenuItem.Text = "Listar Entrada";
            this.listarEntradaToolStripMenuItem.Click += new System.EventHandler(this.listarEntradaToolStripMenuItem_Click_1);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kardexToolStripMenuItem});
            this.inventarioToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventarioToolStripMenuItem.Image")));
            this.inventarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(180, 68);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // kardexToolStripMenuItem
            // 
            this.kardexToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kardexToolStripMenuItem.Name = "kardexToolStripMenuItem";
            this.kardexToolStripMenuItem.Size = new System.Drawing.Size(138, 28);
            this.kardexToolStripMenuItem.Text = "Kardex";
            this.kardexToolStripMenuItem.Click += new System.EventHandler(this.kardexToolStripMenuItem_Click);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kardexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEntradaToolStripMenuItem;
    }
}



