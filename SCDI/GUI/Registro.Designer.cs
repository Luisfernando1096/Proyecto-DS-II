
namespace SCDI.GUI
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textClave = new System.Windows.Forms.TextBox();
            this.textConfirmarClave = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.bntRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(96, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite su ID de empleado:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 28);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(96, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre usuario:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 155);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 28);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(96, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite una clave:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(96, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirme su clave:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(96, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seleccione su rol:";
            // 
            // textClave
            // 
            this.textClave.Location = new System.Drawing.Point(286, 216);
            this.textClave.Multiline = true;
            this.textClave.Name = "textClave";
            this.textClave.PasswordChar = '*';
            this.textClave.Size = new System.Drawing.Size(221, 28);
            this.textClave.TabIndex = 8;
            // 
            // textConfirmarClave
            // 
            this.textConfirmarClave.Location = new System.Drawing.Point(286, 275);
            this.textConfirmarClave.Multiline = true;
            this.textConfirmarClave.Name = "textConfirmarClave";
            this.textConfirmarClave.PasswordChar = '*';
            this.textConfirmarClave.Size = new System.Drawing.Size(221, 28);
            this.textConfirmarClave.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(286, 334);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(221, 28);
            this.textBox5.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(391, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 31);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // bntRegresar
            // 
            this.bntRegresar.Location = new System.Drawing.Point(99, 415);
            this.bntRegresar.Name = "bntRegresar";
            this.bntRegresar.Size = new System.Drawing.Size(116, 31);
            this.bntRegresar.TabIndex = 12;
            this.bntRegresar.Text = "Regresar";
            this.bntRegresar.UseVisualStyleBackColor = true;
            this.bntRegresar.Click += new System.EventHandler(this.bntRegresar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 523);
            this.Controls.Add(this.bntRegresar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textConfirmarClave);
            this.Controls.Add(this.textClave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.TextBox textConfirmarClave;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button bntRegresar;
    }
}