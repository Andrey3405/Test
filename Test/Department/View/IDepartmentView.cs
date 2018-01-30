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

        TreeNode SelectedNode { get; set; }
        Guid SelectedNodeID { get; }
        Interface.IDataGridView DGVEmployees { get; }

        void AddNode(TreeNode _treeNode);
        void AddNode(string name);
        void RemoveNode(TreeNode _treeNode);
        void RemoveNode(int index);

        void Close();
    }
}
