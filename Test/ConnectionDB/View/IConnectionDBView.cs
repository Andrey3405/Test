using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.ConnectionDB.View
{
    interface IConnectionDBView: Interface.IFormMethods
    {
        //События
        event EventHandler<EventArgs> TestConnectionClick;
        event EventHandler<EventArgs> CancelClick;
        event EventHandler<EventArgs> OKClick;

        //Свойства
        Interface.ITextBox TxtServer { get; }
        Interface.ITextBox TxtDatabase { get; }
    }
}
