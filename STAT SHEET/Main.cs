using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace STAT_SHEET
{
    public partial class Main : Form
    {
        public Main()
        {
            
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        CharData[] chars;

        private void Load_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) { 
                string path = openFileDialog1.FileName;
                Console.WriteLine(path);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }
    }
}
