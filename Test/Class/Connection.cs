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

        #region Свойства
        /// <summary>
        /// Строка соединения
        /// </summary>
        public string ConnectionString
        {
            set => sqlConnection.ConnectionString = value;
            get => sqlConnection.ConnectionString;
        }
        #endregion

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

 

        #region Методы

        #region SQL

        /// <summary>
        ///  Получить запрос для получения данных об отделах
        /// </summary>
        private SqlCommand SQLDepartments()
        {
            string sqlString = String.Format("Select ID {0} " +
                ",Name {0}" +
                ",Code {0}" +
                ",ParentDepartmentID {0}" +
                "from Department", Environment.NewLine );
            return new SqlCommand(sqlString, sqlConnection);
        }

        /// <summary>
        /// Получить запрос возвращающий выборку сотрудников по конкретному отделу
        /// </summary>
        private SqlCommand SqlEmployeeByDepartmentID()
        {
            string sqlString = String.Format("Select Cast(ID as int) as ID {0}" +
                ",FirstName {0}" +
                ",SurName {0}" +
                ",Patronymic {0}" +
                ",DateOfBirth {0}" +
                ",DocSeries {0}" +
                ",DocNumber {0}" +
                ",Position {0}" +
                "FROM Empoyee {0}" +
                "where DepartmentID = @DepartmentID", Environment.NewLine);
            return new SqlCommand(sqlString, sqlConnection);
        }

        #endregion

        #region Получить данные
        public DataTable GetEmployeeByDepartmentID(Guid departmentID)
        {
            DataTable returnValue = new DataTable();
            if(Open())
            {
                SqlCommand sqlCommand = SqlEmployeeByDepartmentID();
                sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.UniqueIdentifier).Value = departmentID;

                returnValue.Columns.Add("ID", typeof(int));
                returnValue.Columns.Add("Employee", typeof(string));
                returnValue.Columns.Add("DateOfBirth", typeof(DateTime));
                returnValue.Columns.Add("Age", typeof(int));
                returnValue.Columns.Add("Document", typeof(string));
                returnValue.Columns.Add("Position", typeof(string));

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        DataRow row = returnValue.NewRow();
                        row["ID"] = sqlDataReader.GetInt32(0);
                        row["Employee"] = String.Format("{0} {1} {2}",
                            sqlDataReader?.GetValue(2),
                            sqlDataReader?.GetValue(1),
                            sqlDataReader?.GetValue(3));
                        row["DateOfBirth"] = sqlDataReader.GetDateTime(4);
                        row["Age"] = Class.Date.GetYear(sqlDataReader.GetDateTime(4));
                        row["Document"] = String.Format("{0} {1}",
                            sqlDataReader.GetString(5),
                            sqlDataReader.GetString(6));
                        row["Position"] = sqlDataReader.GetString(7);
                        returnValue.Rows.Add(row);
                    }
                }
                Close();
            }
            return returnValue;
        }

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
                Close();
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
