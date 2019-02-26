namespace FormPrueba
{
    partial class FormMail
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
            this.grpBoxEnviarCorreu = new System.Windows.Forms.GroupBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.txtBoxAsunto = new System.Windows.Forms.TextBox();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtBoxContenido = new System.Windows.Forms.TextBox();
            this.txtBoxPara = new System.Windows.Forms.TextBox();
            this.grpBoxEnviarCorreu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxEnviarCorreu
            // 
            this.grpBoxEnviarCorreu.Controls.Add(this.lblAsunto);
            this.grpBoxEnviarCorreu.Controls.Add(this.txtBoxAsunto);
            this.grpBoxEnviarCorreu.Controls.Add(this.lblContenido);
            this.grpBoxEnviarCorreu.Controls.Add(this.lblPara);
            this.grpBoxEnviarCorreu.Controls.Add(this.btnEnviar);
            this.grpBoxEnviarCorreu.Controls.Add(this.txtBoxContenido);
            this.grpBoxEnviarCorreu.Controls.Add(this.txtBoxPara);
            this.grpBoxEnviarCorreu.Location = new System.Drawing.Point(29, 12);
            this.grpBoxEnviarCorreu.Name = "grpBoxEnviarCorreu";
            this.grpBoxEnviarCorreu.Size = new System.Drawing.Size(742, 426);
            this.grpBoxEnviarCorreu.TabIndex = 1;
            this.grpBoxEnviarCorreu.TabStop = false;
            this.grpBoxEnviarCorreu.Text = "Enviar Correu";
            // 
            // lblAsunto
            // 
            this.lblAsunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(23, 110);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(43, 13);
            this.lblAsunto.TabIndex = 8;
            this.lblAsunto.Text = "Asunto:";
            // 
            // txtBoxAsunto
            // 
            this.txtBoxAsunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxAsunto.Location = new System.Drawing.Point(100, 107);
            this.txtBoxAsunto.Name = "txtBoxAsunto";
            this.txtBoxAsunto.Size = new System.Drawing.Size(354, 20);
            this.txtBoxAsunto.TabIndex = 2;
            this.txtBoxAsunto.Text = "Hula";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(23, 146);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(58, 13);
            this.lblContenido.TabIndex = 9;
            this.lblContenido.Text = "Contenido:";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(23, 72);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(32, 13);
            this.lblPara.TabIndex = 7;
            this.lblPara.Text = "Para:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(379, 324);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtBoxContenido
            // 
            this.txtBoxContenido.Location = new System.Drawing.Point(100, 146);
            this.txtBoxContenido.Multiline = true;
            this.txtBoxContenido.Name = "txtBoxContenido";
            this.txtBoxContenido.Size = new System.Drawing.Size(354, 140);
            this.txtBoxContenido.TabIndex = 3;
            this.txtBoxContenido.Text = "Buenos Dias";
            // 
            // txtBoxPara
            // 
            this.txtBoxPara.Location = new System.Drawing.Point(100, 69);
            this.txtBoxPara.Name = "txtBoxPara";
            this.txtBoxPara.Size = new System.Drawing.Size(354, 20);
            this.txtBoxPara.TabIndex = 1;
            this.txtBoxPara.Text = "ruben.martinez.simon@sarria.salesians.cat";
            // 
            // FormMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxEnviarCorreu);
            this.Name = "FormMail";
            this.Text = "FormMail";
            this.Load += new System.EventHandler(this.FormMail_Load);
            this.grpBoxEnviarCorreu.ResumeLayout(false);
            this.grpBoxEnviarCorreu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxEnviarCorreu;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.TextBox txtBoxAsunto;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtBoxContenido;
        private System.Windows.Forms.TextBox txtBoxPara;
    }
}