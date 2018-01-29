using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.ConnectionDB.View
{
    interface IConnectionDBView
    {
        //События
        event EventHandler<EventArgs> TestConnectionClick;
        event EventHandler<EventArgs> CancelClick;
        event EventHandler<EventArgs> OKClick;

        //Свойства
        Interface.ITextBox ServerTextBox { get; }
        Interface.ITextBox DatabaseTextBox { get; }

        //Методы
        DialogResult ShowDialog();
        DialogResult DialogResult { get; set; }
    }
}
