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
    public partial class ItemManager : Form
    {
        Items selected;
        string name;
        public ItemManager()
        {
            InitializeComponent();
            ItemList.Items.Clear();
            foreach (Items item in Program.data.items)
            {
                ItemList.Items.Add(item.NAME);
            }
            textBox13.ReadOnly = true;
            richTextBox2.ReadOnly = true;
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemList.SelectedItem != null)
            {
                name = ItemList.SelectedItem.ToString();
                selected = Program.data.items.Find(_=>_.NAME==name);
                textBox13.Text = selected.NAME;
                richTextBox2.Text = selected.DESC;
            }
            textBox13.ReadOnly = false;
            richTextBox2.ReadOnly = false;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            selected.NAME = textBox13.Text;
            rerender();
        }

        public void refresh() {
            ItemList.Items.Clear();
            foreach (Items item in Program.data.items)
            {
                ItemList.Items.Add(item.NAME);
            }
            textBox13.ReadOnly = true;
            richTextBox2.ReadOnly = true;
        }

        void rerender()
        {
            ItemList.Items.Clear();
            foreach (Items item in Program.data.items)
            {
                ItemList.Items.Add(item.NAME);
            }
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            selected.DESC = richTextBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.data.items.Add(new Items());
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                Program.data.items.Remove(selected);
                refresh();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (selected != null & Program.main.CharSelect!=null)
            {
                Program.main.CharSelect.ITEMS.Add(new Items() {NAME=selected.NAME,DESC=selected.DESC });
                Program.main.refreshItem();
            }
        }
    }
}
