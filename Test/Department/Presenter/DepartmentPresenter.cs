using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.ConnectionDB.Presenter;
using Test.EmployeeCard;
using Test.EmployeeCard.Presenter;
using Test.EmployeeCard.View;

namespace Test.Department.Presenter
{
    class DepartmentPresenter
    {
        private View.IDepartmentView view;
        private Model.DepartmentModel model;
        private Class.Connection connection;
        private DataTable dtEmployees;

        public DepartmentPresenter()
        {
            model = new Model.DepartmentModel();

            connection = new Class.Connection();
            ConnectionDB.FmConnectionDBView fmConnectionDBView 
                = new ConnectionDB.FmConnectionDBView();
            ConnectionDBPresenter connectionDBPresenter
                = new ConnectionDBPresenter(fmConnectionDBView, connection);            
            
            //Проверка на подключение к БД
            if (connectionDBPresenter.ShowDialog()
                ==DialogResult.OK)
            {
                view = new FmDepartmentView();
            }
            else
            {
                view = null;
                return;
            }

            //Привязка событий
            view.LoadForm += OnLoadForm;
            view.ChangingNode += OnChangingNode;
            view.DGVEmployees.DataSourceChanged += OnDataSourceChangeing;
            view.DGVEmployees.DataGridViewCellMouseDoubleClick += OnDataGridViewCellMouseDoubleClick;
        }

        public Form ShowForm()
        {
            return (Form)view;
        }

        public void OnLoadForm(object sender, EventArgs e)
        {
            dtEmployees = connection.GetDepartments();
            TreeNode tree = model.CreateTree(dtEmployees);
            view.TVDepartment.AddNode(tree);
        }

        public void OnChangingNode(object sender, TreeViewEventArgs e)
        {
            view.DGVEmployees.DataSource =
                connection.GetEmployeesByDepartmentID(view.TVDepartment.SelectedNodeID);            
        }

        public void OnDataSourceChangeing(object sender, EventArgs e)
        {
            view.DGVEmployees.SetColumnVisible   ("ID", false);
            view.DGVEmployees.SetColumnHeaderText("Employee", "Сотрудник");
            view.DGVEmployees.SetColumnHeaderText("DateOfBirth", "Дата рождения");
            view.DGVEmployees.SetColumnHeaderText("Age", "Возраст");
            view.DGVEmployees.SetColumnHeaderText("Document", "Документ");
            view.DGVEmployees.SetColumnHeaderText("Position", "Должность");
        }

        public void OnDataGridViewCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexRow = view.DGVEmployees.SelectedRowIndex;
            int EmployeeID = view.DGVEmployees.GetEmployeeID(indexRow);
            Class.EmployeeInfo employeeInfo = connection.GetEmployeeByID(EmployeeID);

            //Если этого сотрудника нет в базе
            if (employeeInfo == null)
            {
                view.DGVEmployees.RemoveAt(indexRow);
                return;
            }

            //Обновить редактируему запись
            model.UpdateEmployeeInfo(view.DGVEmployees.SelectedRow, employeeInfo);

            IEmployeeCardView employeeCardView 
                = new FmEmployeeCard();
            EmployeeCardPresenter employeeCardPresenter
                = new EmployeeCardPresenter(employeeCardView,employeeInfo);
            
        }
    }
}
