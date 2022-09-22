namespace STAT_SHEET
{
    partial class ItemManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ItemList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 43);
            this.button3.TabIndex = 44;
            this.button3.Text = "New";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(461, 115);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(517, 459);
            this.richTextBox2.TabIndex = 43;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(461, 74);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(517, 35);
            this.textBox13.TabIndex = 42;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 43);
            this.button2.TabIndex = 41;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.ItemHeight = 29;
            this.ItemList.Location = new System.Drawing.Point(34, 74);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(393, 497);
            this.ItemList.TabIndex = 40;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(517, 43);
            this.button1.TabIndex = 45;
            this.button1.Text = "Add to selected character";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ItemManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ItemList);
            this.Name = "ItemManager";
            this.Text = "Item Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.Button button1;
    }
}