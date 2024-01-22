namespace WinFormPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection()
            {
                "Username",
                "Userpassword",
                "Union"
            };

            greatings_input.AutoCompleteCustomSource = collection;
            greatings_input.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            greatings_input.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void add_data_button_Click(object sender, EventArgs e)
        {
            string labeltText = greatings_input.Text;
            label_info.Text = "Hello, " + labeltText;
        }

        private void greatings_input_TextChanged(object sender, EventArgs e)
        {

            label_info.Text = greatings_input.Text;
        }

        private void label_info_Click(object sender, EventArgs e)
        {
        }
    }
}
