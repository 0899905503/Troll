namespace MB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         DialogResult = MessageBox.Show("BAVO so handsome ?","Answer",MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Of Couse ! BAVO so handsome");
            }
            else
            {
                MessageBox.Show("Your answer is wrong ! BAVO so handsome is the right answer ");
            }
        }
    }
}