using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn? logIn = new LogIn();
            logIn = null;
            this.Close();
        }

        private void Employee_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee? employee = new Employee();
            employee = null;
            this.Close();
        }

        private void Cash_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adnvance? adnvance = new Adnvance();
            adnvance = null;
            this.Close();
        }

        private void Attendance_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance? attendance = new Attendance();
            attendance = null;
            this.Close();
        }

        private void Leave_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leave? leave = new Leave();
            leave = null;
            this.Close();
        }

        private void Salary_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary? salary = new Salary();
            salary = null;
            this.Close();
        }

        private void Report_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report? report = new Report();
            report = null;
            this.Close();
        }
    }
}
