using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.EmployeeCard
{
    public partial class FmEmployeeCard : Form, View.IEmployeeCardView
    {
        /// <summary>
        /// Список обязательных к заполнению полей
        /// </summary>
        List<Interface.ITextBox> listTextBox;

        #region Свойства
        public Interface.ITextBox TxtSurname { get; }
        public Interface.ITextBox TxtName { get; }
        public Interface.ITextBox TxtPatronymic { get; }
        public Interface.ITextBox TxtSeries { get; }
        public Interface.ITextBox TxtNumber { get; }
        public Interface.ITextBox TxtPosition { get; }
        public Interface.IDataTimePicker DtpDateOfBirth { get; }
        public Interface.ILabel LbYear { get; }
        #endregion

        public FmEmployeeCard()
        {
            InitializeComponent();
            listTextBox = new List<Interface.ITextBox>();

            TxtSurname = new Class.MyTextBox(txtSurname,false,true);
            TxtName = new Class.MyTextBox(txtName, false, true);
            TxtPatronymic = new Class.MyTextBox(txtPatronymic, false, false);
            TxtSeries = new Class.MyTextBox(txtSeries, false, false);
            TxtNumber = new Class.MyTextBox(txtNumber, true, false);
            TxtPosition = new Class.MyTextBox(txtPosition, false, true);
            DtpDateOfBirth = new Class.MyDataTimePicker(dtpDateOfBirth);
            LbYear = new Class.MyLabel(lbEmployeeYear);

            listTextBox.Add(TxtSurname);
            listTextBox.Add(TxtName);
            listTextBox.Add(TxtPosition);
        }

        /// <summary>
        /// Все ли необходимые поля заполнены
        /// </summary>
        /// <returns>True - заполнены
        /// False - не заполнены</returns>
        public bool IsEmpty()
        {
            return listTextBox.Exists(item => item.Text.Length == 0);
        }
    }
}
