using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Class
{
    enum CommandStatus
    {
        NotFound = 0, 
        Updated = 1,
        Inserted = 2,
        Deleted = 3,
        InvalidData =4,
        Error = 5
    }

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
        private SqlCommand SqlEmployeesByDepartmentID()
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

        /// <summary>
        /// Получить запрос возвращающий информацию о конкретном сотруднике
        /// </summary>
        private SqlCommand SqlEmployeeByID()
        {
            string sqlString = String.Format("Select FirstName {0}" +
                   ",SurName {0}" +
                   ",Patronymic {0}" +
                   ",DateOfBirth {0}" +
                   ",DocSeries {0}" +
                   ",DocNumber {0}" +
                   ",Position {0}" +
                   "FROM Empoyee {0} " +
                   "where Empoyee.ID = @EmployeeID", Environment.NewLine);
            return new SqlCommand(sqlString, sqlConnection);
        }
        #endregion

        /// <summary>
        /// Обновить данные о сотруднике
        /// </summary>
        private SqlCommand SqlEmployeeUpdate()
        {
            string sqlString = String.Format("Update Empoyee set {0}" +
                "FirstName =@FirstName {0}" +
                ",SurName = @SurName {0}" +
                ",Patronymic =@Patronymic {0}" +
                ",DateOfBirth =@DateOfBirth {0}" +
                ",DocSeries = @DocSeries {0}" +
                ",DocNumber = @DocNumber {0}" +
                ",Position = @Position {0}"+
                ",DepartmentID = @DepartmentID {0}" +
                "where ID = @ID",Environment.NewLine);
            return new SqlCommand(sqlString, sqlConnection);
        }

        #region Получить данные

        public CommandStatus UpdateEmployee(Data.EmployeeInfo employeeInfo,
            Guid DepartmentID)
        {
            int countUpdated = 0;
            if (employeeInfo == null) return CommandStatus.InvalidData;
            if(Open())
            {
                SqlCommand sqlCommand = SqlEmployeeUpdate();
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = employeeInfo.FirstName;
                sqlCommand.Parameters.Add("@SurName", SqlDbType.NVarChar).Value = employeeInfo.SurName;
                sqlCommand.Parameters.Add("@Patronymic", SqlDbType.NVarChar).Value 
                    = (String.IsNullOrEmpty(employeeInfo.Patronymic)) ? null: employeeInfo.Patronymic;
                sqlCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = employeeInfo.DateOfBirth;
                sqlCommand.Parameters.Add("@DocSeries", SqlDbType.NVarChar).Value
                    = (String.IsNullOrEmpty(employeeInfo.DocSeries)) ? null : employeeInfo.DocSeries;
                sqlCommand.Parameters.Add("@DocNumber", SqlDbType.NVarChar).Value
                    = (String.IsNullOrEmpty(employeeInfo.DocNumber)) ? null : employeeInfo.DocNumber;
                sqlCommand.Parameters.Add("@Position", SqlDbType.NVarChar).Value = employeeInfo.Position;
                sqlCommand.Parameters.Add("@DepartmentID", SqlDbType.UniqueIdentifier).Value = DepartmentID;
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = employeeInfo.ID;

                SqlTransaction transaction = sqlConnection.BeginTransaction("UpdateEmployee");
                sqlCommand.Transaction = transaction;
                try
                {
                    countUpdated =sqlCommand.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch(Exception ex)
                {
                    Messages.ConnectionErrorException(ex.Message);
                    transaction.Rollback();
                    Close();
                    return CommandStatus.Error;
                }
                Close();
            }
            if (countUpdated == 0)
                return CommandStatus.NotFound;
            else return CommandStatus.Updated;
        }

        /// <summary>
        /// Получить информацию о сотруднике
        /// </summary>
        /// <param name="ID">Идентификатор сотрудника</param>
        public Data.EmployeeInfo GetEmployeeByID(int ID)
        {
            Data.EmployeeInfo employee = null;
            if(Open())
            {
                SqlCommand sqlCommand = SqlEmployeeByID();
                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = ID;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if(sqlDataReader.HasRows)
                {
                    employee = new Data.EmployeeInfo();
                    sqlDataReader.Read();
                    employee.ID = ID;
                    employee.FirstName   = sqlDataReader.GetString(0);
                    employee.SurName = sqlDataReader.GetString(1);
                    employee.Patronymic
                        = (sqlDataReader.GetValue(2) == DBNull.Value) ? String.Empty: sqlDataReader.GetString(2);
                    employee.DateOfBirth = sqlDataReader.GetDateTime(3);
                    employee.DocSeries 
                        = (sqlDataReader.GetValue(4) == DBNull.Value)?String.Empty: sqlDataReader.GetString(4);
                    employee.DocNumber  
                        = (sqlDataReader.GetValue(5) == DBNull.Value)?String.Empty: sqlDataReader.GetString(5);
                    employee.Position    = sqlDataReader.GetString(6);
                }
                Close();
            }
            return employee;
        }

        /// <summary>
        /// Получить информацию о сотрудниках находящихся в отделе
        /// </summary>
        /// <param name="departmentID">Идентификатор отдела</param>
        public DataTable GetEmployeesByDepartmentID(Guid departmentID)
        {
            DataTable returnValue = new DataTable();
            if(Open())
            {
                SqlCommand sqlCommand = SqlEmployeesByDepartmentID();
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
                        row["Age"] = Date.GetYear(sqlDataReader.GetDateTime(4));
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
                if (sqlConnection.State
                    == ConnectionState.Open) Close();
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
                if(sqlConnection.State
                    !=ConnectionState.Closed)
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
