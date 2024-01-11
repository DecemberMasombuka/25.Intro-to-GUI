namespace _23.Intro_to_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calcuates and Pops up the age of the user,given thier year of birth
            int year = int.Parse(txtYear.Text);
            string currentDate = DateTime.Now.ToString();
            int age = 2024 - year;
            MessageBox.Show("Hellow , You are " + age + " Years old");

            //Displays name and surname in the Label
            lblFullname.Text = "Hellow " + txtName.Text + " " + txtSurname.Text;
        }
    }
}