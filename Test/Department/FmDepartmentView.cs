using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Department.View;
using Test.Interface;

namespace Test.Department
{
    public partial class FmDepartmentView : Form, View.IDepartmentView
    {
        public Interface.IDataGridView DGVEmployees { get; }

        #region События
        public event EventHandler<EventArgs> LoadForm;
        public event EventHandler<TreeViewEventArgs> ChangingNode;
        #endregion

        #region Свойства
        /// <summary>
        /// Получает или возвращает выбранный узел
        /// </summary>
        public TreeNode SelectedNode { get => tvDepartment.SelectedNode;
                                       set => tvDepartment.SelectedNode = value; }

        /// <summary>
        /// Получить GUID выбранного узла
        /// </summary>
        public Guid SelectedNodeID
        {
            get
            {
                if (tvDepartment.SelectedNode
                    != null)
                {
                    return Guid.Parse(tvDepartment.SelectedNode.Tag.ToString());
                }
                return Guid.Empty;
            }
        }

        #endregion

        #region Констуктор
        public FmDepartmentView()
        {
            InitializeComponent();
            DGVEmployees = new Class.MyDataGridView(dgvEmployee);
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

        private void TVDepartment_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ChangingNode?.Invoke(sender, e);
        }
    }
}
