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
        string selectedChar;
        public CharData CharSelect;

        string selectedItem;
        Items ItemSelect;

        string selectSkill;
        Skill SkillSelect;
        public Main()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox12.ReadOnly = true;
            richTextBox1.ReadOnly = true;
            textBox13.ReadOnly = true;
            richTextBox2.ReadOnly = true;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListChar.SelectedItem != null)
            {
                selectedChar = ListChar.SelectedItem.ToString();
                CharSelect = Program.data.chars.Find(_ => _.NAME == selectedChar);
                textBox1.Text = CharSelect.STR.ToString();
                textBox2.Text = CharSelect.DEX.ToString();
                textBox3.Text = CharSelect.VIT.ToString();
                textBox4.Text = CharSelect.INT.ToString();
                textBox5.Text = CharSelect.WIS.ToString();
                textBox6.Text = CharSelect.CHA.ToString();
                textBox7.Text = CharSelect.LUK.ToString();
                textBox8.Text = CharSelect.HP.ToString();
                textBox9.Text = CharSelect.MP.ToString();
                textBox10.Text = CharSelect.MaxMP.ToString();
                textBox11.Text = CharSelect.MaxHP.ToString();
                richTextBox1.Text = CharSelect.DESC;
                textBox12.Text = CharSelect.NAME;
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
                textBox7.ReadOnly = false;
                textBox8.ReadOnly = false;
                textBox9.ReadOnly = false;
                textBox10.ReadOnly = false;
                textBox11.ReadOnly = false;
                textBox12.ReadOnly = false;
                richTextBox1.ReadOnly = false;
                refreshItem();
                refreshSkill();
            }
        }


        private void Load_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON Files (*.json)|*.json";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                var option = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IncludeFields = true
                };
                Loader load = new Loader(path);
                if (load.Loadable())
                {
                    Program.data = load.Data();
                }
                else 
                {
                    MessageBox.Show("File is not a valid save file");
                }
            }
            refreshAll();
        }

        public void refreshAll() {
            refreshChar();
            if (CharSelect != null)
            {
                refreshSkill();
                refreshItem();
            }
            if (manager != null)
            {
                manager.refresh();
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Program.data.chars.Add(new CharData());
            refreshChar();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ListChar.Items.Clear();
            foreach (CharData CHAR in Program.data.chars)
            {
                ListChar.Items.Add(CHAR.NAME);
            }
        }
        public void refreshChar()
        {
            ListChar.Items.Clear();
            foreach (CharData CHAR in Program.data.chars)
            {
                ListChar.Items.Add(CHAR.NAME);
            }
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox12.ReadOnly = true;
            richTextBox1.ReadOnly = true;
        }
        public void rerenderChar() {
            ListChar.Items.Clear();
            foreach (CharData CHAR in Program.data.chars)
            {
                ListChar.Items.Add(CHAR.NAME);
            }
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            if (selectedChar != null)
            {
                Program.data.chars.Remove(Program.data.chars.Find(x => x.NAME == selectedChar));
                refreshChar();
            } else
            {
                MessageBox.Show("Please select a character to remove.");
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
            CharSelect.DEX = int.TryParse(textBox2.Text, out int DEX) ? DEX : 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CharSelect.VIT = int.TryParse(textBox3.Text, out int VIT) ? VIT : 0;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CharSelect.INT = int.TryParse(textBox4.Text, out int INT) ? INT : 0;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            CharSelect.WIS = int.TryParse(textBox5.Text, out int WIS) ? WIS : 0;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CharSelect.CHA = int.TryParse(textBox6.Text, out int CHA) ? CHA : 0;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            CharSelect.LUK = int.TryParse(textBox7.Text, out int LUK) ? LUK : 0;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            CharSelect.DESC = richTextBox1.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            CharSelect.HP = int.TryParse(textBox8.Text, out int HP) ? HP : 0;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            CharSelect.MP = int.TryParse(textBox9.Text, out int MP) ? MP : 0;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            CharSelect.MaxHP = int.TryParse(textBox11.Text, out int MaxHP) ? MaxHP : 0;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            CharSelect.MaxMP = int.TryParse(textBox10.Text, out int MaxMP) ? MaxMP : 0;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            CharSelect.NAME = textBox12.Text;
            rerenderChar();
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemList.SelectedItem != null)
            {
                selectedItem = ItemList.SelectedItem.ToString();
                ItemSelect = CharSelect.ITEMS.Find(_ => _.NAME == selectedItem);
                textBox13.Text = ItemSelect.NAME;
                textBox13.ReadOnly = false;
                richTextBox2.Text = ItemSelect.DESC;
                richTextBox2.ReadOnly = false;
            }
        }

        public void refreshItem()
        {
            ItemList.Items.Clear();
            foreach (Items item in CharSelect.ITEMS)
            {
                ItemList.Items.Add(item.NAME);
            }
            textBox13.ReadOnly = true;
            richTextBox2.ReadOnly = true;
        }
        
        void rerenderItem()
        {
            ItemList.Items.Clear();
            foreach (Items item in CharSelect.ITEMS)
            {
                ItemList.Items.Add(item.NAME);
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            ItemSelect.NAME = textBox13.Text;
            rerenderItem();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            ItemSelect.DESC = richTextBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CharSelect != null)
            {
                CharSelect.ITEMS.Add(new Items());
                refreshItem();
            }
            else
            {
                MessageBox.Show("Select a character");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CharSelect != null & ItemSelect != null)
            {
                CharSelect.ITEMS.Remove(CharSelect.ITEMS.Find(x => x.NAME == selectedItem));
                refreshItem();
            }
            else
            {
                MessageBox.Show("Select a character and an item");
            }
        }

        ItemManager manager;
        private void button1_Click(object sender, EventArgs e)
        {
            if (manager == null)
            {
                (manager = new ItemManager()).Show();
            }
            else
            {
                manager.Show();
            }
        }

        private void SkillList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SkillList.SelectedItem != null)
            {
                selectSkill = SkillList.SelectedItem.ToString();
                SkillSelect = CharSelect.SKILLS.Find(_ => _.NAME == selectSkill);
                RenderSkillDetail();
            }
        }

        private void RenderSkillDetail()
        {
            textBox14.Text = SkillSelect.NAME;
            textBox14.ReadOnly = false;
            richTextBox3.Text = SkillSelect.DESC;
            richTextBox3.ReadOnly = false;
            textBox15.Text = SkillSelect.MaxCoolDown.ToString();
            textBox16.Text = SkillSelect.MaxDelay.ToString();
            textBox17.Text = SkillSelect.Delay.ToString();
            textBox18.Text = SkillSelect.CoolDown.ToString();
            textBox15.ReadOnly = false;
            textBox16.ReadOnly = false;
            textBox17.ReadOnly = false;
            textBox18.ReadOnly = false;
        }

        void refreshSkill()
        {
            SkillList.Items.Clear();
            foreach (Skill skill in CharSelect.SKILLS)
            {
                SkillList.Items.Add(skill.NAME);
            }
            textBox14.ReadOnly = true;
            richTextBox3.ReadOnly = true;
            textBox15.ReadOnly = true;
            textBox16.ReadOnly = true;
            textBox17.ReadOnly = true;
            textBox18.ReadOnly = true;
        }

        void rerenderSkill()
        {
            SkillList.Items.Clear();
            foreach (Skill skill in CharSelect.SKILLS)
            {
                SkillList.Items.Add(skill.NAME);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CharSelect != null)
            {
                CharSelect.SKILLS.Add(new Skill());
                refreshSkill();
            }
            else
            {
                MessageBox.Show("Select a character");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (SkillSelect != null)
            {
                CharSelect.SKILLS.Remove(CharSelect.SKILLS.Find(x => x.NAME == selectSkill));
                refreshSkill();
            }
            else
            {
                MessageBox.Show("Select a skill");
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            SkillSelect.NAME = textBox14.Text;
            rerenderSkill();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            SkillSelect.DESC = richTextBox3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Roll().Show();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            SkillSelect.CoolDown = int.TryParse(textBox18.Text, out int cd) ? cd > 0 ? cd : 0 : 0;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            SkillSelect.MaxCoolDown = int.TryParse(textBox15.Text, out int mcd) ? mcd > 0 ? mcd : 0 : 0;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            SkillSelect.Delay = int.TryParse(textBox17.Text, out int delay) ? delay > 0 ? delay : 0 : 0;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            SkillSelect.MaxDelay = int.TryParse(textBox16.Text, out int mdelay) ? mdelay > 0 ? mdelay : 0 : 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (SkillSelect != null)
            {
                SkillSelect.Use();
                RenderSkillDetail();
            }
            else
            {
                MessageBox.Show("Select a skill.");
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (CharSelect != null && !checkBox1.Checked)
            {
                foreach (Skill skill in CharSelect.SKILLS)
                {
                    skill.Turn();
                }
                RenderSkillDetail();
            }
            else if (checkBox1.Checked)
            {
                foreach (Skill skill in Program.data.chars.SelectMany(_ => _.SKILLS))
                {
                    skill.Turn();
                }
                RenderSkillDetail();
            }
        }
    }
}
