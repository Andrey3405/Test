using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Class
{
    class MyDataTimePicker:Interface.IDataTimePicker
    {
        DateTimePicker dateTimePicker;

        /// <summary>
        /// Значение в DateTimePicker
        /// </summary>
        public DateTime Value
        {
            get => dateTimePicker.Value;
            set
            {
                if (value < dateTimePicker.MinDate)
                    dateTimePicker.Value = dateTimePicker.MinDate;
                else if (value > dateTimePicker.MaxDate)
                     dateTimePicker.Value = dateTimePicker.MaxDate;
                else
                {
                    dateTimePicker.Value = value;
                }

            }
        }

        public MyDataTimePicker(DateTimePicker _dateTimePicker)
        {
            dateTimePicker = _dateTimePicker;
        }


    }
}
