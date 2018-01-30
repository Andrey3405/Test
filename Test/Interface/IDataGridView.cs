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
        event EventHandler<EventArgs> DataSourceChanging;

        void SetColumnHeaderText(string nameColumn, string headerText);
        void SetColumnVisible(string nameColumns, bool visible);
        DataTable DataSource { get; set; }
    }
}
