using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace STAT_SHEET
{
    public partial class Main : Form
    {
        string selected;
        CharData CharSelect;
        public Main()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListChar.SelectedItem != null)
            {
                selected = ListChar.SelectedItem.ToString();
                CharSelect = Program.chars.Find(_ => _.NAME == selected);
                textBox1.Text = CharSelect.STR.ToString();
                textBox2.Text = CharSelect.DEX.ToString();
                textBox3.Text = CharSelect.VIT.ToString();
                textBox4.Text = CharSelect.INT.ToString();
                textBox5.Text = CharSelect.WIS.ToString();
                textBox6.Text = CharSelect.CHA.ToString();
                textBox7.Text = CharSelect.LUK.ToString();
            }
        }


        private void Load_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                var option = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IncludeFields = true
                };
                Program.chars = JsonSerializer.Deserialize<List<CharData>>(System.IO.File.ReadAllText(path));
            }
            refresh();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Form EditingForm = new Form1(new CharData(), this);
            EditingForm.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ListChar.Items.Clear();
            foreach (CharData CHAR in Program.chars)
            {
                ListChar.Items.Add(CHAR.NAME);
            }
        }
        public void refresh()
        {
            ListChar.Items.Clear();
            foreach (CharData CHAR in Program.chars)
            {
                ListChar.Items.Add(CHAR.NAME);
            }
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                Form EditingForm = new Form1(Program.chars.Find(x => x.NAME == selected), this);
                EditingForm.Show();
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                Program.chars.Remove(Program.chars.Find(x => x.NAME == selected));
                refresh();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JSON file | *.json";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                Program.save(path);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CharSelect.STR = int.TryParse(textBox1.Text, out int STR) ? STR : 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CharSelect.DEX = int.TryParse(textBox2.Text,out int DEX) ? DEX : 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CharSelect.VIT = int.TryParse(textBox3.Text,out int VIT) ? VIT : 0;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CharSelect.INT = int.TryParse(textBox4.Text,out int INT) ? INT : 0;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            CharSelect.WIS = int.TryParse(textBox5.Text,out int WIS) ? WIS : 0;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CharSelect.CHA = int.TryParse(textBox6.Text,out int CHA) ? CHA : 0;
        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            CharSelect.LUK = int.TryParse(textBox7.Text,out int LUK) ? LUK : 0;
        }
    }
}
