using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Class
{
    class Connection
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapter;

        #region Конструктор
        public Connection()
        {
            sqlConnection = new SqlConnection();
            sqlDataAdapter = new SqlDataAdapter();
        }

        public Connection(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlDataAdapter = new SqlDataAdapter();
        }
        #endregion

        #region Свойства
        /// <summary>
        /// Строка соединения
        /// </summary>
        public string ConnectionString
        {
            set => sqlConnection.ConnectionString=value;
            get => sqlConnection.ConnectionString;
        }
        #endregion

        #region Методы

        #region SQL

        /// <summary>
        ///  Получить запрос для получения данных об отделах
        /// </summary>
        /// <returns></returns>
        private SqlCommand SQLDepartments()
        {
            string sqlString = String.Format("Select ID {0} " +
                ",Name {0}" +
                ",Code {0}" +
                ",ParentDepartmentID {0}" +
                "from Department", Environment.NewLine );
            return new SqlCommand(sqlString, sqlConnection);
        }

        #endregion

        #region Получить данные
        /// <summary>
        /// Получить информацию об отделах
        /// </summary>
        public DataTable GetDepartments()
        {
            DataTable returnValue=new DataTable();
            if(Open())
            {
                SqlCommand sqlCommand = SQLDepartments();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(returnValue);
            }
            return returnValue;
        }

        #endregion

        /// <summary>
        /// Открыть соединение с БД
        /// </summary>
        /// <returns>Успешность выполнения открытия соединения с БД</returns>
        public bool Open()
        {
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                Messages.ConnectionErrorException(ex.Message);
                sqlConnection.Close();
                return false;
            }
        }

        /// <summary>
        /// Закрыть соединение с БД
        /// </summary>
        /// <returns>Успешность выполнения закрытия соединения с БД</returns>
        public bool Close()
        {
            try
            {
                sqlConnection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                Messages.ConnectionErrorException(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Тестовое соединение с БД
        /// </summary>
        /// <returns></returns>
        public bool TestConnection()
        {
            if(Open())
            {
                Close();
                return true;
            }
            return false;
        }
        #endregion
    }
}
