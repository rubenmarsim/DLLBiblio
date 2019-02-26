using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GestionCorreo
{
    /// <summary>
    /// Clase para la gestion de correos
    /// </summary>
    public class GestionMail
    {
        #region Variables Globales
        RijndaelManaged key = null;
        string _Path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Archivos/";
        const string _Filename = "Users.xml";
        GestionXML.GestionXMLClass CGestionXML = null;
        #endregion

        #region Propiedades
        private string _Asunto;
        /// <summary>
        /// Asunto del correo
        /// </summary>
        public string Asunto
        {
            get { return _Asunto; }
            set { _Asunto = value; }
        }

        private string _Contenido;
        /// <summary>
        /// Contenido del correo
        /// </summary>
        public string Contenido
        {
            get { return _Contenido; }
            set { _Contenido = value; }
        }

        private string _Destinatario;
        /// <summary>
        /// Destinatario del correo
        /// </summary>
        public string Destinatario
        {
            get { return _Destinatario; }
            set { _Destinatario = value; }
        }

        private string _Enviador;
        /// <summary>
        /// Correo de la persona que va a enviar el correo
        /// </summary>
        public string Enviador
        {
            get { return _Enviador; }
            set { _Enviador = value; }
        }

        private string _Contraseña;
        /// <summary>
        /// Contraseña de la persona que va a enviar el correo
        /// </summary>
        public string Contraseña
        {
            get { return _Contraseña; }
            set { _Contraseña = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase GestionMail que nos permite enviar correos
        /// </summary>
        public GestionMail()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Envia un correo
        /// </summary>
        /// <param name="Subject">Asunto del correo</param>
        /// <param name="Body">Contenido del correo</param>
        /// <param name="To">Destinatario del correo</param>
        public void EnviarMail(string Subject, string Body, string To)
        {
            try
            {
                GetCredencials();

                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = "smtp.gmail.com";
                client.Credentials = new System.Net.NetworkCredential(Enviador, Contraseña);

                MailMessage mail = new MailMessage(Enviador, To, Subject, Body);
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mail);
            }
            catch (SmtpException)
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
        /// <summary>
        /// Coje el correo y la contraseña de la persona que envia el correo
        /// </summary>
        private void GetCredencials()
        {
            CGestionXML = new GestionXML.GestionXMLClass();
            key = new RijndaelManaged();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;
            xmlDoc.Load(_Path + _Filename);

            // Create a new CspParameters object to specify
            // a key container.
            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = "XML_ENC_RSA_KEY";
            // Create a new RSA key and save it in the container.  This key will encrypt
            // a symmetric key, which will then be encryped in the XML document.
            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider(cspParams);

            try
            {
                xmlDoc.Load(_Path + "AEncryptedDoc.xml");
                CGestionXML.DesencriptarXML(xmlDoc, rsaKey, "rsaKey");
                Enviador = xmlDoc.GetElementsByTagName("UserId").Item(0).FirstChild.Value.ToString();
                Contraseña = xmlDoc.GetElementsByTagName("Password").Item(0).FirstChild.Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                // Clear the RSA key.
                rsaKey.Clear();
            }
        }
        #endregion
    }
}
