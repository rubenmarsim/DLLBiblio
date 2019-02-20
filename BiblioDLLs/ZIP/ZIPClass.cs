using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIP
{
    /// <summary>
    /// Clase para comprimir y descomprimir una carpeta con todos los archivos que contiene
    /// </summary>
    public class ZIPClass
    {
        #region Variables Globales
        /// <summary>
        /// Path donde vamos a guardar todos los archivos a comprimir
        /// </summary>
        string _PathToCompress = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"/Archivos/Compress";
        /// <summary>
        /// Path donde se va a crear nuestro archivo comprimido
        /// </summary>
        string _PathCompressedArchive = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Archivos/ArchivosZIP.zip";
        /// <summary>
        /// Path donde vamos a descomprimir todos los archivos que tenemos en nuestro ZIP
        /// </summary>
        string _PathToDecompress = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Archivos/Extract";
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase ZIP, que nos permite comprimir y descomprimir una carpeta con todos los archivos que contiene
        /// </summary>
        public ZIPClass()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Metodo que comprueba si existen los path que vamos a usar, y si no 
        /// existen los crea
        /// </summary>
        private void ComprobarPaths()
        {
            if (!Directory.Exists(_PathToCompress))
            {
                Directory.CreateDirectory(_PathToCompress);
            }
            if (!Directory.Exists(_PathToDecompress))
            {
                Directory.CreateDirectory(_PathToDecompress);
            }
        }
        /// <summary>
        /// Intentamos crear el archivo comprimido y si ya esta creado lo borramos
        /// y lo volvemos a crear
        /// </summary>
        public void Comprimir()
        {
            ComprobarPaths();
            try
            {                
                ZipFile.CreateFromDirectory(_PathToCompress, _PathCompressedArchive);
            }
            catch (IOException)
            {
                File.Delete(_PathCompressedArchive);
                ZipFile.CreateFromDirectory(_PathToCompress, _PathCompressedArchive);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Intentamos descomprimir lo que hay en el zip, y si ya existe en la carpeta
        /// donde vamos a descomprimir lo borramos y luego descomprimimos
        /// </summary>
        public void Descomprimir()
        {
            ComprobarPaths();
            try
            {
                ZipFile.ExtractToDirectory(_PathCompressedArchive, _PathToDecompress);
            }
            catch (IOException)
            {
                string[] FilePath = Directory.GetFiles(_PathToDecompress);
                string[] carpetas = Directory.GetDirectories(_PathToDecompress);
                foreach (string fp in FilePath) File.Delete(fp);
                foreach (string cp in carpetas) Directory.Delete(cp);
                ZipFile.ExtractToDirectory(_PathCompressedArchive, _PathToDecompress);
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion
    }
}
