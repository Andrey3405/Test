using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Department.Model
{
    class DepartmentModel
    {
        /// <summary>
        /// Добавить узел
        /// </summary>
        /// <param name="table">Таблица с данными</param>
        /// <param name="guid">Идентификатор родителя</param>
        /// <param name="treeNode">Ссылка на родитель</param>
        private void AddNode(DataTable table,
            string guid, TreeNode treeNode)
        {
            for(int i=0;i<table.Rows.Count;i++)
            {
                if(table.Rows[i][3].ToString()
                    ==guid)
                {
                    TreeNode node = new TreeNode($"{table.Rows[i][1].ToString()} ({table.Rows[i][2].ToString()})");
                    node.Tag = table.Rows[i][0];
                    treeNode.Nodes.Add(node);
                    AddNode(table, table.Rows[i][0].ToString(), node);
                }
            }
        }

        /// <summary>
        /// Создание дерева
        /// </summary>
        /// <param name="table">Таблица с данными</param>
        /// <returns>Дерево</returns>
        public TreeNode CreateTree(DataTable table)
        {
            TreeNode returnValue = null;
            for(int i=0;i<table.Rows.Count;i++)
            {
                if(String.IsNullOrEmpty(table.Rows[i][3].ToString()))
                {
                    returnValue = new TreeNode($"{table.Rows[i][1].ToString()} ({table.Rows[i][2].ToString()})");
                    returnValue.Tag = table.Rows[i][0];
                    AddNode(table, table.Rows[i][0].ToString(), returnValue);
                }
            }
            return returnValue;
        }
    }
}
