using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.EmployeeCard.Presenter
{
    class EmployeeCardPresenter
    {
        View.IEmployeeCardView view;
        Class.EmployeeInfo employeeInfo;

        public EmployeeCardPresenter(View.IEmployeeCardView _view,
            Class.EmployeeInfo _employeeInfo)
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
            view.LbYear.Text = Class.Date.GetYear(employeeInfo.DateOfBirth).ToString();

            view.ShowDialog();
        }
    }
}
