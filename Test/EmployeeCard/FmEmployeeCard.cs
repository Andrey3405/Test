using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.EmployeeCard.View;

namespace Test.EmployeeCard
{
    public partial class FmEmployeeCard : Form, View.IEmployeeCardView
    {
        /// <summary>
        /// Список обязательных к заполнению полей
        /// </summary>
        List<Interface.ITextBox> listTextBox;

        public new event EventHandler<FormClosingEventArgs> FormClosing;

        #region Свойства
        public Interface.ITextBox TxtSurname { get; }
        public Interface.ITextBox TxtName { get; }
        public Interface.ITextBox TxtPatronymic { get; }
        public Interface.ITextBox TxtSeries { get; }
        public Interface.ITextBox TxtNumber { get; }
        public Interface.ITextBox TxtPosition { get; }
        public Interface.IDataTimePicker DtpDateOfBirth { get; }
        public Interface.ILabel LbYear { get; }
        public Interface.IButton BtnOk { get; }
        public Interface.IButton BtnCancel { get; }
        #endregion

        public FmEmployeeCard()
        {
            InitializeComponent();
            listTextBox = new List<Interface.ITextBox>();

            TxtSurname = new Tools.MyTextBox(txtSurname,false,true);
            TxtName = new Tools.MyTextBox(txtName, false, true);
            TxtPatronymic = new Tools.MyTextBox(txtPatronymic, false, false);
            TxtSeries = new Tools.MyTextBox(txtSeries, false, false);
            TxtNumber = new Tools.MyTextBox(txtNumber, true, false);
            TxtPosition = new Tools.MyTextBox(txtPosition, false, true);
            DtpDateOfBirth = new Tools.MyDataTimePicker(dtpDateOfBirth);
            LbYear = new Tools.MyLabel(lbEmployeeYear);
            BtnOk = new Tools.MyButton(btnOK);
            BtnCancel = new Tools.MyButton(btnCancel);

            base.FormClosing += FmEmployeeCard_FormClosing;

            listTextBox.Add(TxtSurname);
            listTextBox.Add(TxtName);
            listTextBox.Add(TxtPosition);
        }

        #region Методы
        /// <summary> 
        /// Все ли необходимые поля заполнены
        /// </summary>
        /// <returns>True - заполнены
        /// False - не заполнены</returns>
        public bool IsEmpty()
        {
            return listTextBox.Exists(item => item.Text.Length == 0);
        }

        private void FmEmployeeCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosing.Invoke(sender, e);
        }
        #endregion
    }
}
