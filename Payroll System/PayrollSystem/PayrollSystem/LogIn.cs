namespace PayrollSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary? salary = new Salary();
            salary.ShowDialog();
            salary = null;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee? employee = new Employee(); this.Hide();
            employee.ShowDialog();
            employee = null;
            this.Close();

        }

        private void Cash_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adnvance? adnvance = new Adnvance();
            adnvance.ShowDialog();
            adnvance = null;
            this.Close();
        }

        private void Attendance_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance? attendance = new Attendance();  
            attendance.ShowDialog();
            attendance = null;
            this.Close();
        }

        private void Leave_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leave? Leave = new Leave();
            Leave.ShowDialog();
            Leave = null;
            this.Close();
        }

        private void Report_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report? report = new Report();
            report.ShowDialog();
            report = null;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
;