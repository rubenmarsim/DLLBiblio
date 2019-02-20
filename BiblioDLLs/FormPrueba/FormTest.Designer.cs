namespace FormPrueba
{
    partial class frmPrueba
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
            this.grpBoxRSA = new System.Windows.Forms.GroupBox();
            this.btnSaveOnDB = new System.Windows.Forms.Button();
            this.btnReadRSAKeys = new System.Windows.Forms.Button();
            this.btnCreateRSAKeys = new System.Windows.Forms.Button();
            this.grpBoxZIP = new System.Windows.Forms.GroupBox();
            this.btnZIP = new System.Windows.Forms.Button();
            this.btnUNZIP = new System.Windows.Forms.Button();
            this.grpBoxRSA.SuspendLayout();
            this.grpBoxZIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxRSA
            // 
            this.grpBoxRSA.Controls.Add(this.btnSaveOnDB);
            this.grpBoxRSA.Controls.Add(this.btnReadRSAKeys);
            this.grpBoxRSA.Controls.Add(this.btnCreateRSAKeys);
            this.grpBoxRSA.Location = new System.Drawing.Point(12, 12);
            this.grpBoxRSA.Name = "grpBoxRSA";
            this.grpBoxRSA.Size = new System.Drawing.Size(115, 113);
            this.grpBoxRSA.TabIndex = 0;
            this.grpBoxRSA.TabStop = false;
            this.grpBoxRSA.Text = "Gestion RSA";
            // 
            // btnSaveOnDB
            // 
            this.btnSaveOnDB.Location = new System.Drawing.Point(7, 80);
            this.btnSaveOnDB.Name = "btnSaveOnDB";
            this.btnSaveOnDB.Size = new System.Drawing.Size(101, 23);
            this.btnSaveOnDB.TabIndex = 2;
            this.btnSaveOnDB.Text = "Save on DB";
            this.btnSaveOnDB.UseVisualStyleBackColor = true;
            this.btnSaveOnDB.Click += new System.EventHandler(this.btnSaveOnDB_Click);
            // 
            // btnReadRSAKeys
            // 
            this.btnReadRSAKeys.Location = new System.Drawing.Point(7, 50);
            this.btnReadRSAKeys.Name = "btnReadRSAKeys";
            this.btnReadRSAKeys.Size = new System.Drawing.Size(101, 23);
            this.btnReadRSAKeys.TabIndex = 1;
            this.btnReadRSAKeys.Text = "Read RSA Keys";
            this.btnReadRSAKeys.UseVisualStyleBackColor = true;
            this.btnReadRSAKeys.Click += new System.EventHandler(this.btnReadRSAKeys_Click);
            // 
            // btnCreateRSAKeys
            // 
            this.btnCreateRSAKeys.Location = new System.Drawing.Point(7, 20);
            this.btnCreateRSAKeys.Name = "btnCreateRSAKeys";
            this.btnCreateRSAKeys.Size = new System.Drawing.Size(101, 23);
            this.btnCreateRSAKeys.TabIndex = 0;
            this.btnCreateRSAKeys.Text = "Create RSA Keys";
            this.btnCreateRSAKeys.UseVisualStyleBackColor = true;
            this.btnCreateRSAKeys.Click += new System.EventHandler(this.btnCreateRSAKeys_Click);
            // 
            // grpBoxZIP
            // 
            this.grpBoxZIP.Controls.Add(this.btnUNZIP);
            this.grpBoxZIP.Controls.Add(this.btnZIP);
            this.grpBoxZIP.Location = new System.Drawing.Point(133, 12);
            this.grpBoxZIP.Name = "grpBoxZIP";
            this.grpBoxZIP.Size = new System.Drawing.Size(102, 113);
            this.grpBoxZIP.TabIndex = 1;
            this.grpBoxZIP.TabStop = false;
            this.grpBoxZIP.Text = "ZIP y UNZIP";
            // 
            // btnZIP
            // 
            this.btnZIP.Location = new System.Drawing.Point(7, 32);
            this.btnZIP.Name = "btnZIP";
            this.btnZIP.Size = new System.Drawing.Size(87, 23);
            this.btnZIP.TabIndex = 0;
            this.btnZIP.Text = "Compress";
            this.btnZIP.UseVisualStyleBackColor = true;
            this.btnZIP.Click += new System.EventHandler(this.btnZIP_Click);
            // 
            // btnUNZIP
            // 
            this.btnUNZIP.Location = new System.Drawing.Point(7, 70);
            this.btnUNZIP.Name = "btnUNZIP";
            this.btnUNZIP.Size = new System.Drawing.Size(87, 23);
            this.btnUNZIP.TabIndex = 1;
            this.btnUNZIP.Text = "Descompress";
            this.btnUNZIP.UseVisualStyleBackColor = true;
            this.btnUNZIP.Click += new System.EventHandler(this.btnUNZIP_Click);
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxZIP);
            this.Controls.Add(this.grpBoxRSA);
            this.Name = "frmPrueba";
            this.Text = "FormPrueba";
            this.Load += new System.EventHandler(this.frmPrueba_Load);
            this.grpBoxRSA.ResumeLayout(false);
            this.grpBoxZIP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxRSA;
        private System.Windows.Forms.Button btnSaveOnDB;
        private System.Windows.Forms.Button btnReadRSAKeys;
        private System.Windows.Forms.Button btnCreateRSAKeys;
        private System.Windows.Forms.GroupBox grpBoxZIP;
        private System.Windows.Forms.Button btnUNZIP;
        private System.Windows.Forms.Button btnZIP;
    }
}

