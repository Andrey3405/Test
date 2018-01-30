using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Class
{
    public static class Date
    {
        /// <summary>
        /// Получить возраст относительно настоящей даты
        /// </summary>
        /// <param name="dateTime">Дата от которой ведется отсчет</param>
        /// <returns>Года</returns>
        public static int GetYear(DateTime dateTime)
        {
            int year = DateTime.Now.Year - dateTime.Year;
            if (DateTime.Now.Month < dateTime.Month
                || (DateTime.Now.Month==dateTime.Month 
                    && DateTime.Now.Day< dateTime.Day))year--;
            return year;
        }
    }
}
