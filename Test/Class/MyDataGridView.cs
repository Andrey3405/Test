using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Class
{
    class MyDataGridView : Interface.IDataGridView
    {
        private DataGridView dataGridView;
        
        public event EventHandler<EventArgs> DataSourceChanging;

        public MyDataGridView(DataGridView _dataGridView)
        {
            dataGridView = _dataGridView;
            dataGridView.DataSourceChanged += OnDataSourceChanging;
        }

        public void SetColumnHeaderText(string columnName,string headerText)
        {
            if(dataGridView.Columns[columnName]!=null)
                dataGridView.Columns[columnName].HeaderText = headerText;
        }

        public void SetColumnVisible(string columnName, bool visible)
        {
            if (dataGridView.Columns[columnName] != null)
                dataGridView.Columns[columnName].Visible = visible;
        }

        public DataTable DataSource
        {
            get => (DataTable)dataGridView.DataSource;
            set => dataGridView.DataSource = value;
        }

        public void OnDataSourceChanging(object sender, EventArgs e)
        {
            DataSourceChanging?.Invoke(sender,e);
        }
    }
}
