using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Tools
{
    class MyToolStripButton : Interface.IButton
    {
        private ToolStripButton toolStripButton;

        public event EventHandler<EventArgs> Click;

        public bool Visible { get => toolStripButton.Visible; set => toolStripButton.Visible = value; }
        public bool Enabled { get => toolStripButton.Enabled; set => toolStripButton.Enabled = value; }

        public MyToolStripButton(ToolStripButton _toolStripButton)
        {
            toolStripButton = _toolStripButton;
            toolStripButton.Click += OnClick;
        }

        public void OnClick(object sender, EventArgs e)
        {
            Click?.Invoke(sender, e);
        }
    }
}
