
namespace SCDI.GUI
{
    partial class Clasificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clasificaciones));
            this.labelIdClasificacion = new System.Windows.Forms.Label();
            this.txtIdClasificacion = new System.Windows.Forms.TextBox();
            this.cmbClasificacion = new System.Windows.Forms.ComboBox();
            this.labelClasificacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClasificaciones = new System.Windows.Forms.DataGridView();
            this.labelBuscarClasificacion = new System.Windows.Forms.Label();
            this.txtBusquedaClasificacion = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.Buscar_clasificacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar_clasificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIdClasificacion
            // 
            this.labelIdClasificacion.AutoSize = true;
            this.labelIdClasificacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdClasificacion.Location = new System.Drawing.Point(12, 46);
            this.labelIdClasificacion.Name = "labelIdClasificacion";
            this.labelIdClasificacion.Size = new System.Drawing.Size(98, 20);
            this.labelIdClasificacion.TabIndex = 8;
            this.labelIdClasificacion.Text = "idClasificacion:";
            // 
            // txtIdClasificacion
            // 
            this.txtIdClasificacion.Enabled = false;
            this.txtIdClasificacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdClasificacion.Location = new System.Drawing.Point(116, 40);
            this.txtIdClasificacion.Name = "txtIdClasificacion";
            this.txtIdClasificacion.Size = new System.Drawing.Size(40, 26);
            this.txtIdClasificacion.TabIndex = 7;
            this.txtIdClasificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbClasificacion
            // 
            this.cmbClasificacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClasificacion.FormattingEnabled = true;
            this.cmbClasificacion.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbClasificacion.Location = new System.Drawing.Point(116, 113);
            this.cmbClasificacion.Name = "cmbClasificacion";
            this.cmbClasificacion.Size = new System.Drawing.Size(166, 28);
            this.cmbClasificacion.TabIndex = 18;
            // 
            // labelClasificacion
            // 
            this.labelClasificacion.AutoSize = true;
            this.labelClasificacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClasificacion.Location = new System.Drawing.Point(12, 113);
            this.labelClasificacion.Name = "labelClasificacion";
            this.labelClasificacion.Size = new System.Drawing.Size(83, 20);
            this.labelClasificacion.TabIndex = 17;
            this.labelClasificacion.Text = "Clasificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lista de Clasificaciones";
            // 
            // dgvClasificaciones
            // 
            this.dgvClasificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasificaciones.Location = new System.Drawing.Point(334, 113);
            this.dgvClasificaciones.Name = "dgvClasificaciones";
            this.dgvClasificaciones.Size = new System.Drawing.Size(445, 218);
            this.dgvClasificaciones.TabIndex = 19;
            // 
            // labelBuscarClasificacion
            // 
            this.labelBuscarClasificacion.AutoSize = true;
            this.labelBuscarClasificacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarClasificacion.Location = new System.Drawing.Point(330, 40);
            this.labelBuscarClasificacion.Name = "labelBuscarClasificacion";
            this.labelBuscarClasificacion.Size = new System.Drawing.Size(128, 20);
            this.labelBuscarClasificacion.TabIndex = 22;
            this.labelBuscarClasificacion.Text = "Buscar Clasificacion";
            // 
            // txtBusquedaClasificacion
            // 
            this.txtBusquedaClasificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusquedaClasificacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaClasificacion.Location = new System.Drawing.Point(464, 37);
            this.txtBusquedaClasificacion.Name = "txtBusquedaClasificacion";
            this.txtBusquedaClasificacion.Size = new System.Drawing.Size(227, 26);
            this.txtBusquedaClasificacion.TabIndex = 21;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Location = new System.Drawing.Point(228, 276);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(48, 46);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Location = new System.Drawing.Point(82, 276);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(48, 46);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(136, 276);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(48, 46);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertar.BackgroundImage")));
            this.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertar.Location = new System.Drawing.Point(28, 276);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(48, 46);
            this.btnInsertar.TabIndex = 24;
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // Buscar_clasificacion
            // 
            this.Buscar_clasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscar_clasificacion.Image = ((System.Drawing.Image)(resources.GetObject("Buscar_clasificacion.Image")));
            this.Buscar_clasificacion.Location = new System.Drawing.Point(708, 38);
            this.Buscar_clasificacion.Name = "Buscar_clasificacion";
            this.Buscar_clasificacion.Size = new System.Drawing.Size(25, 25);
            this.Buscar_clasificacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Buscar_clasificacion.TabIndex = 23;
            this.Buscar_clasificacion.TabStop = false;
            // 
            // Clasificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 336);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.Buscar_clasificacion);
            this.Controls.Add(this.labelBuscarClasificacion);
            this.Controls.Add(this.txtBusquedaClasificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvClasificaciones);
            this.Controls.Add(this.cmbClasificacion);
            this.Controls.Add(this.labelClasificacion);
            this.Controls.Add(this.labelIdClasificacion);
            this.Controls.Add(this.txtIdClasificacion);
            this.Name = "Clasificaciones";
            this.Text = "Clasificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar_clasificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdClasificacion;
        private System.Windows.Forms.TextBox txtIdClasificacion;
        private System.Windows.Forms.ComboBox cmbClasificacion;
        private System.Windows.Forms.Label labelClasificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClasificaciones;
        private System.Windows.Forms.PictureBox Buscar_clasificacion;
        private System.Windows.Forms.Label labelBuscarClasificacion;
        private System.Windows.Forms.TextBox txtBusquedaClasificacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
    }
}