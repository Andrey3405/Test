using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.ConnectionDB.Presenter
{
    class ConnectionDBPresenter
    {
        View.IConnectionDBView view;
        Model.ConnectionDBModel model;
        Class.Connection connection;

        public ConnectionDBPresenter(View.IConnectionDBView _view,
            Class.Connection _connection)
        {
            view = _view;
            model = new Model.ConnectionDBModel();

            //Подключение событий
            view.TestConnectionClick += OnTestConnectionClick;
            view.CancelClick += OnCancelClick;
            view.OKClick += OnOKClick;

            //Если не создан экземпляр
            connection = (_connection
                ?? new Class.Connection());
        }

        public DialogResult ShowDialog()
        {
            return view.ShowDialog();
        }

        private void OnTestConnectionClick(object sender, EventArgs e)
        {
            //Проверка данных на пустоту
            if (model.StringIsEmpty(view.ServerTextBox.Text,
                view.DatabaseTextBox.Text))
            {
                Class.Messages.DataIsEmpty();
                return;
            }

            string connectionString
                = model.GetConnectionString(view.ServerTextBox.Text,
                                            view.DatabaseTextBox.Text,
                                            5);
            
            //Если не указана строка подключение или устарела
            if (String.IsNullOrEmpty(connection.ConnectionString)
                || connection.ConnectionString != connectionString)
            {
                connection.ConnectionString = connectionString;
            }

            if (connection.TestConnection())
            {
                Class.Messages.TestConnection();
            }
        }

        private void OnOKClick(object sender, EventArgs e)
        {
            //Проверка данных на пустоту
            if(model.StringIsEmpty(view.ServerTextBox.Text,
                view.DatabaseTextBox.Text))
            {
                Class.Messages.DataIsEmpty();
                return;
            }

            string connectionString
                = model.GetConnectionString(view.ServerTextBox.Text,
                                            view.DatabaseTextBox.Text,
                                            10);

            //Если не указана строка подключение или устарела
            if (String.IsNullOrEmpty(connection.ConnectionString)
                || connection.ConnectionString != connectionString)
            {
                connection.ConnectionString = connectionString;
            }

            if (connection.TestConnection())
            {
                view.DialogResult = DialogResult.OK;
            }
            else
            {
                view.DialogResult = DialogResult.None;
            }
        }

        private void OnCancelClick(object sender, EventArgs e)
        {

        }
    }
}
