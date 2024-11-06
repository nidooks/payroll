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
    public partial class Leave : Form
    {
        public Leave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn? logIn = new LogIn();
            logIn = null;
            this.Close();
        }

        private void Employee_Button(object sender, EventArgs e)
        {
            this.Hide();
            Employee? employee = new Employee();
            employee = null;
            this.Close();
        }

        private void Advance_Button(object sender, EventArgs e)
        {
            this.Hide();
            Adnvance? adnvance = new Adnvance();
            adnvance = null;
            this.Close();
        }

        private void Report_Button(object sender, EventArgs e)
        {
            this.Hide();
            Report? report = new Report();
            report = null;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Attendance_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance? attendance = new Attendance();
            attendance = null;
            this.Close();
        }

        private void Salary_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary? salary = new Salary();
            salary = null;
            this.Close();
        }
    }
}
