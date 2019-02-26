using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaitForms.SimpleWF
{
    /// <summary>
    /// Clase con los metodos necesarios para llamar al WaitForm, mediante un hilo,
    /// para poder hacer un proceso largo por detras en lo que se muestra el WaitForm
    /// </summary>
    public class CSimpleWF
    {
        SimpleWF _loadingForm;
        Thread _loadthread;
        /// <summary>
        /// Lanza un hilo en el cual ejecuta el metodo LoadingProcess, que basicamente,
        /// muestra el WaitForm
        /// </summary>
        public void Show()
        {
            _loadthread = new Thread(new ThreadStart(LoadingProcessEx));
            _loadthread.Start();
        }
        /// <summary>
        /// Lanza un hilo en el cual ejecuta el metodo LoadingProcess, que basicamente,
        /// muestra el WaitForm, y ademas se le pasa el Form padre
        /// </summary>
        /// <param name="parent">Form padre, el cual llama a esta clase y al WaitForm</param>
        public void Show(Form parent)
        {
            _loadthread = new Thread(new ParameterizedThreadStart(LoadingProcessEx));
            _loadthread.Start(parent);
        }
        /// <summary>
        /// Se cierra el hilo y el Form
        /// </summary>
        public void Close()
        {
            if (_loadingForm != null)
            {
                _loadingForm.BeginInvoke(new ThreadStart(_loadingForm.CloseLoadingForm));
                _loadingForm = null;
                _loadthread = null;
            }
        }
        /// <summary>
        /// Abre el WaitForm
        /// </summary>
        private void LoadingProcessEx()
        {
            _loadingForm = new SimpleWF();
            _loadingForm.ShowDialog();
        }
        /// <summary>
        /// Abre el WaitForm y le pasa como parametro el Form padre
        /// </summary>
        /// <param name="parent">Form padre, el cual llama a esta clase y al WaitForm</param>
        private void LoadingProcessEx(object parent)
        {
            Form Cparent = parent as Form;
            _loadingForm = new SimpleWF(Cparent);
            _loadingForm.ShowDialog();
        }
    }
}
