using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.EmployeeCard.View
{
    interface IEmployeeCardView: Class.IFormMethods
    {
        Interface.ITextBox TxtSurname { get; }
        Interface.ITextBox TxtName { get; }
        Interface.ITextBox TxtPatronymic { get; }
        Interface.ITextBox TxtSeries { get; }
        Interface.ITextBox TxtNumber { get; }
        Interface.ITextBox TxtPosition { get; }
        Interface.IDataTimePicker DtpDateOfBirth { get; }
        Interface.ILabel LbYear { get; }
    }
}
