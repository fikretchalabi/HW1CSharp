namespace HW1CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            lbl_1.Text = "Nice to meet you";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_1.ForeColor = Color.YellowGreen;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am Button 3");
        }

       private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btn_3.Visible = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btn_3.Visible = true;
        }
    }
}