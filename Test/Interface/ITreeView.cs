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
        TreeNode AddNode(string key, string name);
        void RemoveNode(TreeNode _treeNode);
        void RemoveNode(int index);
        void Clear();
        TreeNode FindFirstNode(string key);
    }
}
