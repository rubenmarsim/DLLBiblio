using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrueba
{
    /// <summary>
    /// Formulario para enviar correos
    /// </summary>
    public partial class FormMail : Form
    {
        #region Variables Globales
        GestionCorreo.GestionMail CGestorCorreo;
        #endregion

        #region Constructores
        /// <summary>
        /// Contructor por defecto
        /// </summary>
        public FormMail()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void FormMail_Load(object sender, EventArgs e)
        {
            CGestorCorreo = new GestionCorreo.GestionMail();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            CGestorCorreo.EnviarMail(txtBoxAsunto.Text, txtBoxContenido.Text, txtBoxPara.Text);
        }
        #endregion
    }
}
