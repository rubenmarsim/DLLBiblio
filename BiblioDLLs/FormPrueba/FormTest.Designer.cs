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
            this.btnUNZIP = new System.Windows.Forms.Button();
            this.btnZIP = new System.Windows.Forms.Button();
            this.grpBoxGestionXMLs = new System.Windows.Forms.GroupBox();
            this.btnAsimetricDecrypt = new System.Windows.Forms.Button();
            this.btnAsimetricEncrypt = new System.Windows.Forms.Button();
            this.btnSimetricDecrypt = new System.Windows.Forms.Button();
            this.btnSimetricEncrypt = new System.Windows.Forms.Button();
            this.grpBoxMail = new System.Windows.Forms.GroupBox();
            this.btnFormMail = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSimpleWaitForm = new System.Windows.Forms.Button();
            this.uctxtBoxUno = new UserControls.WindowsForms.UCTextBoxBase();
            this.grpBoxRSA.SuspendLayout();
            this.grpBoxZIP.SuspendLayout();
            this.grpBoxGestionXMLs.SuspendLayout();
            this.grpBoxMail.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // grpBoxGestionXMLs
            // 
            this.grpBoxGestionXMLs.Controls.Add(this.btnAsimetricDecrypt);
            this.grpBoxGestionXMLs.Controls.Add(this.btnAsimetricEncrypt);
            this.grpBoxGestionXMLs.Controls.Add(this.btnSimetricDecrypt);
            this.grpBoxGestionXMLs.Controls.Add(this.btnSimetricEncrypt);
            this.grpBoxGestionXMLs.Location = new System.Drawing.Point(241, 12);
            this.grpBoxGestionXMLs.Name = "grpBoxGestionXMLs";
            this.grpBoxGestionXMLs.Size = new System.Drawing.Size(179, 113);
            this.grpBoxGestionXMLs.TabIndex = 2;
            this.grpBoxGestionXMLs.TabStop = false;
            this.grpBoxGestionXMLs.Text = "Gestion XMLs";
            // 
            // btnAsimetricDecrypt
            // 
            this.btnAsimetricDecrypt.Location = new System.Drawing.Point(111, 20);
            this.btnAsimetricDecrypt.Name = "btnAsimetricDecrypt";
            this.btnAsimetricDecrypt.Size = new System.Drawing.Size(61, 83);
            this.btnAsimetricDecrypt.TabIndex = 3;
            this.btnAsimetricDecrypt.Text = "AsimetricDecrypt";
            this.btnAsimetricDecrypt.UseVisualStyleBackColor = true;
            this.btnAsimetricDecrypt.Click += new System.EventHandler(this.btnAsimetricDecrypt_Click);
            // 
            // btnAsimetricEncrypt
            // 
            this.btnAsimetricEncrypt.Location = new System.Drawing.Point(7, 80);
            this.btnAsimetricEncrypt.Name = "btnAsimetricEncrypt";
            this.btnAsimetricEncrypt.Size = new System.Drawing.Size(98, 23);
            this.btnAsimetricEncrypt.TabIndex = 2;
            this.btnAsimetricEncrypt.Text = "AsimetricEncrypt";
            this.btnAsimetricEncrypt.UseVisualStyleBackColor = true;
            this.btnAsimetricEncrypt.Click += new System.EventHandler(this.btnAsimetricEncrypt_Click);
            // 
            // btnSimetricDecrypt
            // 
            this.btnSimetricDecrypt.Location = new System.Drawing.Point(7, 50);
            this.btnSimetricDecrypt.Name = "btnSimetricDecrypt";
            this.btnSimetricDecrypt.Size = new System.Drawing.Size(98, 23);
            this.btnSimetricDecrypt.TabIndex = 1;
            this.btnSimetricDecrypt.Text = "SimetricDecrypt";
            this.btnSimetricDecrypt.UseVisualStyleBackColor = true;
            this.btnSimetricDecrypt.Click += new System.EventHandler(this.btnSimetricDecrypt_Click);
            // 
            // btnSimetricEncrypt
            // 
            this.btnSimetricEncrypt.Location = new System.Drawing.Point(7, 20);
            this.btnSimetricEncrypt.Name = "btnSimetricEncrypt";
            this.btnSimetricEncrypt.Size = new System.Drawing.Size(98, 23);
            this.btnSimetricEncrypt.TabIndex = 0;
            this.btnSimetricEncrypt.Text = "SimetricEncrypt";
            this.btnSimetricEncrypt.UseVisualStyleBackColor = true;
            this.btnSimetricEncrypt.Click += new System.EventHandler(this.btnSimetricEncrypt_Click);
            // 
            // grpBoxMail
            // 
            this.grpBoxMail.Controls.Add(this.btnFormMail);
            this.grpBoxMail.Location = new System.Drawing.Point(426, 12);
            this.grpBoxMail.Name = "grpBoxMail";
            this.grpBoxMail.Size = new System.Drawing.Size(89, 52);
            this.grpBoxMail.TabIndex = 3;
            this.grpBoxMail.TabStop = false;
            this.grpBoxMail.Text = "Gestion Mail";
            // 
            // btnFormMail
            // 
            this.btnFormMail.Location = new System.Drawing.Point(6, 19);
            this.btnFormMail.Name = "btnFormMail";
            this.btnFormMail.Size = new System.Drawing.Size(75, 23);
            this.btnFormMail.TabIndex = 0;
            this.btnFormMail.Text = "Form Mail";
            this.btnFormMail.UseVisualStyleBackColor = true;
            this.btnFormMail.Click += new System.EventHandler(this.btnFormMail_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSimpleWaitForm);
            this.groupBox1.Location = new System.Drawing.Point(426, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SmplWaitForm";
            // 
            // btnSimpleWaitForm
            // 
            this.btnSimpleWaitForm.Location = new System.Drawing.Point(7, 22);
            this.btnSimpleWaitForm.Name = "btnSimpleWaitForm";
            this.btnSimpleWaitForm.Size = new System.Drawing.Size(75, 23);
            this.btnSimpleWaitForm.TabIndex = 0;
            this.btnSimpleWaitForm.Text = "Procesos";
            this.btnSimpleWaitForm.UseVisualStyleBackColor = true;
            this.btnSimpleWaitForm.Click += new System.EventHandler(this.btnSimpleWaitForm_Click);
            // 
            // uctxtBoxUno
            // 
            this.uctxtBoxUno.ChangeColorWhenFocus = false;
            this.uctxtBoxUno.IsNumeric = true;
            this.uctxtBoxUno.IsRequired = false;
            this.uctxtBoxUno.Location = new System.Drawing.Point(309, 229);
            this.uctxtBoxUno.Name = "uctxtBoxUno";
            this.uctxtBoxUno.Size = new System.Drawing.Size(227, 20);
            this.uctxtBoxUno.TabIndex = 5;
            this.uctxtBoxUno.Text = "User Control Text Box 1";
            this.uctxtBoxUno.Enter += new System.EventHandler(this.uctxtBoxUno_Enter);
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uctxtBoxUno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxMail);
            this.Controls.Add(this.grpBoxGestionXMLs);
            this.Controls.Add(this.grpBoxZIP);
            this.Controls.Add(this.grpBoxRSA);
            this.Name = "frmPrueba";
            this.Text = "FormPrueba";
            this.Load += new System.EventHandler(this.frmPrueba_Load);
            this.grpBoxRSA.ResumeLayout(false);
            this.grpBoxZIP.ResumeLayout(false);
            this.grpBoxGestionXMLs.ResumeLayout(false);
            this.grpBoxMail.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxRSA;
        private System.Windows.Forms.Button btnSaveOnDB;
        private System.Windows.Forms.Button btnReadRSAKeys;
        private System.Windows.Forms.Button btnCreateRSAKeys;
        private System.Windows.Forms.GroupBox grpBoxZIP;
        private System.Windows.Forms.Button btnUNZIP;
        private System.Windows.Forms.Button btnZIP;
        private System.Windows.Forms.GroupBox grpBoxGestionXMLs;
        private System.Windows.Forms.Button btnSimetricEncrypt;
        private System.Windows.Forms.Button btnSimetricDecrypt;
        private System.Windows.Forms.GroupBox grpBoxMail;
        private System.Windows.Forms.Button btnFormMail;
        private System.Windows.Forms.Button btnAsimetricDecrypt;
        private System.Windows.Forms.Button btnAsimetricEncrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSimpleWaitForm;
        private UserControls.WindowsForms.UCTextBoxBase uctxtBoxUno;
    }
}

