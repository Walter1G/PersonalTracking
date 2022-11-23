namespace PersonalTracking
{
    partial class FrmSalary
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSirname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.lblUserNo = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(342, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 450);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(251, 309);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbPosition);
            this.panel2.Controls.Add(this.lblPosition);
            this.panel2.Controls.Add(this.cmbDepartment);
            this.panel2.Controls.Add(this.lblDepartment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 141);
            this.panel2.TabIndex = 0;
            // 
            // txtSirname
            // 
            this.txtSirname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSirname.Location = new System.Drawing.Point(99, 79);
            this.txtSirname.Name = "txtSirname";
            this.txtSirname.ReadOnly = true;
            this.txtSirname.Size = new System.Drawing.Size(165, 26);
            this.txtSirname.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sirname";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(99, 47);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(165, 26);
            this.txtName.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(12, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUserNo.Location = new System.Drawing.Point(99, 15);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.ReadOnly = true;
            this.txtUserNo.Size = new System.Drawing.Size(165, 26);
            this.txtUserNo.TabIndex = 12;
            // 
            // lblUserNo
            // 
            this.lblUserNo.AutoSize = true;
            this.lblUserNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserNo.Location = new System.Drawing.Point(12, 19);
            this.lblUserNo.Name = "lblUserNo";
            this.lblUserNo.Size = new System.Drawing.Size(65, 19);
            this.lblUserNo.TabIndex = 15;
            this.lblUserNo.Text = "User No";
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(38, 91);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(155, 27);
            this.cmbPosition.TabIndex = 1;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPosition.Location = new System.Drawing.Point(48, 69);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(62, 19);
            this.lblPosition.TabIndex = 17;
            this.lblPosition.Text = "Position";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(38, 37);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(155, 27);
            this.cmbDepartment.TabIndex = 0;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepartment.Location = new System.Drawing.Point(38, 15);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(89, 19);
            this.lblDepartment.TabIndex = 18;
            this.lblDepartment.Text = "Department";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSalary.Location = new System.Drawing.Point(99, 125);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(165, 26);
            this.txtSalary.TabIndex = 0;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalary.Location = new System.Drawing.Point(12, 129);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(52, 19);
            this.lblSalary.TabIndex = 20;
            this.lblSalary.Text = "Salary";
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(99, 205);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(165, 27);
            this.cmbMonth.TabIndex = 2;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonth.Location = new System.Drawing.Point(12, 213);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(54, 19);
            this.lblMonth.TabIndex = 19;
            this.lblMonth.Text = "Month";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(12, 169);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 19);
            this.lblYear.TabIndex = 20;
            this.lblYear.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtYear.Location = new System.Drawing.Point(99, 165);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(165, 26);
            this.txtYear.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(159, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 31);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(45, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtSirname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtUserNo);
            this.Controls.Add(this.lblUserNo);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.FrmSalary_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox txtSirname;
        private Label label1;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtUserNo;
        private Label lblUserNo;
        private ComboBox cmbPosition;
        private Label lblPosition;
        private ComboBox cmbDepartment;
        private Label lblDepartment;
        private TextBox txtSalary;
        private Label lblSalary;
        private ComboBox cmbMonth;
        private Label lblMonth;
        private Label lblYear;
        private TextBox txtYear;
        private Button btnClose;
        private Button btnSave;
    }
}