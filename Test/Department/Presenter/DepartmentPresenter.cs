using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.ConnectionDB.Presenter;

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

            view.DGVEmployees.DataSourceChanging += OnDataSourceChangeing;
        }

        public Form ShowForm()
        {
            return (Form)view;
        }

        public void OnLoadForm(object sender, EventArgs e)
        {
            dtEmployees = connection.GetDepartments();
            TreeNode tree = model.CreateTree(dtEmployees);
            view.AddNode(tree);
        }

        public void OnChangingNode(object sender, TreeViewEventArgs e)
        {
            view.DGVEmployees.DataSource =
                connection.GetEmployeeByDepartmentID(view.SelectedNodeID);            
        }

        public void OnDataSourceChangeing(object sender, EventArgs e)
        {
            view.DGVEmployees.SetColumnVisible("ID", false);
            view.DGVEmployees.SetColumnHeaderText("Employee", "Сотрудник");
            view.DGVEmployees.SetColumnHeaderText("DateOfBirth", "Дата рождения");
            view.DGVEmployees.SetColumnHeaderText("Age", "Возраст");
            view.DGVEmployees.SetColumnHeaderText("Document", "Документ");
            view.DGVEmployees.SetColumnHeaderText("Position", "Должность");
        }
    }
}
