using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaitForms.SimpleWF
{
    /// <summary>
    /// Form modal que muestra un gift mediante un hilo, mientras se hace un proceso por detras
    /// </summary>
    public partial class SimpleWF : Form
    {
        /// <summary>
        /// Constructor por defecto del WaitForm, ademas se ha añadido la posicion inicial
        /// del Form, que en este caso sera el centro
        /// </summary>
        public SimpleWF()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        /// <summary>
        /// Segundo constructor del WaitForm, el cual define la posicion del WaitForm segun
        /// el Form padre y si no hay form padre lo pone en el centro
        /// </summary>
        /// <param name="parent">Form padre desde el cual se llama al WaitForm</param>
        public SimpleWF(Form parent)
        {
            InitializeComponent();
            if (parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Location.X + parent.Width / 2 - this.Width / 2, parent.Location.Y + parent.Height / 2 - this.Height / 2);
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterParent;
            }
        }
        /// <summary>
        /// Cierra el WaitForm y limpia la imagen
        /// </summary>
        public void CloseLoadingForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (lblGift.Image != null)
            {
                lblGift.Image.Dispose();
            }
        }
    }
}
