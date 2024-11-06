
namespace PayrollSystem
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            panel1 = new Panel();
            button10 = new Button();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            label16 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            Home_button = new Button();
            Employee_Button = new Button();
            Salary_Button = new Button();
            Leave_Button = new Button();
            Attendance_Button = new Button();
            Report_Button = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            panel3 = new Panel();
            Cash_Button = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button10);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(67, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1271, 628);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button10
            // 
            button10.Location = new Point(1057, 129);
            button10.Name = "button10";
            button10.Size = new Size(118, 22);
            button10.TabIndex = 9;
            button10.Text = "Search";
            button10.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1180, 433);
            dataGridView1.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(866, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(148, 23);
            textBox3.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(733, 132);
            label9.Name = "label9";
            label9.Size = new Size(90, 21);
            label9.TabIndex = 6;
            label9.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(538, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(418, 134);
            label8.Name = "label8";
            label8.Size = new Size(92, 21);
            label8.TabIndex = 4;
            label8.Text = "First Name";
            label8.Click += label8_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(84, 136);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 2;
            label7.Text = "ID Number";
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1271, 77);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(851, 35);
            label16.Name = "label16";
            label16.Size = new Size(73, 30);
            label16.TabIndex = 9;
            label16.Text = "Salary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(984, 35);
            label6.Name = "label6";
            label6.Size = new Size(80, 30);
            label6.TabIndex = 7;
            label6.Text = "Report";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(721, 35);
            label5.Name = "label5";
            label5.Size = new Size(68, 30);
            label5.TabIndex = 6;
            label5.Text = "Leave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(522, 35);
            label4.Name = "label4";
            label4.Size = new Size(126, 30);
            label4.TabIndex = 5;
            label4.Text = "Attendance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(354, 35);
            label3.Name = "label3";
            label3.Size = new Size(97, 30);
            label3.TabIndex = 4;
            label3.Text = "Advance";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(32, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(72, 5);
            panel4.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 35);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 3;
            label2.Text = "Home";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 35);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 2;
            label1.Text = "Employee";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(1131, 23);
            button1.Name = "button1";
            button1.Size = new Size(44, 36);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Home_button
            // 
            Home_button.BackColor = SystemColors.ControlDarkDark;
            Home_button.BackgroundImage = (Image)resources.GetObject("Home_button.BackgroundImage");
            Home_button.BackgroundImageLayout = ImageLayout.Stretch;
            Home_button.FlatAppearance.BorderColor = Color.White;
            Home_button.FlatAppearance.BorderSize = 0;
            Home_button.FlatStyle = FlatStyle.Flat;
            Home_button.Location = new Point(12, 16);
            Home_button.Name = "Home_button";
            Home_button.Size = new Size(49, 48);
            Home_button.TabIndex = 2;
            Home_button.UseVisualStyleBackColor = false;
            Home_button.Click += button2_Click;
            // 
            // Employee_Button
            // 
            Employee_Button.BackgroundImage = (Image)resources.GetObject("Employee_Button.BackgroundImage");
            Employee_Button.FlatAppearance.BorderColor = Color.White;
            Employee_Button.FlatStyle = FlatStyle.Flat;
            Employee_Button.Location = new Point(12, 115);
            Employee_Button.Name = "Employee_Button";
            Employee_Button.Size = new Size(49, 48);
            Employee_Button.TabIndex = 3;
            Employee_Button.UseVisualStyleBackColor = true;
            Employee_Button.Click += button3_Click;
            // 
            // Salary_Button
            // 
            Salary_Button.BackgroundImage = (Image)resources.GetObject("Salary_Button.BackgroundImage");
            Salary_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Salary_Button.FlatAppearance.BorderColor = Color.White;
            Salary_Button.FlatStyle = FlatStyle.Flat;
            Salary_Button.Location = new Point(12, 420);
            Salary_Button.Name = "Salary_Button";
            Salary_Button.Size = new Size(49, 48);
            Salary_Button.TabIndex = 4;
            Salary_Button.UseVisualStyleBackColor = true;
            Salary_Button.Click += button4_Click;
            // 
            // Leave_Button
            // 
            Leave_Button.BackgroundImage = (Image)resources.GetObject("Leave_Button.BackgroundImage");
            Leave_Button.FlatAppearance.BorderColor = Color.White;
            Leave_Button.FlatStyle = FlatStyle.Flat;
            Leave_Button.Location = new Point(12, 334);
            Leave_Button.Name = "Leave_Button";
            Leave_Button.Size = new Size(49, 48);
            Leave_Button.TabIndex = 5;
            Leave_Button.UseVisualStyleBackColor = true;
            Leave_Button.Click += Leave_Button_Click;
            // 
            // Attendance_Button
            // 
            Attendance_Button.BackgroundImage = (Image)resources.GetObject("Attendance_Button.BackgroundImage");
            Attendance_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Attendance_Button.FlatAppearance.BorderColor = Color.White;
            Attendance_Button.FlatStyle = FlatStyle.Flat;
            Attendance_Button.Location = new Point(12, 266);
            Attendance_Button.Name = "Attendance_Button";
            Attendance_Button.Size = new Size(49, 48);
            Attendance_Button.TabIndex = 6;
            Attendance_Button.UseVisualStyleBackColor = true;
            Attendance_Button.Click += Attendance_Button_Click;
            // 
            // Report_Button
            // 
            Report_Button.BackgroundImage = (Image)resources.GetObject("Report_Button.BackgroundImage");
            Report_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Report_Button.FlatAppearance.BorderColor = Color.White;
            Report_Button.FlatStyle = FlatStyle.Flat;
            Report_Button.Location = new Point(12, 509);
            Report_Button.Name = "Report_Button";
            Report_Button.Size = new Size(49, 48);
            Report_Button.TabIndex = 7;
            Report_Button.UseVisualStyleBackColor = true;
            Report_Button.Click += Report_Button_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(67, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 641);
            panel3.TabIndex = 33;
            // 
            // Cash_Button
            // 
            Cash_Button.BackColor = SystemColors.Control;
            Cash_Button.BackgroundImage = (Image)resources.GetObject("Cash_Button.BackgroundImage");
            Cash_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Cash_Button.FlatAppearance.BorderColor = Color.White;
            Cash_Button.FlatStyle = FlatStyle.Flat;
            Cash_Button.Location = new Point(12, 192);
            Cash_Button.Name = "Cash_Button";
            Cash_Button.Size = new Size(49, 48);
            Cash_Button.TabIndex = 44;
            Cash_Button.UseVisualStyleBackColor = false;
            Cash_Button.Click += Cash_Button_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1298, 628);
            Controls.Add(Cash_Button);
            Controls.Add(panel3);
            Controls.Add(Report_Button);
            Controls.Add(Attendance_Button);
            Controls.Add(Leave_Button);
            Controls.Add(Salary_Button);
            Controls.Add(Employee_Button);
            Controls.Add(Home_button);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
            Text = "Log In";
            Load += LogIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button Home_button;
        private Button Employee_Button;
        private Button Salary_Button;
        private Button Leave_Button;
        private Button Attendance_Button;
        private Button Report_Button;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private Label label16;
        private Panel panel3;
        private Button Cash_Button;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox1;
        private Label label7;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private Label label9;
        private Button button10;
    }
}
