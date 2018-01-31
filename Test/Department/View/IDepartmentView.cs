using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Department.View
{
    interface IDepartmentView
    {
        event EventHandler<EventArgs> LoadForm;
        event EventHandler<TreeViewEventArgs> ChangingNode;

        Interface.IDataGridView DGVEmployees { get; }
        Interface.ITreeView TVDepartment { get; }
        Interface.IButton BtnEmployeeEdit { get; }
        Interface.IButton BtnRefresh { get; }

        void Close();
    }
}
