
namespace Inventario.GUI
{
    partial class KardexGenerar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotalEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotalSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(188, 20);
            this.lblNombre.TabIndex = 88;
            this.lblNombre.Text = "Digite el codigo del producto:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1110, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 87;
            this.button1.Text = "Ver Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(206, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(186, 26);
            this.txtBusqueda.TabIndex = 86;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.tipo_movimiento,
            this.cantidadEntrada,
            this.precioEntrada,
            this.costoTotalEntrada,
            this.cantidadSalida,
            this.precioSalida,
            this.costoTotalSalida,
            this.cantidad,
            this.costoUnitario,
            this.costoTotal});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.Location = new System.Drawing.Point(10, 68);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1205, 347);
            this.dgvDatos.TabIndex = 85;
            // 
            // producto
            // 
            this.producto.DataPropertyName = "producto";
            this.producto.HeaderText = "Nombre Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 200;
            // 
            // tipo_movimiento
            // 
            this.tipo_movimiento.DataPropertyName = "tipo_movimiento";
            this.tipo_movimiento.HeaderText = "Movimiento";
            this.tipo_movimiento.Name = "tipo_movimiento";
            this.tipo_movimiento.ReadOnly = true;
            // 
            // cantidadEntrada
            // 
            this.cantidadEntrada.DataPropertyName = "cantidadEntrada";
            this.cantidadEntrada.HeaderText = "CantidadE";
            this.cantidadEntrada.Name = "cantidadEntrada";
            this.cantidadEntrada.ReadOnly = true;
            // 
            // precioEntrada
            // 
            this.precioEntrada.DataPropertyName = "precioEntrada";
            this.precioEntrada.HeaderText = "PrecioE";
            this.precioEntrada.Name = "precioEntrada";
            this.precioEntrada.ReadOnly = true;
            // 
            // costoTotalEntrada
            // 
            this.costoTotalEntrada.DataPropertyName = "costoTotalEntrada";
            this.costoTotalEntrada.HeaderText = "CostoTotalE";
            this.costoTotalEntrada.Name = "costoTotalEntrada";
            this.costoTotalEntrada.ReadOnly = true;
            // 
            // cantidadSalida
            // 
            this.cantidadSalida.DataPropertyName = "cantidadSalida";
            this.cantidadSalida.HeaderText = "CantidadS";
            this.cantidadSalida.Name = "cantidadSalida";
            this.cantidadSalida.ReadOnly = true;
            // 
            // precioSalida
            // 
            this.precioSalida.DataPropertyName = "precioSalida";
            this.precioSalida.HeaderText = "PrecioS";
            this.precioSalida.Name = "precioSalida";
            this.precioSalida.ReadOnly = true;
            // 
            // costoTotalSalida
            // 
            this.costoTotalSalida.DataPropertyName = "costoTotalSalida";
            this.costoTotalSalida.HeaderText = "CostoTotalS";
            this.costoTotalSalida.Name = "costoTotalSalida";
            this.costoTotalSalida.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // costoUnitario
            // 
            this.costoUnitario.DataPropertyName = "costoUnitario";
            this.costoUnitario.HeaderText = "C/U";
            this.costoUnitario.Name = "costoUnitario";
            this.costoUnitario.ReadOnly = true;
            // 
            // costoTotal
            // 
            this.costoTotal.DataPropertyName = "costoTotal";
            this.costoTotal.HeaderText = "CostoTotal";
            this.costoTotal.Name = "costoTotal";
            this.costoTotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 24);
            this.label1.TabIndex = 89;
            this.label1.Text = "Entradas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(612, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 24);
            this.label4.TabIndex = 92;
            this.label4.Text = "Salidas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(910, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 24);
            this.label5.TabIndex = 93;
            this.label5.Text = "Saldos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KardexGenerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 462);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvDatos);
            this.Name = "KardexGenerar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kardex";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotalEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotalSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}