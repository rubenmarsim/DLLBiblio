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
    /// Formulario para hacer pruebas de las dlls
    /// </summary>
    public partial class frmPrueba : Form
    {
        #region Variables Globales
        GestionRSA.RSAClass CRSA;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public frmPrueba()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        /// <summary>
        /// Evento que se ejecuta cuando carga la parte visual del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPrueba_Load(object sender, EventArgs e)
        {
            CRSA = new GestionRSA.RSAClass();
        }
        private void btnCreateRSAKeys_Click(object sender, EventArgs e)
        {
            CRSA.CreateAndWriteRSAKeys();
        }

        private void btnReadRSAKeys_Click(object sender, EventArgs e)
        {
            CRSA.ReadRSAKeys();
        }

        private void btnSaveOnDB_Click(object sender, EventArgs e)
        {
            CRSA.GuardarPublicKeyEnDB();
        }
        #endregion

        #region Methods

        #endregion


    }
}
