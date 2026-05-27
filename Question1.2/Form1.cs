namespace Question1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            MessageBox.Show($"Hello {name}!");
        }
    }
}
