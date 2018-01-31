using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Interface
{
    public interface IDataTimePicker
    {
        event EventHandler<EventArgs> ValueChanged;

        DateTime Value { get; set; }
    }
}
