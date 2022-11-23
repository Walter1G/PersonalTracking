namespace PersonalTracking
{
    partial class FrmTaskList
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbTaskState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDeliveryDate = new System.Windows.Forms.RadioButton();
            this.rbStartDate = new System.Windows.Forms.RadioButton();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlforAdmin = new System.Windows.Forms.Panel();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlforAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlforAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 179);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.cmbTaskState);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.dpEnd);
            this.panel3.Controls.Add(this.dpStart);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(301, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 179);
            this.panel3.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(405, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(303, 125);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbTaskState
            // 
            this.cmbTaskState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbTaskState.FormattingEnabled = true;
            this.cmbTaskState.Location = new System.Drawing.Point(113, 117);
            this.cmbTaskState.Name = "cmbTaskState";
            this.cmbTaskState.Size = new System.Drawing.Size(165, 27);
            this.cmbTaskState.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Task State";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDeliveryDate);
            this.groupBox1.Controls.Add(this.rbStartDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(303, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 87);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rbDeliveryDate
            // 
            this.rbDeliveryDate.AutoSize = true;
            this.rbDeliveryDate.Location = new System.Drawing.Point(19, 51);
            this.rbDeliveryDate.Name = "rbDeliveryDate";
            this.rbDeliveryDate.Size = new System.Drawing.Size(111, 21);
            this.rbDeliveryDate.TabIndex = 1;
            this.rbDeliveryDate.TabStop = true;
            this.rbDeliveryDate.Text = "Delivery Date";
            this.rbDeliveryDate.UseVisualStyleBackColor = true;
            // 
            // rbStartDate
            // 
            this.rbStartDate.AutoSize = true;
            this.rbStartDate.Location = new System.Drawing.Point(19, 19);
            this.rbStartDate.Name = "rbStartDate";
            this.rbStartDate.Size = new System.Drawing.Size(90, 21);
            this.rbStartDate.TabIndex = 0;
            this.rbStartDate.TabStop = true;
            this.rbStartDate.Text = "Start Date";
            this.rbStartDate.UseVisualStyleBackColor = true;
            // 
            // dpEnd
            // 
            this.dpEnd.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpEnd.Location = new System.Drawing.Point(117, 77);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(165, 26);
            this.dpEnd.TabIndex = 1;
            // 
            // dpStart
            // 
            this.dpStart.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpStart.Location = new System.Drawing.Point(117, 45);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(165, 26);
            this.dpStart.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Finish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Task Date";
            // 
            // pnlforAdmin
            // 
            this.pnlforAdmin.Controls.Add(this.cmbPosition);
            this.pnlforAdmin.Controls.Add(this.lblPosition);
            this.pnlforAdmin.Controls.Add(this.cmbDepartment);
            this.pnlforAdmin.Controls.Add(this.lblDepartment);
            this.pnlforAdmin.Controls.Add(this.txtSirname);
            this.pnlforAdmin.Controls.Add(this.label1);
            this.pnlforAdmin.Controls.Add(this.txtName);
            this.pnlforAdmin.Controls.Add(this.lblName);
            this.pnlforAdmin.Controls.Add(this.txtUserNo);
            this.pnlforAdmin.Controls.Add(this.lblUserNo);
            this.pnlforAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlforAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlforAdmin.Name = "pnlforAdmin";
            this.pnlforAdmin.Size = new System.Drawing.Size(301, 179);
            this.pnlforAdmin.TabIndex = 0;
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(121, 143);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(155, 27);
            this.cmbPosition.TabIndex = 4;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPosition.Location = new System.Drawing.Point(20, 143);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(62, 19);
            this.lblPosition.TabIndex = 9;
            this.lblPosition.Text = "Position";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(121, 109);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(155, 27);
            this.cmbDepartment.TabIndex = 3;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepartment.Location = new System.Drawing.Point(12, 112);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(89, 19);
            this.lblDepartment.TabIndex = 10;
            this.lblDepartment.Text = "Department";
            // 
            // txtSirname
            // 
            this.txtSirname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSirname.Location = new System.Drawing.Point(124, 74);
            this.txtSirname.Name = "txtSirname";
            this.txtSirname.Size = new System.Drawing.Size(152, 26);
            this.txtSirname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sirname";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(124, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(33, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUserNo.Location = new System.Drawing.Point(124, 10);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(152, 26);
            this.txtUserNo.TabIndex = 0;
            this.txtUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserNo_KeyPress);
            // 
            // lblUserNo
            // 
            this.lblUserNo.AutoSize = true;
            this.lblUserNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserNo.Location = new System.Drawing.Point(33, 13);
            this.lblUserNo.Name = "lblUserNo";
            this.lblUserNo.Size = new System.Drawing.Size(65, 19);
            this.lblUserNo.TabIndex = 8;
            this.lblUserNo.Text = "User No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(804, 243);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnApprove);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 77);
            this.panel2.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(481, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(379, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(277, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApprove.Location = new System.Drawing.Point(93, 16);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(86, 36);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(185, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 36);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // FrmTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 422);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTaskList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task List";
            this.Load += new System.EventHandler(this.FrmTaskList_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlforAdmin.ResumeLayout(false);
            this.pnlforAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel pnlforAdmin;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnApprove;
        private Button btnNew;
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
        private DateTimePicker dpEnd;
        private DateTimePicker dpStart;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbTaskState;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton rbDeliveryDate;
        private RadioButton rbStartDate;
        private Button btnClear;
        private Button btnSearch;
    }
}