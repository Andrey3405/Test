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
            MessageBox.Show($"Во время обращения к БД возникла ошибка!\n{message}"
                ,"Ошибка соединения с БД"
                ,MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// Сообщение успешной проверки соединения
        /// </summary>
        public static void TestConnection()
        {
            MessageBox.Show($"Соединения с БД установленно."
                ,"Проверка соединения"
                ,MessageBoxButtons.OK
                ,MessageBoxIcon.Information);
        }

        /// <summary>
        /// Сообщение об отсутствие данных в обязательных для заполнения полях
        /// </summary>
        public static void DataIsEmpty()
        {
            MessageBox.Show($"Не все обязательные поля указаны!"
                , "Обязательные поля"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Сообщение о действие над несохраненными данными
        /// </summary>
        public static DialogResult ChangedValue()
        {
            return MessageBox.Show($"Данные были изменены. Сохранить изменения?"
                , "Несохраненные данные"
                , MessageBoxButtons.YesNoCancel
                , MessageBoxIcon.Question);
        }

        /// <summary>
        /// Сообщение что запись не найдена
        /// </summary>
        public static void NotFound()
        {
            MessageBox.Show("Данная запись не найдена. " +
                "Возможно она была удалена другим пользователем."
                , "Запись не найдена"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }
    }
}
