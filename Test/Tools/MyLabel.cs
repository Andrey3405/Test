using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Test.Class
{
    class MyLabel:Interface.ILabel
    {
        private Label label;

        public string Text
        {
            get => label.Text;
            set => label.Text = value;
        }

        public MyLabel(Label _label)
        {
            label = _label;
        }
    }
}
