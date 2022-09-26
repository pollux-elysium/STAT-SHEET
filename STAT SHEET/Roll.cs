using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STAT_SHEET
{
    public partial class Roll : Form
    {
        Random rand = new Random();
        public Roll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((1 + rand.Next(4)).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((1 + rand.Next(6)).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show((1 + rand.Next(8)).ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show((1 + rand.Next(10)).ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show((1 + rand.Next(12)).ToString());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show((1 + rand.Next(16)).ToString());

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show((1 + rand.Next(20)).ToString());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show((1 + rand.Next(24)).ToString());

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show((1 + rand.Next(100)).ToString());

        }

        private void button10_Click(object sender, EventArgs e)
        {
            double value = rand.NextDouble();
            bool sign = value > 0.5;
        
            double lvalue = Math.Log10(-2 * Math.Abs(value - 0.5) + 1) * (sign?-1:1);
            MessageBox.Show("Result: " + lvalue.ToString() + "\nRaw roll:" + value.ToString());
        }
    }
}
