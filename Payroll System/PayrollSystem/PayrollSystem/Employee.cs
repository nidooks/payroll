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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogIn? logIn = new LogIn();
            logIn = null;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Advance_button_Click(object sender, EventArgs e)
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

        }
    }
}
