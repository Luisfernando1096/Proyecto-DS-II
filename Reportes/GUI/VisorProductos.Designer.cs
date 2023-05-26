
namespace Reportes.GUI
{
    partial class VisorProductos
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
            this.crvVisor1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvVisor1
            // 
            this.crvVisor1.ActiveViewIndex = -1;
            this.crvVisor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVisor1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVisor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVisor1.Location = new System.Drawing.Point(0, 0);
            this.crvVisor1.Name = "crvVisor1";
            this.crvVisor1.Size = new System.Drawing.Size(800, 450);
            this.crvVisor1.TabIndex = 1;
            this.crvVisor1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvVisor1.Load += new System.EventHandler(this.crvVisor1_Load);
            // 
            // VisorProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvVisor1);
            this.Name = "VisorProductos";
            this.Text = "VisorProductos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisor1;
    }
}