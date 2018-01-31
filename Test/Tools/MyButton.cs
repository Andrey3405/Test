using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Tools
{
    class MyButton : Interface.IButton
    {
        private Button button;

        public event EventHandler<EventArgs> Click;

        public bool Visible { get => button.Visible; set => button.Visible = value; }
        public bool Enabled { get => button.Enabled; set => button.Enabled = value; }

        public MyButton(Button _button)
        {
            button = _button;
            button.Click += OnClick;
        }

        public void OnClick(object sender, EventArgs e)
        {
            Click?.Invoke(sender, e);
        }
    }
}
