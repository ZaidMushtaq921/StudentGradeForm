namespace StudentGradeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
          
            string registrationNumber = comboBox1.Text;
            string studentName = textBox1.Text;
            string department = textBox2.Text;
            string semester = textBox3.Text;

            
            int value1 = (int)numericUpDown1.Value;
            int value2 = (int)numericUpDown2.Value;
            int value3 = (int)numericUpDown3.Value;
            int value4 = (int)numericUpDown4.Value;

            
            double average = (value1 + value2 + value3 + value4) / 4.0;

            string grade;
            if (average > 95)
            {
                grade = "S";
            }
            else if (average > 85)
            {
                grade = "A";
            }
            else if (average > 75)
            {
                grade = "B";
            }
            else if (average > 65)
            {
                grade = "C";
            }
            else if (average > 50)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            
            string message = $"Registration Number: {registrationNumber}\nStudent Name: {studentName}\nDepartment: {department}\nSemester: {semester}\nAverage: {average:F2}\nGrade: {grade}";
            MessageBox.Show(message, "Result");
        }
    }
}