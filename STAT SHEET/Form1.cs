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
        int str, dex, vit, intel, wis, cha, luk = 10;
        string name;
        public Form1(CharData CHAR)
        {
            str = CHAR.STR;
            dex = CHAR.DEX;
            vit = CHAR.VIT;
            intel = CHAR.INT;
            wis = CHAR.WIS;
            cha = CHAR.CHA;
            luk = CHAR.LUK;
            InitializeComponent();
        }

        private void STR_TextChanged(object sender, EventArgs e)
        {
            if (STR.Text != "")
            {
                str = Convert.ToInt32(STR.Text);
                STRB.Text = ((str - 10) / 2).ToString();
            }
        }

        private void DEX_TextChanged(object sender, EventArgs e)
        {
            if (DEX.Text != "")
            {
                dex = Convert.ToInt32(DEX.Text);
                DEXB.Text = ((dex - 10) / 2).ToString();
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
            name = textBox1.Text;
        }

        private void VIT_TextChanged(object sender, EventArgs e)
        {
            if (VIT.Text != "")
            {
                vit = Convert.ToInt32(VIT.Text);
                VITB.Text = ((vit - 10) / 2).ToString();
            }
        }

        private void INT_TextChanged(object sender, EventArgs e)
        {
            if (INT.Text != "")
            {
                intel = Convert.ToInt32(INT.Text);
                INTB.Text = ((intel - 10) / 2).ToString();
            }
        }

        private void WIS_TextChanged(object sender, EventArgs e)
        {
            if (WIS.Text != "")
            {
                wis = Convert.ToInt32(WIS.Text);
                WISB.Text = ((wis - 10) / 2).ToString();
            }
        }

        private void CHA_TextChanged(object sender, EventArgs e)
        {
            if (CHA.Text != "")
            {
                cha = Convert.ToInt32(CHA.Text);
                CHAB.Text = ((cha - 10) / 2).ToString();
            }
        }

        private void LUK_TextChanged(object sender, EventArgs e)
        {
            if (LUK.Text != "")
            {
                luk = Convert.ToInt32(LUK.Text);
                LUKB.Text = ((luk - 10) / 2).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 roll = new Form2();
            roll.Show();
        }
    }
}
