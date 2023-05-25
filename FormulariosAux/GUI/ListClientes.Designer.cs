
namespace FormulariosAux.GUI
{
    partial class ListClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtBuscarPorNombre = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.BackgroundImage")));
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.Location = new System.Drawing.Point(1025, 9);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(39, 36);
            this.btnSeleccionar.TabIndex = 82;
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Visible = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtBuscarPorNombre
            // 
            this.txtBuscarPorNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPorNombre.Location = new System.Drawing.Point(173, 12);
            this.txtBuscarPorNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            this.txtBuscarPorNombre.Size = new System.Drawing.Size(284, 32);
            this.txtBuscarPorNombre.TabIndex = 80;
            this.txtBuscarPorNombre.Text = "";
            this.txtBuscarPorNombre.TextChanged += new System.EventHandler(this.txtBuscarPorNombre_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1069, 54);
            this.toolStrip1.TabIndex = 76;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nombres_cliente,
            this.apellidos_cliente,
            this.nacimiento,
            this.genero,
            this.idDireccion,
            this.dui,
            this.nit,
            this.direccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 54);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1069, 517);
            this.dgvDatos.TabIndex = 83;
            this.dgvDatos.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvDatos_ColumnAdded);
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "ID";
            this.idCliente.MinimumWidth = 6;
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Width = 50;
            // 
            // nombres_cliente
            // 
            this.nombres_cliente.DataPropertyName = "nombres_cliente";
            this.nombres_cliente.HeaderText = "Nombres";
            this.nombres_cliente.MinimumWidth = 6;
            this.nombres_cliente.Name = "nombres_cliente";
            this.nombres_cliente.ReadOnly = true;
            this.nombres_cliente.Width = 150;
            // 
            // apellidos_cliente
            // 
            this.apellidos_cliente.DataPropertyName = "apellidos_cliente";
            this.apellidos_cliente.HeaderText = "Apellidos";
            this.apellidos_cliente.MinimumWidth = 6;
            this.apellidos_cliente.Name = "apellidos_cliente";
            this.apellidos_cliente.ReadOnly = true;
            this.apellidos_cliente.Width = 150;
            // 
            // nacimiento
            // 
            this.nacimiento.DataPropertyName = "nacimiento";
            this.nacimiento.HeaderText = "Nacimiento";
            this.nacimiento.MinimumWidth = 6;
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.ReadOnly = true;
            this.nacimiento.Visible = false;
            this.nacimiento.Width = 200;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "Genero";
            this.genero.MinimumWidth = 6;
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Width = 125;
            // 
            // idDireccion
            // 
            this.idDireccion.DataPropertyName = "idDireccion";
            this.idDireccion.HeaderText = "ID_Direccion";
            this.idDireccion.MinimumWidth = 6;
            this.idDireccion.Name = "idDireccion";
            this.idDireccion.ReadOnly = true;
            this.idDireccion.Visible = false;
            this.idDireccion.Width = 125;
            // 
            // dui
            // 
            this.dui.DataPropertyName = "dui";
            this.dui.HeaderText = "Dui";
            this.dui.MinimumWidth = 6;
            this.dui.Name = "dui";
            this.dui.ReadOnly = true;
            this.dui.Visible = false;
            this.dui.Width = 200;
            // 
            // nit
            // 
            this.nit.DataPropertyName = "nit";
            this.nit.HeaderText = "Nit";
            this.nit.MinimumWidth = 6;
            this.nit.Name = "nit";
            this.nit.ReadOnly = true;
            this.nit.Visible = false;
            this.nit.Width = 150;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(917, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 84;
            this.label1.Text = "Seleccionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 85;
            this.label2.Text = "Digite el nombre: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1069, 29);
            this.statusStrip1.TabIndex = 92;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRegistros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(227, 23);
            this.lblRegistros.Text = "0 Registros Encontrados";
            // 
            // ListClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 571);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtBuscarPorNombre);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE CLIENTES";
            this.Load += new System.EventHandler(this.ListClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnSeleccionar;
        public System.Windows.Forms.RichTextBox txtBuscarPorNombre;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn nit;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistros;
    }
}