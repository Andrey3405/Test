namespace Test.EmployeeCard
{
    partial class FmEmployeeCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.grpFullname = new System.Windows.Forms.GroupBox();
            this.lbPatronymic = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpDocument = new System.Windows.Forms.GroupBox();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbSeries = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEmployeeYear = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPosition = new System.Windows.Forms.GroupBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpFullname.SuspendLayout();
            this.grpDocument.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpPosition.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(6, 25);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(56, 13);
            this.lbSurname.TabIndex = 0;
            this.lbSurname.Text = "Фамилия";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(68, 22);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(182, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // grpFullname
            // 
            this.grpFullname.Controls.Add(this.lbPatronymic);
            this.grpFullname.Controls.Add(this.txtPatronymic);
            this.grpFullname.Controls.Add(this.lbName);
            this.grpFullname.Controls.Add(this.txtName);
            this.grpFullname.Controls.Add(this.lbSurname);
            this.grpFullname.Controls.Add(this.txtSurname);
            this.grpFullname.Location = new System.Drawing.Point(7, 3);
            this.grpFullname.Name = "grpFullname";
            this.grpFullname.Size = new System.Drawing.Size(256, 103);
            this.grpFullname.TabIndex = 2;
            this.grpFullname.TabStop = false;
            this.grpFullname.Text = "Полное имя";
            // 
            // lbPatronymic
            // 
            this.lbPatronymic.AutoSize = true;
            this.lbPatronymic.Location = new System.Drawing.Point(6, 77);
            this.lbPatronymic.Name = "lbPatronymic";
            this.lbPatronymic.Size = new System.Drawing.Size(54, 13);
            this.lbPatronymic.TabIndex = 4;
            this.lbPatronymic.Text = "Отчество";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(68, 74);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(182, 20);
            this.txtPatronymic.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 51);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Имя";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(68, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 3;
            // 
            // grpDocument
            // 
            this.grpDocument.Controls.Add(this.txtSeries);
            this.grpDocument.Controls.Add(this.txtNumber);
            this.grpDocument.Controls.Add(this.lbNumber);
            this.grpDocument.Controls.Add(this.lbSeries);
            this.grpDocument.Location = new System.Drawing.Point(269, 3);
            this.grpDocument.Name = "grpDocument";
            this.grpDocument.Size = new System.Drawing.Size(209, 103);
            this.grpDocument.TabIndex = 6;
            this.grpDocument.TabStop = false;
            this.grpDocument.Text = "Документ";
            // 
            // txtSeries
            // 
            this.txtSeries.Location = new System.Drawing.Point(69, 22);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(134, 20);
            this.txtSeries.TabIndex = 6;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(69, 48);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(134, 20);
            this.txtNumber.TabIndex = 5;
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(6, 51);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(41, 13);
            this.lbNumber.TabIndex = 4;
            this.lbNumber.Text = "Номер";
            // 
            // lbSeries
            // 
            this.lbSeries.AutoSize = true;
            this.lbSeries.Location = new System.Drawing.Point(6, 25);
            this.lbSeries.Name = "lbSeries";
            this.lbSeries.Size = new System.Drawing.Size(38, 13);
            this.lbSeries.TabIndex = 2;
            this.lbSeries.Text = "Серия";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbEmployeeYear);
            this.groupBox1.Controls.Add(this.lbYear);
            this.groupBox1.Controls.Add(this.dtpDateOfBirth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 39);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lbEmployeeYear
            // 
            this.lbEmployeeYear.AutoSize = true;
            this.lbEmployeeYear.Location = new System.Drawing.Point(328, 16);
            this.lbEmployeeYear.Name = "lbEmployeeYear";
            this.lbEmployeeYear.Size = new System.Drawing.Size(13, 13);
            this.lbEmployeeYear.TabIndex = 5;
            this.lbEmployeeYear.Text = "0";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(268, 16);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(49, 13);
            this.lbYear.TabIndex = 4;
            this.lbYear.Text = "Возраст";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(98, 13);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(152, 20);
            this.dtpDateOfBirth.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата рождения";
            // 
            // grpPosition
            // 
            this.grpPosition.Controls.Add(this.txtPosition);
            this.grpPosition.Location = new System.Drawing.Point(7, 157);
            this.grpPosition.Name = "grpPosition";
            this.grpPosition.Size = new System.Drawing.Size(471, 49);
            this.grpPosition.TabIndex = 8;
            this.grpPosition.TabStop = false;
            this.grpPosition.Text = "Должность";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(9, 19);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(456, 20);
            this.txtPosition.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 34);
            this.panel1.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(322, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(403, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FmEmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 247);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpPosition);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDocument);
            this.Controls.Add(this.grpFullname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmEmployeeCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карточка сотрудника";
            this.grpFullname.ResumeLayout(false);
            this.grpFullname.PerformLayout();
            this.grpDocument.ResumeLayout(false);
            this.grpDocument.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPosition.ResumeLayout(false);
            this.grpPosition.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.GroupBox grpFullname;
        private System.Windows.Forms.Label lbPatronymic;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpDocument;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbSeries;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbEmployeeYear;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}