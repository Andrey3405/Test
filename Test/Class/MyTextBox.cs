using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Class
{
    class MyTextBox:Interface.ITextBox
    {
        private TextBox textBox;

        public MyTextBox(TextBox _textBox)
        {
            textBox = _textBox;
            textBox.TextChanged += OnTextChanged;
        }

        public string Text
        {
            get => textBox.Text;
        }

        public void OnTextChanged(object sender, EventArgs e)
        {
            textBox.BackColor = (textBox.TextLength > 0)
                ? SystemColors.Window : Color.Pink;
        }
    }
}
