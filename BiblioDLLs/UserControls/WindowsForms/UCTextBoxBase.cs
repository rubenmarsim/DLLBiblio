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
        /// <summary>
        /// Si es true no deja salir del TextBox sin escribir nada
        /// </summary>
        private bool _IsRequired;
        /// <summary>
        /// Si es true no deja salir del TextBox sin escribir nada
        /// </summary>
        public bool IsRequired
        {
            get { return _IsRequired; }
            set { _IsRequired = value; }
        }
        private bool _ErrorIsRequired;
        /// <summary>
        /// Sirve para saber cuando estamos incumpliendo la propiedad IsRequired
        /// (Entonces estara true)
        /// esto lo podemos aprovechar con un errorProvider o algo asi
        /// </summary>
        public bool ErrorIsRequired
        {
            get { return _ErrorIsRequired; }
            set { _ErrorIsRequired = value; }
        }

        /// <summary>
        /// Cambia de color cuando recive el focus, y lo pierde a la vez que el focus
        /// </summary>
        private bool _ChangeColorWhenFocus;
        /// <summary>
        /// Cambia de color cuando recive el focus, y lo pierde a la vez que el focus
        /// </summary>
        public bool ChangeColorWhenFocus
        {
            get { return _ChangeColorWhenFocus; }
            set { _ChangeColorWhenFocus = value; }
        }
        /// <summary>
        /// Si es true solo deja introducir valores numericos enteros
        /// </summary>
        private bool _IsNumeric;
        /// <summary>
        /// Si es true solo deja introducir valores numericos enteros
        /// </summary>
        public bool IsNumeric
        {
            get { return _IsNumeric; }
            set { _IsNumeric = value; }
        }
        /// <summary>
        /// Si es true deja añadir decimales
        /// </summary>
        private bool _bUseDecimals;
        /// <summary>
        /// Si es true deja añadir decimales
        /// </summary>
        public bool bUseDecimals
        {
            get { return _bUseDecimals; }
            set { _bUseDecimals = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public UCTextBoxBase()
        {
            InitializeComponent();
            ChargeEvents();
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
                    ErrorIsRequired = true;
                }
                else
                {
                    e.Cancel = false;
                    ErrorIsRequired = false;
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
        /// <summary>
        /// Se ejecuta cuando el TextBox tiene el focus y se presiona y
        /// se suelta una tecla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCtxtBoxBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsNumeric)
            {
                if (char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else if (char.IsPunctuation(e.KeyChar) && bUseDecimals)
                {
                    if (e.KeyChar == '.' || e.KeyChar == ',')
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
                else if (char.IsSeparator(e.KeyChar))
                    e.Handled = true;
                else
                    e.Handled = true;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Carga los eventos en el constructor para que se ejecuten
        /// </summary>
        private void ChargeEvents()
        {
            this.Validating += new System.ComponentModel.CancelEventHandler(UCtxtBoxBase_Validating);
            this.Enter += new EventHandler(UCtxtBoxBase_Enter);
            this.Leave += new EventHandler(UCtxtBoxBase_Leave);
            this.KeyPress += new KeyPressEventHandler(UCtxtBoxBase_KeyPress);
        }
        #endregion

        
    }
}
