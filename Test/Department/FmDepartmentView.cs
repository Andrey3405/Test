using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Department
{
    public partial class FmDepartmentView : Form, View.IDepartmentView
    {
        #region События
        public event EventHandler<EventArgs> LoadForm;
        #endregion

        #region Констуктор
        public FmDepartmentView()
        {
            InitializeComponent();
        }
        #endregion


        #region Методы
        public new void Close()
        {
            base.Close();
        }

        private void FmDepartmentView_Load(object sender, EventArgs e)
        {
            LoadForm?.Invoke(sender, e);
        }

        /// <summary>
        /// Добавить узел
        /// </summary>
        /// <param name="_treeNode">узел</param>
        public void AddNode(TreeNode _treeNode)
        {
            tvDepartment.Nodes.Add(_treeNode);
        }

        public void AddNode(string name)
        {
            tvDepartment.Nodes.Add(name);
        }

        /// <summary>
        /// Удалить узел
        /// </summary>
        /// <param name="_treeNode">Узел</param>
        public void RemoveNode(TreeNode _treeNode)
        {
            tvDepartment.Nodes.Remove(_treeNode);
        }

        /// <summary>
        /// Удалить узел
        /// </summary>
        /// <param name="index">Индекс узла</param>
        public void RemoveNode(int index)
        {
            tvDepartment.Nodes.RemoveAt(index);
        }
        #endregion
    }
}
