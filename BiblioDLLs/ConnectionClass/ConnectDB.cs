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
        const string _cConnectionString = "BadgesConnectionString";
        #endregion

        #region Constructores
        public ConnectDB(DBType DBtype)
        {
            this._DBType = DBtype;
        }
        #endregion

        #region Methods
        public void GetConnexionString()
        {
            _ConnectionString = ConfigurationManager.ConnectionStrings[_cConnectionString].ConnectionString;
        }

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

        public DataSet GetTable(string nomTaula)
        {
            DataSet dtsCli = new DataSet();
            Connect();
            string query = "SELECT * FROM " + nomTaula;

            if (_DBType == DBType.Access)
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, _ConnectionString);
                adapter.Fill(dtsCli, nomTaula);
            }
            else if (_DBType == DBType.SQL_Server)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);
                adapter.Fill(dtsCli, nomTaula);
                _SQLConnexion.Close();
            }
            return dtsCli;
        }
        public DataSet PortarPerID(string nomTaula, string nomCamp, int valor)
        {
            Connect();
            string query = "SELECT * FROM " + nomTaula + " WHERE " + nomCamp + " = " + valor + "";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);
            DataSet dtsCli = new DataSet();
            adapter.Fill(dtsCli, nomTaula);
            return dtsCli;

        }
        public DataSet PortarPerID(string nomTaula, int valor)
        {
            Connect();
            string queryTable = "SELECT * FROM " + nomTaula;
            SqlDataAdapter adapterTable = new SqlDataAdapter(queryTable, _ConnectionString);
            DataSet dtsTable = new DataSet();
            adapterTable.Fill(dtsTable, nomTaula);
            DataColumn[] columns;
            columns = dtsTable.Tables[nomTaula].PrimaryKey;

            string NomPK;
            int num = columns.Count();
            NomPK = columns[0].ColumnName;

            string query = "SELECT * FROM " + nomTaula + " WHERE " + NomPK + " = " + valor + "";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);
            DataSet dtsCli = new DataSet();
            adapter.Fill(dtsCli, nomTaula);
            return dtsCli;
        }
        public void Executa(string consulta)
        {
            if (_DBType == DBType.Access)
            {
                try
                {
                    Connect();
                    OleDbCommand comanda = new OleDbCommand(consulta, _AccessConnexion);
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
                    SqlCommand comanda = new SqlCommand(consulta, _SQLConnexion);
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
                    _AccessConnexion.Close();

                }
            }
            else if (_DBType == DBType.SQL_Server)
            {
                try
                {
                    Connect();
                    SqlDataAdapter adapterDts = new SqlDataAdapter(consulta, _ConnectionString);
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
        public DataSet portaPerConsulta(string consultaSql)
        {
            DataSet dtsCli = new DataSet();
            Connect();
            if (_DBType == DBType.Access)
            {                
                OleDbDataAdapter adapter = new OleDbDataAdapter(consultaSql, _ConnectionString);
                adapter.Fill(dtsCli, consultaSql);
            }
            else if (_DBType == DBType.SQL_Server)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consultaSql, _ConnectionString);
                adapter.Fill(dtsCli);
            }
                return dtsCli;
        }
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
