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
        ZIP.ZIPClass CZIP;
        GestionXML.GestionXMLClass CGestionXML;
        FormMail formMail;
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
            Instancias();
        }
        /// <summary>
        /// Se ejecuta cuando pulsamos el boton Create RSA Keys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateRSAKeys_Click(object sender, EventArgs e)
        {
            CRSA.CreateAndWriteRSAKeys();
        }
        /// <summary>
        /// Se ejecuta cuando pulsamos el boton Read RSA Keys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadRSAKeys_Click(object sender, EventArgs e)
        {
            CRSA.ReadRSAKeys();
        }
        /// <summary>
        /// Se ejecuta cuando pulsamos el boton Save on DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveOnDB_Click(object sender, EventArgs e)
        {
            CRSA.GuardarPublicKeyEnDB();
        }
        private void btnZIP_Click(object sender, EventArgs e)
        {
            CZIP.Comprimir();
        }

        private void btnUNZIP_Click(object sender, EventArgs e)
        {
            CZIP.Descomprimir();
        }
        private void btnSimetricEncrypt_Click(object sender, EventArgs e)
        {
            CGestionXML.OPTGestionXML(false, true, false);
        }

        private void btnAsimetricEncrypt_Click(object sender, EventArgs e)
        {
            CGestionXML.OPTGestionXML(true, true, false);
        }

        private void btnSimetricDecrypt_Click(object sender, EventArgs e)
        {
            CGestionXML.OPTGestionXML(false, false, true);
        }

        private void btnAsimetricDecrypt_Click(object sender, EventArgs e)
        {
            CGestionXML.OPTGestionXML(true, false, true);
        }
        /// <summary>
        /// Se ejecuta cuando pulsamos el boton FormMail, esto llama a otro
        /// formulario donde nos pide los datos para enviar el correo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFormMail_Click(object sender, EventArgs e)
        {
            formMail = new FormMail();
            formMail.Show();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Instanciamos las clases de las dlls que vamos a usar
        /// </summary>
        private void Instancias()
        {
            CRSA = new GestionRSA.RSAClass();
            CZIP = new ZIP.ZIPClass();
            CGestionXML = new GestionXML.GestionXMLClass();
        }



        #endregion

        
    }
}
