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
    public partial class Adnvance : Form
    {
        public Adnvance()
        {
            InitializeComponent();
        }

        private void Adnvance_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Advance_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leave? leave = new Leave();
            leave = null;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); LogIn? logIn = new LogIn();
            logIn = null;
            this.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Attendance_Button_Click(object sender, EventArgs e)
        {
            this.Hide(); Attendance? attendance = new Attendance();
            attendance = null;
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
