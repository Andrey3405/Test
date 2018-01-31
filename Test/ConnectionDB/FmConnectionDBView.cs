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
        public Interface.ITextBox TxtServer { get; private set; }
        public Interface.ITextBox TxtDatabase { get; private set; }
        #endregion

        #region Конструктор
        public FmConnectionDBView()
        {
            InitializeComponent();
            TxtServer = new Tools.MyTextBox(txtServer,false,true);
            TxtDatabase = new Tools.MyTextBox(txtDataBase,false,true);
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
