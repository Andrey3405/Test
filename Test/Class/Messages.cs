using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Class
{
    static class Messages
    {
        /// <summary>
        /// Ошибка соединения с БД
        /// </summary>
        /// <param name="message">Системное сообщение</param>
        public static void ConnectionErrorException(string message)
        {
            MessageBox.Show($"Во время обращения к БД возникла ошибка:\n{message}"
                ,"Ошибка соединения с БД"
                ,MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// Сообщение успешной проверки соединения
        /// </summary>
        public static void TestConnection()
        {
            MessageBox.Show($"Соединения с БД установленно"
                ,"Проверка соединения"
                ,MessageBoxButtons.OK
                ,MessageBoxIcon.Information);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static void DataIsEmpty()
        {
            MessageBox.Show($"Не все необходимые поля указаны"
                , "Обязательные поля"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Warning);
        }
    }
}
