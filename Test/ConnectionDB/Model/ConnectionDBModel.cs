using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ConnectionDB.Model
{
    class ConnectionDBModel
    {
        /// <summary>
        /// Составить строку подключения к БД
        /// </summary>
        /// <param name="server">Наименование сервера</param>
        /// <param name="database">Наименование БД</param>
        /// <param name="timeout">Таймаут подключения к БД</param>
        /// <returns></returns>
        public string GetConnectionString(string server,string database,int timeout)
        {
            return  $"Server ={server};" +
                    $"Database={database};" +
                    $"Trusted_Connection = True;" +
                    $"Connection Timeout={timeout.ToString()}";
        }

        /// <summary>
        /// Проверка списка строк на пустоту
        /// </summary>
        /// <param name="text">Спосок строк</param>
        public bool StringIsEmpty(params string[] text)
        {
            for(int i=0;i<text.Length;i++)
            {
                if(String.IsNullOrEmpty(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
