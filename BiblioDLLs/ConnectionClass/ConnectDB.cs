using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
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
        OleDbConnection _AccessConnexion;
        SqlConnection _SQLConnexion;
        #endregion

        #region Properties
        private string _pConnectionString;
        /// <summary>
        /// String que contiene el ConnectionString
        /// </summary>
        public string pConnectionString
        {
            get { return _pConnectionString; }
            set { _pConnectionString = value; }
        }

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase ConnectDB, que nos permite conectarnos a una base de datos, hacer consultas, etc...
        /// </summary>
        /// <param name="DBtype">Tipo de DB a la cual nos vamos a conectar</param>
        /// <param name="ConnectionString">Connection string de la DB que nos queremos conectar, normalmente se encuentra en App.config del proyecto de inicio</param>
        public ConnectDB(DBType DBtype, string ConnectionString)
        {
            this._DBType = DBtype;
            this._pConnectionString = ConnectionString;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Metodo que coje el ConnectionString y lo guarda en la variable _ConnectionString
        /// </summary>
        public void GetConnexionString()
        {
            _ConnectionString = ConfigurationManager.ConnectionStrings[pConnectionString].ConnectionString;
        }
        /// <summary>
        /// Abre la conexion con la Base de datos
        /// </summary>
        public void Connect()
        {
            GetConnexionString();
            if (_DBType == DBType.Access)
            {                
                _AccessConnexion = new OleDbConnection(_ConnectionString);
                _AccessConnexion.Open();
            }else if (_DBType == DBType.SQL_Server)
            {
                _SQLConnexion = new SqlConnection(_ConnectionString);
                _SQLConnexion.Open();
            }
        }
        /// <summary>
        /// Coje la tabla que indiquemos de la DB
        /// </summary>
        /// <param name="TableName">Nombre de la tabla que queremos obtener</param>
        /// <returns>Devuelve un dataset con la tabla que hemos indicado</returns>
        public DataSet GetTable(string TableName)
        {
            DataSet dtsCli = new DataSet();
            Connect();
            string query = "SELECT * FROM " + TableName;

            if (_DBType == DBType.Access)
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, _ConnectionString);
                adapter.Fill(dtsCli, TableName);
            }
            else if (_DBType == DBType.SQL_Server)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);
                adapter.Fill(dtsCli, TableName);
                _SQLConnexion.Close();
            }
            return dtsCli;
        }
        /// <summary>
        /// Falta Coment
        /// </summary>
        /// <param name="TableName">Nombre de la tabla en la que queremos trabajar</param>
        /// <param name="FieldName">Nombre del campo en el cual queremos trabajar</param>
        /// <param name="valor"></param>
        /// <returns>Devuelve un dataset</returns>
        public DataSet GetByID(string TableName, string FieldName, int valor)
        {
            DataSet dtsCli = new DataSet();
            Connect();
            if (_DBType == DBType.SQL_Server)
            {                
                string query = "SELECT * FROM " + TableName + " WHERE " + FieldName + " = " + valor + "";
                SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);                
                adapter.Fill(dtsCli, TableName);                
            }
            return dtsCli;
        }
        /// <summary>
        /// Falta Coment
        /// </summary>
        /// <param name="TableName">Nombre de la tabla en la que queremos trabajar</param>
        /// <param name="valor"></param>
        /// <returns>Devuelve un dataset</returns>
        public DataSet GetByID(string TableName, int valor)
        {
            DataSet dtsCli = new DataSet();
            Connect();
            if (_DBType == DBType.SQL_Server)
            {
                string queryTable = "SELECT * FROM " + TableName;
                SqlDataAdapter adapterTable = new SqlDataAdapter(queryTable, _ConnectionString);
                DataSet dtsTable = new DataSet();
                adapterTable.Fill(dtsTable, TableName);
                DataColumn[] columns;
                columns = dtsTable.Tables[TableName].PrimaryKey;

                string NomPK;
                int num = columns.Count();
                NomPK = columns[0].ColumnName;

                string query = "SELECT * FROM " + TableName + " WHERE " + NomPK + " = " + valor + "";
                SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);
                adapter.Fill(dtsCli, TableName);
            }                
            return dtsCli;
        }
        /// <summary>
        /// Executa una Query sin devolver nada, muy util para deletes, inserts, etc...
        /// </summary>
        /// <param name="Query">Consulta que queremos ejecutar, puede ser un insert, update, etc...</param>
        public void Execute(string Query)
        {
            if (_DBType == DBType.Access)
            {
                try
                {
                    Connect();
                    OleDbCommand comanda = new OleDbCommand(Query, _AccessConnexion);
                }
                catch (OleDbException e)
                {

                }
                finally
                {
                    _AccessConnexion.Close();

                }
            }
            else if (_DBType == DBType.SQL_Server)
            {
                try
                {
                    Connect();
                    SqlCommand comanda = new SqlCommand(Query, _SQLConnexion);
                    comanda.ExecuteNonQuery();
                }
                catch (SqlException)
                {

                }
                finally
                {
                    _SQLConnexion.Close();
                }
            }
        }
        /// <summary>
        /// Falta Comment
        /// </summary>
        /// <param name="TableName">Nombre de la tabla en la que queremos trabajar</param>
        private void portaDadesOLEDB(string TableName)
        {
            if (_DBType == DBType.Access)
            {
                Connect();
                string query = "SELECT * FROM " + TableName;
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, _ConnectionString);
                DataSet dtsCli = new DataSet();
            }            
        }
        /// <summary>
        /// Compara la informacion que le pasamos en el dataset con la info de la DB y
        /// cambia en la DB lo que encuentra diferente en el dataset
        /// </summary>
        /// <param name="dts">Dataset con la informacion modificada</param>
        /// <param name="Query">Consulta a la DB</param>
        public void Update(DataSet dts, string Query)
        {
            if (_DBType == DBType.Access)
            {
                try
                {
                    Connect();
                    OleDbDataAdapter adapterDts = new OleDbDataAdapter(Query, _ConnectionString);
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(adapterDts);
                    adapterDts.Update(dts, Query);
                }
                catch (OleDbException e)
                {

                }
                finally
                {
                    _AccessConnexion.Close();

                }
            }
            else if (_DBType == DBType.SQL_Server)
            {
                try
                {
                    Connect();
                    SqlDataAdapter adapterDts = new SqlDataAdapter(Query, _ConnectionString);
                    SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adapterDts);

                    adapterDts.Update(dts);
                }
                catch (SqlException)
                {

                }
                finally
                {
                    _SQLConnexion.Close();
                }
            }
        }
        /// <summary>
        /// Coger informacion mediante una consulta
        /// </summary>
        /// <param name="Query">Consulta que va a definir la info que se va a mostrar</param>
        /// <returns>Devuelve un Dataset con la consulta hecha</returns>
        public DataSet GetByQuery(string Query)
        {
            DataSet dtsCli = new DataSet();
            Connect();
            if (_DBType == DBType.Access)
            {                
                OleDbDataAdapter adapter = new OleDbDataAdapter(Query, _ConnectionString);
                adapter.Fill(dtsCli, Query);
            }
            else if (_DBType == DBType.SQL_Server)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(Query, _ConnectionString);
                adapter.Fill(dtsCli);
            }
                return dtsCli;
        }
        /// <summary>
        /// Falta Comment
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="contra"></param>
        /// <returns>Devuelve un Dataset</returns>
        public DataSet ComprobarUser(string nombre, string contra)
        {
            Connect();
            string query = "SELECT Users.*, UserCategories.DescCategory,UserCategories.AccessLevel FROM Users INNER JOIN UserCategories ON Users.idUserCategory = UserCategories.idUserCategory WHERE UserName='" + nombre + "' AND Password ='" + contra + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);
            DataSet dtsCli = new DataSet();
            adapter.Fill(dtsCli);
            _SQLConnexion.Close();
            return dtsCli;
        }
        #endregion
    }
}
