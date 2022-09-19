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
    public partial class Form1 : Form
    {
        CharData CHAR;
        Main Caller;
        public Form1(CharData INPUT, Main caller)
        {
            CHAR = INPUT;
            Caller = caller;
            InitializeComponent();
            STR.Text = CHAR.STR.ToString();
            DEX.Text = CHAR.DEX.ToString();
            VIT.Text = CHAR.VIT.ToString();
            INT.Text = CHAR.INT.ToString();
            WIS.Text = CHAR.WIS.ToString();
            CHA.Text = CHAR.CHA.ToString();
            LUK.Text = CHAR.LUK.ToString();
            textBox1.Text = CHAR.NAME;
            richTextBox1.Text = CHAR.DESC;
        }

        private void STR_TextChanged(object sender, EventArgs e)
        {
            if (STR.Text != "")
            {
                CHAR.STR = Convert.ToInt32(STR.Text);
                STRB.Text = ((CHAR.STR - 10) / 2).ToString();
            }
        }

        private void DEX_TextChanged(object sender, EventArgs e)
        {
            if (DEX.Text != "")
            {
                CHAR.DEX = Convert.ToInt32(DEX.Text);
                DEXB.Text = ((CHAR.DEX - 10) / 2).ToString();
            }
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            Calc_Out.Text = Program.eval(Calculator.Text).ToString();
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            Calc_Click(this, e);
        }

        private void STRB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CHAR.NAME = textBox1.Text;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Program.chars.Any(_ => _.NAME == CHAR.NAME))
            {
                Program.chars[Program.chars.FindIndex(_ => _.NAME == CHAR.NAME)] = CHAR;
            }
            else
            {
                Program.chars.Add(CHAR);
            }
            Caller.refresh();
        }

        private void VIT_TextChanged(object sender, EventArgs e)
        {
            if (VIT.Text != "")
            {
                CHAR.VIT = Convert.ToInt32(VIT.Text);
                VITB.Text = ((CHAR.VIT - 10) / 2).ToString();
            }
        }

        private void INT_TextChanged(object sender, EventArgs e)
        {
            if (INT.Text != "")
            {
                CHAR.INT = Convert.ToInt32(INT.Text);
                INTB.Text = ((CHAR.INT - 10) / 2).ToString();
            }
        }

        private void WIS_TextChanged(object sender, EventArgs e)
        {
            if (WIS.Text != "")
            {
                CHAR.WIS = Convert.ToInt32(WIS.Text);
                WISB.Text = ((CHAR.WIS - 10) / 2).ToString();
            }
        }

        private void CHA_TextChanged(object sender, EventArgs e)
        {
            if (CHA.Text != "")
            {
                CHAR.CHA = Convert.ToInt32(CHA.Text);
                CHAB.Text = ((CHAR.CHA - 10) / 2).ToString();
            }
        }

        private void LUK_TextChanged(object sender, EventArgs e)
        {
            if (LUK.Text != "")
            {
                CHAR.LUK = Convert.ToInt32(LUK.Text);
                LUKB.Text = ((CHAR.LUK - 10) / 2).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 roll = new Form2();
            roll.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            CHAR.DESC = richTextBox1.Text;
        }
    }
}
