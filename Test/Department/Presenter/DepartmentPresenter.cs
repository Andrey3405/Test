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
        }

        public Form ShowForm()
        {
            return (Form)view;
        }

        public void OnLoadForm(object sender, EventArgs e)
        {
            DataTable table = connection.GetDepartments();
            TreeNode tree = model.CreateTree(table);
            view.AddNode(tree);

            //for(int i=0;i<table.Rows.Count;i++)
            //{
            //    TreeNode node = null;
            //    if(String.IsNullOrEmpty(table.Rows[i][3]?.ToString()))
            //    {
            //        node = new TreeNode(table.Rows[i][1].ToString());
            //        node.Tag = table.Rows[i][0];
            //        view.AddNode(node);
            //    }
            //}
        }
    }
}
