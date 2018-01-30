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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmDepartmentView));
            this.tscMain = new System.Windows.Forms.ToolStripContainer();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tsrEmployee = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlDepartment = new System.Windows.Forms.Panel();
            this.tvDepartment = new System.Windows.Forms.TreeView();
            this.tsrDepartment = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
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
            this.toolStripButton3,
            this.toolStripButton4});
            this.tsrEmployee.Location = new System.Drawing.Point(0, 0);
            this.tsrEmployee.Name = "tsrEmployee";
            this.tsrEmployee.Size = new System.Drawing.Size(507, 25);
            this.tsrEmployee.TabIndex = 0;
            this.tsrEmployee.Text = "toolStrip2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
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
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton5});
            this.tsrDepartment.Location = new System.Drawing.Point(0, 0);
            this.tsrDepartment.Name = "tsrDepartment";
            this.tsrDepartment.Size = new System.Drawing.Size(223, 25);
            this.tsrDepartment.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
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
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TreeView tvDepartment;
        private System.Windows.Forms.ToolStrip tsrDepartment;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}

