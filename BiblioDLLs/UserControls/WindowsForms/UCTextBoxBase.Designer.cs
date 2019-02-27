namespace UserControls.WindowsForms
{
    partial class UCTextBoxBase
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.UCtxtBoxBase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UCtxtBoxBase
            // 
            this.UCtxtBoxBase.Location = new System.Drawing.Point(0, 0);
            this.UCtxtBoxBase.Name = "UCtxtBoxBase";
            this.UCtxtBoxBase.Size = new System.Drawing.Size(100, 20);
            this.UCtxtBoxBase.TabIndex = 0;
            this.UCtxtBoxBase.Enter += new System.EventHandler(this.UCtxtBoxBase_Enter);
            this.UCtxtBoxBase.Leave += new System.EventHandler(this.UCtxtBoxBase_Leave);
            this.UCtxtBoxBase.Validating += new System.ComponentModel.CancelEventHandler(this.UCtxtBoxBase_Validating);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UCtxtBoxBase;
    }
}
