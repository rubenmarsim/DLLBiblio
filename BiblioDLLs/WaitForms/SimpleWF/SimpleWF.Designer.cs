namespace WaitForms.SimpleWF
{
    partial class SimpleWF
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
            this.panelSimpleWF = new System.Windows.Forms.Panel();
            this.lblGift = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.panelSimpleWF.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSimpleWF
            // 
            this.panelSimpleWF.Controls.Add(this.lblText);
            this.panelSimpleWF.Controls.Add(this.lblGift);
            this.panelSimpleWF.Location = new System.Drawing.Point(0, 0);
            this.panelSimpleWF.Name = "panelSimpleWF";
            this.panelSimpleWF.Size = new System.Drawing.Size(300, 108);
            this.panelSimpleWF.TabIndex = 0;
            // 
            // lblGift
            // 
            this.lblGift.Image = global::WaitForms.Properties.Resources.timg11;
            this.lblGift.Location = new System.Drawing.Point(0, 0);
            this.lblGift.Name = "lblGift";
            this.lblGift.Size = new System.Drawing.Size(100, 106);
            this.lblGift.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lblText.Location = new System.Drawing.Point(110, 42);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(166, 21);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Esperando Procesos.";
            // 
            // SimpleWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 108);
            this.Controls.Add(this.panelSimpleWF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimpleWF";
            this.Text = "SimpleWF";
            this.panelSimpleWF.ResumeLayout(false);
            this.panelSimpleWF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSimpleWF;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblGift;
    }
}