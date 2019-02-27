using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls.WindowsForms
{
    /// <summary>
    /// TextBox Base que contiene las funciones mas genericas para que los demas
    /// TextBos puedan heredar
    /// </summary>
    public partial class UCTextBoxBase : TextBox
    {
        #region Properties
        private bool _IsRequired;
        /// <summary>
        /// Si es true no deja salir del TextBox sin escribir nada
        /// </summary>
        public bool IsRequired
        {
            get { return _IsRequired; }
            set { _IsRequired = value; }
        }
        private bool _ChangeColorWhenFocus;
        /// <summary>
        /// Cambia de color cuando recive el focus, y lo pierde a la vez que el focus
        /// </summary>
        public bool ChangeColorWhenFocus
        {
            get { return _ChangeColorWhenFocus; }
            set { _ChangeColorWhenFocus = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public UCTextBoxBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        /// <summary>
        /// Se ejecuta cuando el TextBox se esta validando
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCtxtBoxBase_Validating(object sender, CancelEventArgs e)
        {
            if (IsRequired)
            {
                if (Text.Length == 0)
                {
                    e.Cancel = true;
                }
            }
        }
        /// <summary>
        /// Se ejecuta cuando el TextBox Recive el focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCtxtBoxBase_Enter(object sender, EventArgs e)
        {
            if (ChangeColorWhenFocus) BackColor = Color.LightGreen;
        }
        /// <summary>
        /// Se ejecuta cuando el TextBox pierde el focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCtxtBoxBase_Leave(object sender, EventArgs e)
        {
            if (ChangeColorWhenFocus) BackColor = Color.White;
        }
        #endregion

        #region Methods

        #endregion
    }
}
