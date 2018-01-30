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
        public Interface.ITreeView TVDepartment { get; }

        #region События
        public event EventHandler<EventArgs> LoadForm;
        public event EventHandler<TreeViewEventArgs> ChangingNode;
        #endregion

        #region Свойства
        

        #endregion

        #region Констуктор
        public FmDepartmentView()
        {
            InitializeComponent();
            DGVEmployees = new Class.MyDataGridView(dgvEmployee);
            TVDepartment = new Class.MyTreeView(tvDepartment);
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
        #endregion

        private void TVDepartment_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ChangingNode?.Invoke(sender, e);
        }
    }
}
