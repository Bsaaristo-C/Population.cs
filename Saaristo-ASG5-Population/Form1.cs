using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saaristo_ASG5_Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculatePopulation_Click(object sender, EventArgs e)
        {
            double outputSum = 0.0;
            int numOfDaysLocal = 1;
            listBoxOutput.Items.Add("Population Start: " + textBoxOrganismInput.ToString() + "   Daily Increase: " + textBoxPercentDailyIncrease.ToString() + "%  Number of Days: " + textBoxNumberOfDays.ToString());
            listBoxOutput.Items.Add(" ");
            listBoxOutput.Items.Add("Day\tTotal");
            for (int i = 0; i < int.Parse(textBoxNumberOfDays.Text); i++)
            {
                outputSum = int.Parse(textBoxOrganismInput.Text);
                listBoxOutput.Items.Add(numOfDaysLocal + "\t" + outputSum.ToString());
                outputSum = int.Parse(textBoxOrganismInput.Text) + (int.Parse(textBoxOrganismInput.Text) * int.Parse(textBoxPercentDailyIncrease.Text) / 100);
                numOfDaysLocal++;
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBoxNumberOfDays.Text = null;
            textBoxOrganismInput.Text = null;
            textBoxPercentDailyIncrease.Text = null;
            listBoxOutput.Items.Clear();
        }

        private void buttonDefaultValues_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            if (textBoxNumberOfDays.Text == "" || textBoxOrganismInput.Text == "" || textBoxPercentDailyIncrease.Text == "")
            {
                textBoxNumberOfDays.Text = 5.ToString();
                textBoxOrganismInput.Text = 1000.ToString();
                textBoxPercentDailyIncrease.Text = 10.ToString();
            }
        }
    }
}
