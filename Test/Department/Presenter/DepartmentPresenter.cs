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
        private DataTable dtDepartments;

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
            view.BtnEmployeeEdit.Click += OnBtnEmployeeEditClick;
            view.BtnRefresh.Click += OnBtnRefreshClick;
            view.DGVEmployees.SelectionChanged += OnSelectionChanged;
        }

        #region Методы
        public Form ShowForm()
        {
            return (Form)view;
        }

        public void OnLoadForm(object sender, EventArgs e)
        {
            dtDepartments = connection.GetDepartments();
            CreateTree();
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            view.BtnEmployeeEdit.Enabled
                = (view.DGVEmployees.SelectedRow != null);
        }

        /// <summary>
        /// Создание дерева
        /// </summary>
        private void CreateTree()
        {
            for (int i = 0; i < dtDepartments.Rows.Count; i++)
            {
                if (String.IsNullOrEmpty(dtDepartments.Rows[i][3].ToString()))
                {
                    string key = dtDepartments.Rows[i][0].ToString();
                    string name = $"{dtDepartments.Rows[i][1].ToString()} ({dtDepartments.Rows[i][2].ToString()})";
                    TreeNode node = view.TVDepartment.AddNode(key, name);
                    node.Tag = key;
                    model.AddNode(dtDepartments, dtDepartments.Rows[i][0].ToString(), node);
                }
            }
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

        public void OnBtnEmployeeEditClick(object sender, EventArgs e)
        {
            if(view.DGVEmployees.SelectedRow!=null)
                OpenFmEmployeeEdit();
        }

        public void OnDataGridViewCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (view.DGVEmployees.SelectedRow != null)
                OpenFmEmployeeEdit();
        }

        private void OnBtnRefreshClick(object sender, EventArgs e)
        {
            dtDepartments = connection.GetDepartments();
            if (dtDepartments == null) return;
            Guid nodeID = view.TVDepartment.SelectedNodeID;
            int indexRow = view.DGVEmployees.SelectedRowIndex;

            view.TVDepartment.Clear();
            CreateTree();

            TreeNode node = view.TVDepartment.FindFirstNode(nodeID.ToString());
            if(node!=null)
            {
                view.TVDepartment.SelectedNode = node;
                view.DGVEmployees.SelectedRowIndex = indexRow;
            }
            //TreeNode tree = model.CreateTree(dtDepartments);
            //view.TVDepartment.AddNode(tree);
        }

        private void OpenFmEmployeeEdit()
        {
            
            int indexRow = view.DGVEmployees.SelectedRowIndex;
            int EmployeeID = view.DGVEmployees.GetEmployeeID(indexRow);
            Data.EmployeeInfo employeeInfo = connection.GetEmployeeByID(EmployeeID);

            //Если этого сотрудника нет в базе
            if (employeeInfo == null)
            {
                view.DGVEmployees.RemoveAt(indexRow);
                Class.Messages.NotFound();
                return;
            }

            //Обновить редактируему запись
            model.UpdateEmployeeInfo(view.DGVEmployees.SelectedRow, employeeInfo);

            IEmployeeCardView employeeCardView
                = new FmEmployeeCard();
            EmployeeCardPresenter employeeCardPresenter
                = new EmployeeCardPresenter(employeeCardView, employeeInfo);
            if (employeeCardPresenter.ShowDialog()
                == DialogResult.OK)
            {
                if (connection.UpdateEmployee(employeeInfo, view.TVDepartment.SelectedNodeID)
                    == Class.CommandStatus.NotFound)
                {
                    Class.Messages.NotFound();
                    view.DGVEmployees.RemoveAt(indexRow);
                }
                else if(connection.UpdateEmployee(employeeInfo, view.TVDepartment.SelectedNodeID)
                    == Class.CommandStatus.Updated)
                {
                    model.UpdateEmployeeInfo(view.DGVEmployees.SelectedRow, employeeInfo);
                }
            }
        }
        #endregion
    }
}
