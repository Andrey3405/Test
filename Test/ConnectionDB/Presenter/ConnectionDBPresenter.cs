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
            view.OKClick += OnOKClick;

            //Если не создан экземпляр
            connection = (_connection
                ?? new Class.Connection());
        }

        #region Методы
        public DialogResult ShowDialog()
        {
            return view.ShowDialog();
        }

        private void OnTestConnectionClick(object sender, EventArgs e)
        {
            //Проверка данных на пустоту
            if (model.StringIsEmpty(view.TxtServer.Text,
                view.TxtDatabase.Text))
            {
                Class.Messages.DataIsEmpty();
                return;
            }

            string connectionString
                = model.GetConnectionString(view.TxtServer.Text,
                                            view.TxtDatabase.Text,
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
            if(model.StringIsEmpty(view.TxtServer.Text,
                view.TxtDatabase.Text))
            {
                Class.Messages.DataIsEmpty();
                return;
            }

            string connectionString
                = model.GetConnectionString(view.TxtServer.Text,
                                            view.TxtDatabase.Text,
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
        #endregion
    }
}
