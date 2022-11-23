namespace PersonalTracking
{
    partial class FrmSalaryList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlForAdmin = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtSirname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.lblUserNo = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMore = new System.Windows.Forms.RadioButton();
            this.rbLess = new System.Windows.Forms.RadioButton();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlForAdmin.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlForAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 163);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 82);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(778, 205);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(497, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(395, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(293, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(201, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 36);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // pnlForAdmin
            // 
            this.pnlForAdmin.Controls.Add(this.cmbPosition);
            this.pnlForAdmin.Controls.Add(this.lblPosition);
            this.pnlForAdmin.Controls.Add(this.cmbDepartment);
            this.pnlForAdmin.Controls.Add(this.lblDepartment);
            this.pnlForAdmin.Controls.Add(this.txtSirname);
            this.pnlForAdmin.Controls.Add(this.label1);
            this.pnlForAdmin.Controls.Add(this.txtName);
            this.pnlForAdmin.Controls.Add(this.lblName);
            this.pnlForAdmin.Controls.Add(this.txtUserNo);
            this.pnlForAdmin.Controls.Add(this.lblUserNo);
            this.pnlForAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlForAdmin.Name = "pnlForAdmin";
            this.pnlForAdmin.Size = new System.Drawing.Size(339, 163);
            this.pnlForAdmin.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.txtYear);
            this.panel3.Controls.Add(this.lblYear);
            this.panel3.Controls.Add(this.txtSalary);
            this.panel3.Controls.Add(this.lblSalary);
            this.panel3.Controls.Add(this.cmbMonth);
            this.panel3.Controls.Add(this.lblMonth);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(339, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 163);
            this.panel3.TabIndex = 1;
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(146, 134);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(155, 27);
            this.cmbPosition.TabIndex = 4;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPosition.Location = new System.Drawing.Point(45, 134);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(62, 19);
            this.lblPosition.TabIndex = 19;
            this.lblPosition.Text = "Position";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(146, 100);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(155, 27);
            this.cmbDepartment.TabIndex = 3;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepartment.Location = new System.Drawing.Point(45, 103);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(89, 19);
            this.lblDepartment.TabIndex = 20;
            this.lblDepartment.Text = "Department";
            // 
            // txtSirname
            // 
            this.txtSirname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSirname.Location = new System.Drawing.Point(149, 65);
            this.txtSirname.Name = "txtSirname";
            this.txtSirname.Size = new System.Drawing.Size(152, 26);
            this.txtSirname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sirname";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(149, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(45, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUserNo.Location = new System.Drawing.Point(149, 1);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(152, 26);
            this.txtUserNo.TabIndex = 0;
            // 
            // lblUserNo
            // 
            this.lblUserNo.AutoSize = true;
            this.lblUserNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserNo.Location = new System.Drawing.Point(45, 4);
            this.lblUserNo.Name = "lblUserNo";
            this.lblUserNo.Size = new System.Drawing.Size(65, 19);
            this.lblUserNo.TabIndex = 18;
            this.lblUserNo.Text = "User No";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtYear.Location = new System.Drawing.Point(71, 3);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(165, 26);
            this.txtYear.TabIndex = 0;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(8, 8);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 19);
            this.lblYear.TabIndex = 25;
            this.lblYear.Text = "Year";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSalary.Location = new System.Drawing.Point(71, 68);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(165, 26);
            this.txtSalary.TabIndex = 2;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalary.Location = new System.Drawing.Point(8, 73);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(52, 19);
            this.lblSalary.TabIndex = 26;
            this.lblSalary.Text = "Salary";
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(71, 35);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(165, 27);
            this.cmbMonth.TabIndex = 1;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonth.Location = new System.Drawing.Point(8, 44);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(54, 19);
            this.lblMonth.TabIndex = 24;
            this.lblMonth.Text = "Month";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEqual);
            this.groupBox1.Controls.Add(this.rbLess);
            this.groupBox1.Controls.Add(this.rbMore);
            this.groupBox1.Location = new System.Drawing.Point(249, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // rbMore
            // 
            this.rbMore.AutoSize = true;
            this.rbMore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbMore.Location = new System.Drawing.Point(6, 32);
            this.rbMore.Name = "rbMore";
            this.rbMore.Size = new System.Drawing.Size(55, 19);
            this.rbMore.TabIndex = 0;
            this.rbMore.TabStop = true;
            this.rbMore.Text = "More";
            this.rbMore.UseVisualStyleBackColor = true;
            // 
            // rbLess
            // 
            this.rbLess.AutoSize = true;
            this.rbLess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbLess.Location = new System.Drawing.Point(67, 32);
            this.rbLess.Name = "rbLess";
            this.rbLess.Size = new System.Drawing.Size(48, 19);
            this.rbLess.TabIndex = 1;
            this.rbLess.TabStop = true;
            this.rbLess.Text = "Less";
            this.rbLess.UseVisualStyleBackColor = true;
            // 
            // rbEqual
            // 
            this.rbEqual.AutoSize = true;
            this.rbEqual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbEqual.Location = new System.Drawing.Point(128, 32);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.Size = new System.Drawing.Size(54, 19);
            this.rbEqual.TabIndex = 2;
            this.rbEqual.TabStop = true;
            this.rbEqual.Text = "Equal";
            this.rbEqual.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(200, 118);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(98, 117);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // FrmSalaryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSalaryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary List";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlForAdmin.ResumeLayout(false);
            this.pnlForAdmin.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Panel pnlForAdmin;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private ComboBox cmbPosition;
        private Label lblPosition;
        private ComboBox cmbDepartment;
        private Label lblDepartment;
        private TextBox txtSirname;
        private Label label1;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtUserNo;
        private Label lblUserNo;
        private GroupBox groupBox1;
        private RadioButton rbEqual;
        private RadioButton rbLess;
        private RadioButton rbMore;
        private TextBox txtYear;
        private Label lblYear;
        private TextBox txtSalary;
        private Label lblSalary;
        private ComboBox cmbMonth;
        private Label lblMonth;
        private Button btnClear;
        private Button btnSearch;
    }
}