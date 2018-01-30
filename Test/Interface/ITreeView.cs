using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Interface
{
    public interface ITreeView
    {
        TreeNode SelectedNode { get; set; }
        Guid SelectedNodeID { get; }

        void AddNode(TreeNode _treeNode);
        void AddNode(string name);
        void RemoveNode(TreeNode _treeNode);
        void RemoveNode(int index);
    }
}
