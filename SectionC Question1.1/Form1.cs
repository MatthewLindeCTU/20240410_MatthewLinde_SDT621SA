namespace SectionC_Question1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tblMobilePhones.Items.Add("Code, Make, Quantity");
        }

        List<List<string>> list = new List<List<string>>();
        List<string> foundList = new List<string>();
        bool found = false;
        int foundIndex = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            string make = txtMake.Text;
            string quantity = txtQuantity.Text;

            tblMobilePhones.Items.Add($"{code}, {make}, " +
                $"{quantity}");

            lblOutput.Text = $"Record Added";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindItem();

            if (foundIndex == 0)
            {
                lblOutput.Text = "Record NOT Found";
            }
            else
            {
                lblOutput.Text = "Record Found";
            }
        }

        public void FindItem()
        {
            string code = txtCode.Text;

            foreach (string item in tblMobilePhones.Items)
            {
                list.Add(new List<string> { item });
            }

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    if (list[i][j].ToString().Contains(code))
                    {
                        found = true;
                        foundList.Add(list[i][j].ToString());
                        foundIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FindItem();

            if (foundIndex == 0)
            {
                lblOutput.Text = "Record NOT Found";
            }
            else
            {
                lblOutput.Text = "Record Deleted";

                tblMobilePhones.Items.RemoveAt(foundIndex);
            }

            foundIndex = 0;
            list.Clear();
            foundList.Clear();
        }
    }
}
