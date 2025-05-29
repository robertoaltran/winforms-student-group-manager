namespace Test1.Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group group = new Group()
            {
                Name = txtGroupName.Text,
                Size = int.Parse(txtGroupSize.Text),
                Type = rdoSchoolGroup.Checked ? GroupType.School : GroupType.Tour
            };

            lblGroupName.Text = group.Name;
            lblGroupSize.Text = group.Size.ToString();
            decimal totalPrice = group.CalculateTotalPrice();
            decimal discountAmount = group.CalculateDiscountAmount();
            lblPrice.Text = $"${totalPrice:F2}";
            lblDiscountAmount.Text = $"${discountAmount:F2}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}