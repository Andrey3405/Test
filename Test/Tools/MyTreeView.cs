using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Tools
{
    class MyTreeView:Interface.ITreeView
    {
        private TreeView treeView;

        #region Свойства
        /// <summary>
        /// Получает или возвращает выбранный узел
        /// </summary>
        public TreeNode SelectedNode
        {
            get => treeView.SelectedNode;
            set => treeView.SelectedNode = value;
        }

        /// <summary>
        /// Получить GUID выбранного узла
        /// </summary>
        public Guid SelectedNodeID
        {
            get
            {
                if (treeView.SelectedNode
                    != null)
                {
                    return Guid.Parse(treeView.SelectedNode.Tag.ToString());
                }
                return Guid.Empty;
            }
        }
        #endregion

        public MyTreeView(TreeView _treeView)
        {
            treeView = _treeView;
        }

        #region Методы
        /// <summary>
        /// Добавить узел
        /// </summary>
        /// <param name="_treeNode">Узел</param>
        public void AddNode(TreeNode _treeNode)
        {
            treeView.Nodes.Add(_treeNode);
        }

        /// <summary>
        /// Добавить узел
        /// </summary>
        /// <param name="_treeNode">Название узла</param>
        public TreeNode AddNode(string key, string name)
        {
            return treeView.Nodes.Add(key,name);
        }

        /// <summary>
        /// Удалить узел
        /// </summary>
        /// <param name="_treeNode">Узел</param>
        public void RemoveNode(TreeNode _treeNode)
        {
            treeView.Nodes.Remove(_treeNode);
        }

        /// <summary>
        /// Удалить узел
        /// </summary>
        /// <param name="index">Индекс узла</param>
        public void RemoveNode(int index)
        {
            treeView.Nodes.RemoveAt(index);
        }

        /// <summary>
        /// Удалить все узлы в дереве
        /// </summary>
        public void Clear()
        {
            treeView.Nodes.Clear();
        }

        /// <summary>
        /// Получить первые узел дерева удовлетворящего условиям
        /// </summary>
        public TreeNode FindFirstNode(string key)
        {
            TreeNode treeNode = null;
            TreeNode[] nodes = treeView.Nodes.Find(key, true);
            if(nodes.Length>0)
            {
                treeNode = nodes[0];
            }
            return treeNode;
        }
        #endregion
    }
}
