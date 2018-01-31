namespace Test.Department
{
    partial class FmDepartmentView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tscMain = new System.Windows.Forms.ToolStripContainer();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tsrEmployee = new System.Windows.Forms.ToolStrip();
            this.tsbtnEmployeeEdit = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlDepartment = new System.Windows.Forms.Panel();
            this.tvDepartment = new System.Windows.Forms.TreeView();
            this.tsrDepartment = new System.Windows.Forms.ToolStrip();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tscMain.ContentPanel.SuspendLayout();
            this.tscMain.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tsrEmployee.SuspendLayout();
            this.pnlDepartment.SuspendLayout();
            this.tsrDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscMain
            // 
            // 
            // tscMain.ContentPanel
            // 
            this.tscMain.ContentPanel.Controls.Add(this.pnlEmployee);
            this.tscMain.ContentPanel.Controls.Add(this.splitter1);
            this.tscMain.ContentPanel.Controls.Add(this.pnlDepartment);
            this.tscMain.ContentPanel.Size = new System.Drawing.Size(735, 415);
            this.tscMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscMain.Location = new System.Drawing.Point(0, 0);
            this.tscMain.Name = "tscMain";
            this.tscMain.Size = new System.Drawing.Size(735, 440);
            this.tscMain.TabIndex = 0;
            this.tscMain.Text = "toolStripContainer1";
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.dgvEmployee);
            this.pnlEmployee.Controls.Add(this.tsrEmployee);
            this.pnlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployee.Location = new System.Drawing.Point(228, 0);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(507, 415);
            this.pnlEmployee.TabIndex = 2;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 25);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.Size = new System.Drawing.Size(507, 390);
            this.dgvEmployee.TabIndex = 1;
            // 
            // tsrEmployee
            // 
            this.tsrEmployee.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsrEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnEmployeeEdit});
            this.tsrEmployee.Location = new System.Drawing.Point(0, 0);
            this.tsrEmployee.Name = "tsrEmployee";
            this.tsrEmployee.Size = new System.Drawing.Size(507, 25);
            this.tsrEmployee.TabIndex = 0;
            this.tsrEmployee.Text = "toolStrip2";
            // 
            // tsbtnEmployeeEdit
            // 
            this.tsbtnEmployeeEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEmployeeEdit.Image = global::Test.Properties.Resources.edit_16;
            this.tsbtnEmployeeEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEmployeeEdit.Name = "tsbtnEmployeeEdit";
            this.tsbtnEmployeeEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbtnEmployeeEdit.Text = "Редактировать запись";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(223, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 415);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlDepartment
            // 
            this.pnlDepartment.Controls.Add(this.tvDepartment);
            this.pnlDepartment.Controls.Add(this.tsrDepartment);
            this.pnlDepartment.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDepartment.Location = new System.Drawing.Point(0, 0);
            this.pnlDepartment.Name = "pnlDepartment";
            this.pnlDepartment.Size = new System.Drawing.Size(223, 415);
            this.pnlDepartment.TabIndex = 0;
            // 
            // tvDepartment
            // 
            this.tvDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDepartment.Location = new System.Drawing.Point(0, 25);
            this.tvDepartment.Name = "tvDepartment";
            this.tvDepartment.Size = new System.Drawing.Size(223, 390);
            this.tvDepartment.TabIndex = 1;
            this.tvDepartment.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVDepartment_AfterSelect);
            // 
            // tsrDepartment
            // 
            this.tsrDepartment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsrDepartment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnRefresh});
            this.tsrDepartment.Location = new System.Drawing.Point(0, 0);
            this.tsrDepartment.Name = "tsrDepartment";
            this.tsrDepartment.Size = new System.Drawing.Size(223, 25);
            this.tsrDepartment.TabIndex = 0;
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRefresh.Image = global::Test.Properties.Resources.reload_icon;
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbtnRefresh.Text = "toolStripButton1";
            // 
            // FmDepartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 440);
            this.Controls.Add(this.tscMain);
            this.Name = "FmDepartmentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Структура предпрития";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FmDepartmentView_Load);
            this.tscMain.ContentPanel.ResumeLayout(false);
            this.tscMain.ResumeLayout(false);
            this.tscMain.PerformLayout();
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tsrEmployee.ResumeLayout(false);
            this.tsrEmployee.PerformLayout();
            this.pnlDepartment.ResumeLayout(false);
            this.pnlDepartment.PerformLayout();
            this.tsrDepartment.ResumeLayout(false);
            this.tsrDepartment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscMain;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlDepartment;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.ToolStrip tsrEmployee;
        private System.Windows.Forms.ToolStripButton tsbtnEmployeeEdit;
        private System.Windows.Forms.TreeView tvDepartment;
        private System.Windows.Forms.ToolStrip tsrDepartment;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
    }
}

