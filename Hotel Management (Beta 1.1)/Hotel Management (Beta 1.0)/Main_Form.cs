namespace Hotel_Management__Beta_1._0_
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
           // Use .ShowDialog() method to only keep the new Form active and prevent interference.
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Title_Label.FlatStyle = FlatStyle.Standard;
            Title_Label.Parent = Title_Holder;
            Title_Label.BackColor = Color.Transparent;
       
        }

        private void CheckIn_Button_Click(object sender, EventArgs e)
        {
            CheckIn_Form form_CheckIn = new CheckIn_Form();
            form_CheckIn.ShowDialog();
        }

        private void CheckOut_Button_Click(object sender, EventArgs e)
        {
            CheckOut_Form form_CheckOut = new CheckOut_Form();
            form_CheckOut.ShowDialog();
        }

        private void Capacity_Button_Click(object sender, EventArgs e)
        {
            Rooms_Form form_Capacity = new Rooms_Form();
            form_Capacity.ShowDialog();
        }

        private void LookUp_Button_Click(object sender, EventArgs e)
        {

        }

        private void Report_Button_Click(object sender, EventArgs e)
        {

        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}