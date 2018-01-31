using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.EmployeeCard.Presenter
{
    class EmployeeCardPresenter
    {
        View.IEmployeeCardView view;
        Data.EmployeeInfo employeeInfo;

        public EmployeeCardPresenter(View.IEmployeeCardView _view,
            Data.EmployeeInfo _employeeInfo)
        {
            view = _view;
            employeeInfo = _employeeInfo;

            view.TxtName.Text = employeeInfo.FirstName;
            view.TxtSurname.Text = employeeInfo.SurName;
            view.TxtPatronymic.Text = employeeInfo.Patronymic;
            view.TxtNumber.Text = employeeInfo.DocNumber;
            view.TxtSeries.Text = employeeInfo.DocSeries;
            view.TxtPosition.Text = employeeInfo.Position;
            view.DtpDateOfBirth.Value = employeeInfo.DateOfBirth;
            view.LbYear.Text
                = Class.Date.GetYear(employeeInfo.DateOfBirth).ToString();

            view.DtpDateOfBirth.ValueChanged += OnDateOfBirthValueChanged;
            view.BtnOk.Click += OnBtnOkClick;
            view.FormClosing += OnFormClose;
        }

        #region методы
        public DialogResult ShowDialog()
        {
            return view.ShowDialog();
        }

        public void OnDateOfBirthValueChanged(object sender, EventArgs e)
        {
            view.LbYear.Text
                = Class.Date.GetYear(view.DtpDateOfBirth.Value).ToString(); ;
        }

        public void OnBtnOkClick(object sender, EventArgs e)
        {
            //Если не все поля заполнены
            if (view.IsEmpty())
            {
                view.DialogResult = DialogResult.None;
                Class.Messages.DataIsEmpty();
            }
        }

        public void OnFormClose(object sender, FormClosingEventArgs e)
        {
            Data.EmployeeInfo lastInfo
                    = new Data.EmployeeInfo()
                    {
                        FirstName = view.TxtName.Text,
                        SurName = view.TxtSurname.Text,
                        Patronymic = view.TxtPatronymic.Text,
                        DateOfBirth = view.DtpDateOfBirth.Value.Date,
                        DocSeries = view.TxtSeries.Text,
                        DocNumber = view.TxtNumber.Text,
                        Position = view.TxtPosition.Text
                    };

            //Были ли изменены данные 
            bool isChangedValue = !employeeInfo.Equals(lastInfo);

            if (view.DialogResult
                == DialogResult.OK)
            {
                lastInfo.ID = employeeInfo.ID;
                employeeInfo.Copy(lastInfo);
                return;
            }
            else if (isChangedValue)
            {
                switch (Class.Messages.ChangedValue())
                {
                    case DialogResult.Yes:
                        //Если не все обязательные поля указаны
                        if (view.IsEmpty())
                        { 
                            Class.Messages.DataIsEmpty();
                            e.Cancel = true;
                        }
                        view.DialogResult = DialogResult.OK;
                        lastInfo.ID = employeeInfo.ID;
                        employeeInfo.Copy(lastInfo);
                        break;
                    case DialogResult.No:
                        return;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
        #endregion
    }
}
