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
        private bool compulsory;

        /// <summary>
        /// Является ли поле обязательным к заполнению
        /// </summary>
        public bool Compulsory
        {
            get => compulsory;
            private set => compulsory = value;                
        }

        public MyTextBox(TextBox _textBox,bool _isDigit ,bool _compilsory)
        {
            textBox = _textBox;
            compulsory = _compilsory;

            if(compulsory)
                textBox.TextChanged += OnTextChanged;

            if (_isDigit)
                textBox.KeyPress += OnKeyPress;
        }

        public string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        public void OnTextChanged(object sender, EventArgs e)
        {
            textBox.BackColor = (textBox.TextLength > 0)
                ? SystemColors.Window : Color.Pink;
        }

        public void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }

        }
    }
}
