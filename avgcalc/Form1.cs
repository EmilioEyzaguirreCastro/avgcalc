using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading.Tasks;

namespace avgcalc
{
    public partial class Form1 : Form
    {
        List<double> times = new List<double>();
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = submitBtn;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string input = textBox.Text;
            double d;

            if (double.TryParse(input, out d))
            {
                //Checks the value isnt negative
                double currentTime = Convert.ToDouble(input);
                if (currentTime > 0)
                {
                    // If the list is smaller than 5, the it adds another time
                    if (times.Count < 5)
                    {
                        double truncatedTime = Math.Truncate(currentTime * 100) / 100;
                        timesList.Items.Add(truncatedTime);
                        times.Add(truncatedTime);
                        textBox.Clear();
                    }


                    else
                    {
                        // this should give an error message
                        MessageBox.Show("You can only add 5 times to your average.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Clear();
                    }
                }


                else
                {
                    //another error (when negative value)
                    MessageBox.Show("You must insert a valid number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }


            }

            else
            {
                // Error box in case the input isnt a valid float
                MessageBox.Show("You must insert a valid number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            if (times.Count() == 5)
            {
                // Find the max and min value and remove it
                double max = times.Max();
                double min = times.Min();
                times.Remove(max);
                times.Remove(min);

                //Calculate the average
                double avg = times.Average();
                double finalAvg = Math.Truncate(avg * 100) / 100;
                MessageBox.Show($"Your average is: {finalAvg}");

                // Restarts the program
                times.Clear();
                timesList.Items.Clear();
                textBox.Clear();
            }

            else
            {
                MessageBox.Show("You must have 5 times inserted", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clrList_Click(object sender, EventArgs e)
        {
            timesList.Items.Clear();
            times.Clear();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitBtn_Click(sender, e);
            }
        }
    }
}
