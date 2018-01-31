using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Interface
{
    public interface IDataGridView
    {
        event EventHandler<EventArgs> DataSourceChanged;
        event EventHandler<DataGridViewCellMouseEventArgs> DataGridViewCellMouseDoubleClick;
        event EventHandler<EventArgs> SelectionChanged;

        int SelectedRowIndex { get; set; }
        DataGridViewRow SelectedRow{ get; }

        void SetColumnHeaderText(string nameColumn, string headerText);
        void SetColumnVisible(string nameColumns, bool visible);
        void RemoveAt(int index);
        int GetEmployeeID(int RowID);
        DataTable DataSource { get; set; }
    }
}
