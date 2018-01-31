using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Tools
{
    class MyDataGridView : Interface.IDataGridView
    {
        private DataGridView dataGridView;

        public event EventHandler<EventArgs> SelectionChanged;
        public event EventHandler<EventArgs> DataSourceChanged;
        public event EventHandler<DataGridViewCellMouseEventArgs> DataGridViewCellMouseDoubleClick;

        #region
        /// <summary>
        /// Индекс выделенной строки
        /// </summary>
        public int SelectedRowIndex
        {
            get
            {
                if (dataGridView.SelectedCells.Count == 0)
                    return -1;
                else
                {
                    return dataGridView.SelectedCells[0].RowIndex;
                }
            }
            set
            {
                if (value >= dataGridView.Rows.Count) return;
                else
                {
                    dataGridView.ClearSelection();
                    dataGridView.Rows[value].Selected = true;
                }
            }
        }

        /// <summary>
        /// Получить выделенную строку DataGridView
        /// </summary>
        public DataGridViewRow SelectedRow
        {
            get
            {
                if (dataGridView.SelectedCells.Count == 0)
                    return null;
                else
                {
                    return dataGridView.SelectedCells[0].OwningRow;
                }
            }
        }

        public DataTable DataSource
        {
            get => (DataTable)dataGridView.DataSource;
            set => dataGridView.DataSource = value;
        }
        #endregion

        public MyDataGridView(DataGridView _dataGridView)
        {
            dataGridView = _dataGridView;
            dataGridView.DataSourceChanged += OnDataSourceChanged;
            dataGridView.CellMouseDoubleClick += OnDataGridViewCellMouseDoubleClick;
            dataGridView.SelectionChanged += OnSelectionChanged;
        }

        #region Методы
        public void SetColumnHeaderText(string columnName,string headerText)
        {
            if(dataGridView.Columns[columnName]!=null)
                dataGridView.Columns[columnName].HeaderText = headerText;
        }

        public void SetColumnVisible(string columnName, bool visible)
        {
            if (dataGridView.Columns[columnName] != null)
                dataGridView.Columns[columnName].Visible = visible;
        }        

        public void OnDataSourceChanged(object sender, EventArgs e)
        {
            DataSourceChanged?.Invoke(sender,e);
        }

        public void OnDataGridViewCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellMouseDoubleClick?.Invoke(sender,e);
        }

        public void OnSelectionChanged(object sender,EventArgs e)
        {
            SelectionChanged?.Invoke(sender, e);
        }

        /// <summary>
        /// Получить идентификатор сотрудника
        /// </summary>
        /// <param name="RowID">Идентификатор строки DataGridView</param>
        /// <returns></returns>
        public int GetEmployeeID(int RowID)
        {
            if (dataGridView.Rows.Count == 0
                || dataGridView.Rows.Count<=RowID) return -1;
            int ID = -1;
            ID = Convert.ToInt32(dataGridView.Rows[RowID].Cells["ID"].Value);
            return ID;
        }

        /// <summary>
        /// Удалить строку в DataGridView
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            if (dataGridView.Rows.Count <= index) return;
            else
            {
                if (this.SelectedRowIndex == index) dataGridView.ClearSelection();
                dataGridView.Rows.RemoveAt(index);
            }
        }
        #endregion
    }
}
