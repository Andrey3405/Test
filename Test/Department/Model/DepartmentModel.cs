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
        public void AddNode(DataTable table,
            string guid, TreeNode treeNode)
        {
            for(int i=0;i<table.Rows.Count;i++)
            {
                if(table.Rows[i][3].ToString()
                    ==guid)
                {
                    string key = table.Rows[i][0].ToString();
                    string name = $"{table.Rows[i][1].ToString()} ({table.Rows[i][2].ToString()})";
                    TreeNode node = treeNode.Nodes.Add(key, name);
                    node.Tag = key;
                    AddNode(table, key, node);
                }
            }
        }

        /// <summary>
        /// Обновить данные
        /// </summary>
        /// <param name="row">Строка которую необходимо обновить</param>
        /// <param name="employee">Информация о сотруднике</param>
        public void UpdateEmployeeInfo(DataGridViewRow row, Data.EmployeeInfo employee)
        {
            if (row == null || employee == null) return;
            row.Cells["Employee"].Value = $"{employee.SurName} {employee.FirstName} {employee.Patronymic}";
            row.Cells["DateOfBirth"].Value = employee.DateOfBirth;
            row.Cells["Age"].Value = Class.Date.GetYear(employee.DateOfBirth);
            row.Cells["Document"].Value = $"{employee.DocSeries} {employee.DocNumber}";
            row.Cells["Position"].Value = employee.Position;
        }
    }
}
