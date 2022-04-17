namespace Activity_4___Seconds_Elapsed
{
    public partial class secondsElapsedForm : Form
    {
        
        public secondsElapsedForm()
        {
            InitializeComponent();
            this.ActiveControl = secondsElapsedInput;
            ;
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            int value, days, hours, minutes, seconds;
            if (int.TryParse(secondsElapsedInput.Text, out value)) ;
            
            else
            {
                // display message error
                MessageBox.Show("Please enter an Integer");
            }

            //Calculate how many days the value entered converts to
            days = ((value / 60) / 60) / 24;
            //Calculate how many hours the value converts to
            hours = ((value / 60) / 60) % 24;
            //Calculate how many minutes the value converts to 
            minutes = (value / 60) % 60;
            //Calculate how many seconds the value converts to
            seconds = value % 60;


            //output days
            daysOutput2.Text = days.ToString();
            //output hours
            hoursOutput.Text = hours.ToString();
            //output minutes
            minutesOutput.Text = minutes.ToString();  
            //output seconds
            secondsOutput.Text = seconds.ToString();


            int days2, hours2, minutes2, seconds2;

            if (value >= 60 && value <= 3600)
            {
                minutes2 = value / 60;
                //output integer output
                integerOutput.Text = minutes2.ToString();
                //output time type
                timeTypeOutput.Text = "Minutes";
                //output seconds entered
                secondsEnteredOutput.Text = value.ToString();
            }
            else if (value > 3600 && value < 86400)
            {
                hours2 = (value / 60) / 60;
                //output integer output
                integerOutput.Text = hours2.ToString();
                //output time type
                timeTypeOutput.Text = "Hours";
                //output seconds entered
                secondsEnteredOutput.Text = value.ToString();
            }
            else if (value >= 86400)
            {
                days2 = ((value / 60) / 60)/24;
                //output integer output
                integerOutput.Text = days2.ToString();
                //output time type
                timeTypeOutput.Text = "Days";
                //output seconds entered
                secondsEnteredOutput.Text = value.ToString();
            }
            else
            {
                seconds2 = value;
                //output integer output
                integerOutput.Text = seconds2.ToString();
                //output time type
                timeTypeOutput.Text = "Seconds";
                //output seconds entered
                secondsEnteredOutput.Text = value.ToString();
            }

            
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the text box controls
            secondsElapsedInput.Text = "";
            daysOutput2.Text = "";
            hoursOutput.Text = "";
            minutesOutput.Text = "";
            secondsOutput.Text = "";

            secondsElapsedInput.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

}