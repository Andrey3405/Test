using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.ConnectionDB
{
    public partial class FmConnectionDBView : Form, View.IConnectionDBView
    {
        #region События
        public event EventHandler<EventArgs> TestConnectionClick;
        public event EventHandler<EventArgs> CancelClick;
        public event EventHandler<EventArgs> OKClick;
        #endregion

        #region Свойства
        public Interface.ITextBox ServerTextBox { get; private set; }
        public Interface.ITextBox DatabaseTextBox { get; private set; }
        #endregion

        #region Конструктор
        public FmConnectionDBView()
        {
            InitializeComponent();
            ServerTextBox = new Class.MyTextBox(txtServer);
            DatabaseTextBox = new Class.MyTextBox(txtDataBase);
        }
        #endregion

        #region Методы
        private void BtnTestConnection_Click(object sender, EventArgs e)
        {
            TestConnectionClick?.Invoke(sender, e);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CancelClick?.Invoke(sender, e);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            OKClick?.Invoke(sender, e);
        }
        #endregion
    }
}
