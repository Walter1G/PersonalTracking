using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmployee employee= new FrmEmployee();
            this.Hide();
            employee.ShowDialog();
            this.Visible= true;
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            FrmTask task = new FrmTask();
            this.Hide();
            task.ShowDialog();
            this.Visible = true;
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            FrmSalary salary = new FrmSalary();
            this.Hide();
            salary.ShowDialog();
            this.Visible = true;
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
           FrmPermission permission = new FrmPermission();
            this.Hide();
            permission.ShowDialog();
            this.Visible = true;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            FrmDepartment department= new FrmDepartment();
            this.Hide();
            department.ShowDialog();
            this.Visible = true;

        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            FrmPosition position = new FrmPosition();
            this.Hide();
            position.ShowDialog();
            this.Visible = true;

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
           FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
            this.Visible = true;
        }
    }
}
