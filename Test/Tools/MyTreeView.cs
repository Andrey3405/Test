using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Class
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
        public void AddNode(string name)
        {
            treeView.Nodes.Add(name);
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
        #endregion
    }
}
