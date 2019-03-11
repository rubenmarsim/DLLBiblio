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
        Gestion.GestionClaves.RSAClass CRSA;
        Gestion.GestionArchivos.ZIPClass CZIP;
        Gestion.GestionArchivos.GestionXML CGestionXML;
        FormMail formMail;
        WaitForms.SimpleWF.CSimpleWF SimpleWF;
        UserControls.WindowsForms.UCTextBoxBase UCTextBoxBase;
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
        /// <summary>
        /// Se ejecuta cuando pulsamos el boton Compress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZIP_Click(object sender, EventArgs e)
        {
            CZIP.Comprimir();
        }
        /// <summary>
        /// Se ejecuta cuando pulsamos el boton Descompress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUNZIP_Click(object sender, EventArgs e)
        {
            CZIP.Descomprimir();
        }
        /// <summary>
        /// Se ejecuta cuando pulsamos el boton SimetricEncrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimetricEncrypt_Click(object sender, EventArgs e)
        {
            CGestionXML.OPTGestionXML(false, true, false);
        }
        /// <summary>
        /// Se ejecuta cuando pulsamos el boton SimetricDecrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsimetricEncrypt_Click(object sender, EventArgs e)
        {
            CGestionXML.OPTGestionXML(true, true, false);
        }
        /// <summary>
        /// Se ejecuta cuando pulsamos el boton AsimetricEncrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimetricDecrypt_Click(object sender, EventArgs e)
        {
            CGestionXML.OPTGestionXML(false, false, true);
        }
        /// <summary>
        /// Se ejecuta cuando pulsamos el boton AsimetricDecrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Se ejecuta cuando pulsamos el boton Procesos, el cual muestra el waitform 
        /// y un messagebox para que de tiempo a ver el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimpleWaitForm_Click(object sender, EventArgs e)
        {
            SimpleWF.Show();
            MessageBox.Show("Prueba Simple Wait Form");
            SimpleWF.Close();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Instanciamos las clases de las dlls que vamos a usar
        /// </summary>
        private void Instancias()
        {
            CRSA = new Gestion.GestionClaves.RSAClass();
            CZIP = new Gestion.GestionArchivos.ZIPClass();
            CGestionXML = new Gestion.GestionArchivos.GestionXML();
            SimpleWF = new WaitForms.SimpleWF.CSimpleWF();
            UCTextBoxBase = new UserControls.WindowsForms.UCTextBoxBase();
        }
        #endregion

        private void uctxtBoxUno_Validating(object sender, CancelEventArgs e)
        {
            if (UCTextBoxBase.ErrorIsRequired)
            {
                errorProvider1.SetError(uctxtBoxUno, "Campo Obligatorio");
            }
        }
    }
}
