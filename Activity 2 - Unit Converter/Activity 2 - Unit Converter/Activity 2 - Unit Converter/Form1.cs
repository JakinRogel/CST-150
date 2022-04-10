namespace Activity_2___Unit_Converter
{
    public partial class unitConverterForm : Form
    {
        public unitConverterForm()
        {
            InitializeComponent();
        }

        private void inputYourWeightOnEarth_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void converterButton_Click(object sender, EventArgs e)
        {
            double weight;
            double output;
            weight = double.Parse(inputYourWeightOnEarth.Text);
            output = weight / 9.81 * 3.711;
            outputYourWeightOnMars.Text = output.ToString();
        }
    }
}