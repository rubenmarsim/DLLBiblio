using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionClass
{
    /// <summary>
    /// Clase que nos permite conectarnos a una base de datos, hacer
    /// consultas, etc...
    /// </summary>
    public class ConnectDB
    {
        #region Variables Globales
        /// <summary>
        /// Tipo de base de datos a la que nos queremos conectar
        /// </summary>
        public enum DBType
        {
            Access,
            SQL_Server
        }
        private DBType _DBType;

        private string _ConnectionString;
        OleDbConnection AccessConnexion;
        #endregion

        #region Constructores
        public ConnectDB(DBType DBtype)
        {
            this._DBType = DBtype;
        }
        #endregion

        #region Methods
        public void getConnexionString()
        {            
            _ConnectionString = ConfigurationManager.ConnectionStrings["BadgesConnectionString"].ConnectionString;
        }

        public void Connect()
        {
            if (_DBType == DBType.Access)
            {
                getConnexionString();
                AccessConnexion = new OleDbConnection(_ConnectionString);
                AccessConnexion.Open();
            }            
        }

        public DataSet portaTaula(string nomTaula)
        {
            DataSet dtsCli = new DataSet();

            if (_DBType == DBType.Access)
            {
                Connect();
                string query = "SELECT * FROM " + nomTaula;
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, _ConnectionString);                
                adapter.Fill(dtsCli, nomTaula);
            }

            return dtsCli;
        }

        public void Executa(string consulta)
        {
            if (_DBType == DBType.Access)
            {
                try
                {
                    Connect();
                    OleDbCommand comanda = new OleDbCommand(consulta, AccessConnexion);
                }
                catch (OleDbException e)
                {
                }
                finally
                {
                    AccessConnexion.Close();

                }
            }
            
        }

        private void portaDadesOLEDB(string nomTaula)
        {
            if (_DBType == DBType.Access)
            {
                Connect();
                string query = "SELECT * FROM " + nomTaula;
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, _ConnectionString);
                DataSet dtsCli = new DataSet();
            }            

        }
        public void Actualitzar(DataSet dts, string consulta)
        {
            if (_DBType == DBType.Access)
            {
                try
                {
                    Connect();
                    OleDbDataAdapter adapterDts = new OleDbDataAdapter(consulta, _ConnectionString);
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(adapterDts);
                    adapterDts.Update(dts, consulta);
                }
                catch (OleDbException e)
                {

                }
                finally
                {
                    AccessConnexion.Close();

                }
            }
            
        }
        public DataSet portaPerConsulta(string consultaSql)
        {
            DataSet dtsCli = new DataSet();
            if (_DBType == DBType.Access)
            {
                Connect();
                OleDbDataAdapter adapter = new OleDbDataAdapter(consultaSql, _ConnectionString);
                adapter.Fill(dtsCli, consultaSql);
            }

            return dtsCli;
        }
        #endregion
    }
}
