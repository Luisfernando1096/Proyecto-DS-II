
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
            this.lblConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeExistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClasificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeDireccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeSalidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwConexion = new System.ComponentModel.BackgroundWorker();
            this.gestionDeSalidasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblRol,
            this.lblConexion});
            this.statusStrip.Location = new System.Drawing.Point(0, 462);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(840, 31);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuario.Image")));
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 26);
            this.lblUsuario.Text = "Usuario";
            // 
            // lblRol
            // 
            this.lblRol.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Image = ((System.Drawing.Image)(resources.GetObject("lblRol.Image")));
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(48, 26);
            this.lblRol.Text = "Rol";
            // 
            // lblConexion
            // 
            this.lblConexion.Image = global::SCDI.Properties.Resources.icons8_filled_circle_green_60;
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(16, 26);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeUsuariosToolStripMenuItem,
            this.gestionDeEmpleadosToolStripMenuItem,
            this.gestionDeRolesToolStripMenuItem,
            this.gestionDeProductosToolStripMenuItem,
            this.gestionDeExistenciasToolStripMenuItem,
            this.gestionDeClasificacionesToolStripMenuItem});
            this.gestionDeRolesToolStripMenuItem,
            this.gestionDeClientesToolStripMenuItem,
            this.gestionDeDireccionesToolStripMenuItem,
            this.gestionDeSalidasToolStripMenuItem,
            this.gestionDeSalidasDeProductosToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion de usuarios";
            // 
            // gestionDeEmpleadosToolStripMenuItem
            // 
            this.gestionDeEmpleadosToolStripMenuItem.Name = "gestionDeEmpleadosToolStripMenuItem";
            this.gestionDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.gestionDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.gestionDeEmpleadosToolStripMenuItem.Text = "Gestion de Empleados";
            this.gestionDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeEmpleadosToolStripMenuItem_Click);
            // 
            // gestionDeRolesToolStripMenuItem
            // 
            this.gestionDeRolesToolStripMenuItem.Name = "gestionDeRolesToolStripMenuItem";
            this.gestionDeRolesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.gestionDeRolesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.gestionDeRolesToolStripMenuItem.Text = "Gestion de Roles";
            this.gestionDeRolesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeRolesToolStripMenuItem_Click);
            // 
            // gestionDeProductosToolStripMenuItem
            // 
            this.gestionDeProductosToolStripMenuItem.Name = "gestionDeProductosToolStripMenuItem";
            this.gestionDeProductosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.gestionDeProductosToolStripMenuItem.Text = "Gestion de Productos";
            this.gestionDeProductosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeProductosToolStripMenuItem_Click);
            // 
            // gestionDeExistenciasToolStripMenuItem
            // 
            this.gestionDeExistenciasToolStripMenuItem.Name = "gestionDeExistenciasToolStripMenuItem";
            this.gestionDeExistenciasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.gestionDeExistenciasToolStripMenuItem.Text = "Gestion de Existencias";
            this.gestionDeExistenciasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeExistenciasToolStripMenuItem_Click);
            // 
            // gestionDeClasificacionesToolStripMenuItem
            // 
            this.gestionDeClasificacionesToolStripMenuItem.Name = "gestionDeClasificacionesToolStripMenuItem";
            this.gestionDeClasificacionesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.gestionDeClasificacionesToolStripMenuItem.Text = "Gestion de Clasificaciones";
            this.gestionDeClasificacionesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClasificacionesToolStripMenuItem_Click);
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes";
            this.gestionDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClientesToolStripMenuItem_Click);
            // 
            // gestionDeDireccionesToolStripMenuItem
            // 
            this.gestionDeDireccionesToolStripMenuItem.Name = "gestionDeDireccionesToolStripMenuItem";
            this.gestionDeDireccionesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.gestionDeDireccionesToolStripMenuItem.Text = "Gestion de Direcciones";
            this.gestionDeDireccionesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeDireccionesToolStripMenuItem_Click);
            // 
            // gestionDeSalidasToolStripMenuItem
            // 
            this.gestionDeSalidasToolStripMenuItem.Name = "gestionDeSalidasToolStripMenuItem";
            this.gestionDeSalidasToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.gestionDeSalidasToolStripMenuItem.Text = "Gestion de Salidas";
            this.gestionDeSalidasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeSalidasToolStripMenuItem_Click);
            // 
            // bgwConexion
            // 
            this.bgwConexion.WorkerReportsProgress = true;
            this.bgwConexion.WorkerSupportsCancellation = true;
            // 
            // gestionDeSalidasDeProductosToolStripMenuItem
            // 
            this.gestionDeSalidasDeProductosToolStripMenuItem.Name = "gestionDeSalidasDeProductosToolStripMenuItem";
            this.gestionDeSalidasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.gestionDeSalidasDeProductosToolStripMenuItem.Text = "Gestion de Salidas de Productos";
            this.gestionDeSalidasDeProductosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeSalidasDeProductosToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 493);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
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
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
        private System.Windows.Forms.ToolStripStatusLabel lblConexion;
        private System.ComponentModel.BackgroundWorker bgwConexion;
        private System.Windows.Forms.ToolStripMenuItem gestionDeRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeExistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClasificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeDireccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeSalidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeSalidasDeProductosToolStripMenuItem;
    }
}



