using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Interface
{
    public interface IButton
    {
        event EventHandler<EventArgs> Click;

        bool Visible { get; set; }
        bool Enabled { get; set; }
    }
}
