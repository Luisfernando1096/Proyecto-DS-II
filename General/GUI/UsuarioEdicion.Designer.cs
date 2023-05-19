
namespace General.GUI
{
    partial class UsuarioEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioEdicion));
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.bntBuscarRol = new System.Windows.Forms.Button();
            this.txtRol = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdEmpleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpleado.Location = new System.Drawing.Point(230, 227);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.ReadOnly = true;
            this.txtIdEmpleado.Size = new System.Drawing.Size(66, 30);
            this.txtIdEmpleado.TabIndex = 50;
            this.txtIdEmpleado.Visible = false;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleado.BackgroundImage")));
            this.btnBuscarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(503, 247);
            this.btnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(48, 45);
            this.btnBuscarEmpleado.TabIndex = 49;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Enabled = false;
            this.txtEmpleado.Location = new System.Drawing.Point(142, 258);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(343, 34);
            this.txtEmpleado.TabIndex = 48;
            this.txtEmpleado.Text = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(631, 435);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 69);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(535, 435);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 69);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Location = new System.Drawing.Point(632, 508);
            this.lblCancelar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(64, 17);
            this.lblCancelar.TabIndex = 43;
            this.lblCancelar.Text = "Cancelar";
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Location = new System.Drawing.Point(539, 508);
            this.lblGuardar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(61, 17);
            this.lblGuardar.TabIndex = 42;
            this.lblGuardar.Text = "Guardar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Empleado: ";
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(143, 189);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(343, 30);
            this.txtClave.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Clave";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(143, 126);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(343, 30);
            this.txtUsuario.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre de usuario:";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(143, 64);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(126, 30);
            this.txtIdUsuario.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID:";
            // 
            // txtIdRol
            // 
            this.txtIdRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdRol.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRol.Location = new System.Drawing.Point(230, 303);
            this.txtIdRol.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.ReadOnly = true;
            this.txtIdRol.Size = new System.Drawing.Size(66, 30);
            this.txtIdRol.TabIndex = 54;
            this.txtIdRol.Visible = false;
            // 
            // bntBuscarRol
            // 
            this.bntBuscarRol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntBuscarRol.BackgroundImage")));
            this.bntBuscarRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntBuscarRol.Location = new System.Drawing.Point(503, 318);
            this.bntBuscarRol.Margin = new System.Windows.Forms.Padding(4);
            this.bntBuscarRol.Name = "bntBuscarRol";
            this.bntBuscarRol.Size = new System.Drawing.Size(48, 44);
            this.bntBuscarRol.TabIndex = 53;
            this.bntBuscarRol.UseVisualStyleBackColor = true;
            this.bntBuscarRol.Click += new System.EventHandler(this.bntBuscarRol_Click);
            // 
            // txtRol
            // 
            this.txtRol.Enabled = false;
            this.txtRol.Location = new System.Drawing.Point(142, 334);
            this.txtRol.Margin = new System.Windows.Forms.Padding(4);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(343, 34);
            this.txtRol.TabIndex = 52;
            this.txtRol.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(142, 306);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 24);
            this.label9.TabIndex = 51;
            this.label9.Text = "Rol:";
            // 
            // UsuarioEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 568);
            this.Controls.Add(this.txtIdRol);
            this.Controls.Add(this.bntBuscarRol);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtIdEmpleado;
        public System.Windows.Forms.RichTextBox txtEmpleado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtIdRol;
        private System.Windows.Forms.Button bntBuscarRol;
        public System.Windows.Forms.RichTextBox txtRol;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnBuscarEmpleado;
    }
}