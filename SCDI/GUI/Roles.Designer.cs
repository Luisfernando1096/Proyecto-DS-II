
namespace SCDI.GUI
{
    partial class Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            this.labelBuscarRol = new System.Windows.Forms.Label();
            this.txtBusquedaRol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRol = new System.Windows.Forms.DataGridView();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelidRol = new System.Windows.Forms.Label();
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.Buscar_roles = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar_roles)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBuscarRol
            // 
            this.labelBuscarRol.AutoSize = true;
            this.labelBuscarRol.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarRol.Location = new System.Drawing.Point(330, 52);
            this.labelBuscarRol.Name = "labelBuscarRol";
            this.labelBuscarRol.Size = new System.Drawing.Size(74, 20);
            this.labelBuscarRol.TabIndex = 35;
            this.labelBuscarRol.Text = "Buscar Rol";
            // 
            // txtBusquedaRol
            // 
            this.txtBusquedaRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusquedaRol.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaRol.Location = new System.Drawing.Point(420, 46);
            this.txtBusquedaRol.Name = "txtBusquedaRol";
            this.txtBusquedaRol.Size = new System.Drawing.Size(227, 26);
            this.txtBusquedaRol.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Lista de Roles";
            // 
            // dgvRol
            // 
            this.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRol.Location = new System.Drawing.Point(334, 123);
            this.dgvRol.Name = "dgvRol";
            this.dgvRol.Size = new System.Drawing.Size(445, 218);
            this.dgvRol.TabIndex = 32;
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbRol.Location = new System.Drawing.Point(66, 95);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(166, 28);
            this.cmbRol.TabIndex = 31;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(12, 103);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(29, 20);
            this.labelRol.TabIndex = 30;
            this.labelRol.Text = "Rol";
            // 
            // labelidRol
            // 
            this.labelidRol.AutoSize = true;
            this.labelidRol.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidRol.Location = new System.Drawing.Point(12, 46);
            this.labelidRol.Name = "labelidRol";
            this.labelidRol.Size = new System.Drawing.Size(44, 20);
            this.labelidRol.TabIndex = 29;
            this.labelidRol.Text = "idRol:";
            // 
            // txtIdRol
            // 
            this.txtIdRol.Enabled = false;
            this.txtIdRol.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRol.Location = new System.Drawing.Point(66, 40);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Size = new System.Drawing.Size(40, 26);
            this.txtIdRol.TabIndex = 28;
            this.txtIdRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Location = new System.Drawing.Point(198, 255);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(48, 46);
            this.btnLimpiar.TabIndex = 40;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Location = new System.Drawing.Point(70, 255);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(48, 46);
            this.btnModificar.TabIndex = 39;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(133, 255);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(48, 46);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertar.BackgroundImage")));
            this.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertar.Location = new System.Drawing.Point(16, 255);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(48, 46);
            this.btnInsertar.TabIndex = 37;
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // Buscar_roles
            // 
            this.Buscar_roles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscar_roles.Image = ((System.Drawing.Image)(resources.GetObject("Buscar_roles.Image")));
            this.Buscar_roles.Location = new System.Drawing.Point(653, 46);
            this.Buscar_roles.Name = "Buscar_roles";
            this.Buscar_roles.Size = new System.Drawing.Size(25, 25);
            this.Buscar_roles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Buscar_roles.TabIndex = 36;
            this.Buscar_roles.TabStop = false;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 348);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.Buscar_roles);
            this.Controls.Add(this.labelBuscarRol);
            this.Controls.Add(this.txtBusquedaRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRol);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.labelidRol);
            this.Controls.Add(this.txtIdRol);
            this.Name = "Roles";
            this.Text = "Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar_roles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.PictureBox Buscar_roles;
        private System.Windows.Forms.Label labelBuscarRol;
        private System.Windows.Forms.TextBox txtBusquedaRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelidRol;
        private System.Windows.Forms.TextBox txtIdRol;
    }
}