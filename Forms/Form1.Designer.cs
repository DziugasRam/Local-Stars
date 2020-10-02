using Forms.Properties;

namespace Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelConfectionery = new System.Windows.Forms.Panel();
            this.buttonCakesAndPies = new System.Windows.Forms.Button();
            this.buttonBunsAndDonuts = new System.Windows.Forms.Button();
            this.buttonBread = new System.Windows.Forms.Button();
            this.panelOther = new System.Windows.Forms.Panel();
            this.buttonLongLasting = new System.Windows.Forms.Button();
            this.buttonHerbs = new System.Windows.Forms.Button();
            this.buttonHoney = new System.Windows.Forms.Button();
            this.buttonOther = new System.Windows.Forms.Button();
            this.buttonConfectionery = new System.Windows.Forms.Button();
            this.panelFruits = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.buttonFruits = new System.Windows.Forms.Button();
            this.panelVegetables = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelConfectionery.SuspendLayout();
            this.panelOther.SuspendLayout();
            this.panelFruits.SuspendLayout();
            this.panelVegetables.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Search";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(394, 35);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(506, 497);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panelConfectionery);
            this.panel1.Controls.Add(this.panelOther);
            this.panel1.Controls.Add(this.buttonOther);
            this.panel1.Controls.Add(this.buttonConfectionery);
            this.panel1.Controls.Add(this.panelFruits);
            this.panel1.Controls.Add(this.buttonFruits);
            this.panel1.Controls.Add(this.panelVegetables);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(52, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 421);
            this.panel1.TabIndex = 3;
            // 
            // panelConfectionery
            // 
            this.panelConfectionery.BackColor = System.Drawing.Color.Transparent;
            this.panelConfectionery.Controls.Add(this.buttonCakesAndPies);
            this.panelConfectionery.Controls.Add(this.buttonBunsAndDonuts);
            this.panelConfectionery.Controls.Add(this.buttonBread);
            this.panelConfectionery.Location = new System.Drawing.Point(1, 198);
            this.panelConfectionery.Name = "panelConfectionery";
            this.panelConfectionery.Size = new System.Drawing.Size(230, 0);
            this.panelConfectionery.TabIndex = 3;
            // 
            // buttonCakesAndPies
            // 
            this.buttonCakesAndPies.Location = new System.Drawing.Point(-2, 94);
            this.buttonCakesAndPies.Name = "buttonCakesAndPies";
            this.buttonCakesAndPies.Size = new System.Drawing.Size(230, 50);
            this.buttonCakesAndPies.TabIndex = 0;
            this.buttonCakesAndPies.Text = "Cakes and pies";
            this.buttonCakesAndPies.UseVisualStyleBackColor = true;
            // 
            // buttonBunsAndDonuts
            // 
            this.buttonBunsAndDonuts.Location = new System.Drawing.Point(-2, 47);
            this.buttonBunsAndDonuts.Name = "buttonBunsAndDonuts";
            this.buttonBunsAndDonuts.Size = new System.Drawing.Size(230, 50);
            this.buttonBunsAndDonuts.TabIndex = 0;
            this.buttonBunsAndDonuts.Text = "Buns and donuts";
            this.buttonBunsAndDonuts.UseVisualStyleBackColor = true;
            // 
            // buttonBread
            // 
            this.buttonBread.Location = new System.Drawing.Point(-2, 0);
            this.buttonBread.Name = "buttonBread";
            this.buttonBread.Size = new System.Drawing.Size(230, 50);
            this.buttonBread.TabIndex = 0;
            this.buttonBread.Text = "Bread";
            this.buttonBread.UseVisualStyleBackColor = true;
            // 
            // panelOther
            // 
            this.panelOther.BackColor = System.Drawing.Color.Transparent;
            this.panelOther.Controls.Add(this.buttonLongLasting);
            this.panelOther.Controls.Add(this.buttonHerbs);
            this.panelOther.Controls.Add(this.buttonHoney);
            this.panelOther.Location = new System.Drawing.Point(1, 268);
            this.panelOther.Name = "panelOther";
            this.panelOther.Size = new System.Drawing.Size(231, 0);
            this.panelOther.TabIndex = 3;
            // 
            // buttonLongLasting
            // 
            this.buttonLongLasting.Location = new System.Drawing.Point(-1, 96);
            this.buttonLongLasting.Name = "buttonLongLasting";
            this.buttonLongLasting.Size = new System.Drawing.Size(230, 50);
            this.buttonLongLasting.TabIndex = 2;
            this.buttonLongLasting.Text = "Long lasting products";
            this.buttonLongLasting.UseVisualStyleBackColor = true;
            // 
            // buttonHerbs
            // 
            this.buttonHerbs.Location = new System.Drawing.Point(0, 48);
            this.buttonHerbs.Name = "buttonHerbs";
            this.buttonHerbs.Size = new System.Drawing.Size(230, 50);
            this.buttonHerbs.TabIndex = 1;
            this.buttonHerbs.Text = "Herbs tea";
            this.buttonHerbs.UseVisualStyleBackColor = true;
            // 
            // buttonHoney
            // 
            this.buttonHoney.Location = new System.Drawing.Point(0, 0);
            this.buttonHoney.Name = "buttonHoney";
            this.buttonHoney.Size = new System.Drawing.Size(230, 50);
            this.buttonHoney.TabIndex = 0;
            this.buttonHoney.Text = "Honey products";
            this.buttonHoney.UseVisualStyleBackColor = true;
            // 
            // buttonOther
            // 
            this.buttonOther.Location = new System.Drawing.Point(-1, 199);
            this.buttonOther.Name = "buttonOther";
            this.buttonOther.Size = new System.Drawing.Size(231, 69);
            this.buttonOther.TabIndex = 2;
            this.buttonOther.Text = "Other";
            this.buttonOther.UseVisualStyleBackColor = true;
            this.buttonOther.Click += new System.EventHandler(this.buttonOther_Click);
            // 
            // buttonConfectionery
            // 
            this.buttonConfectionery.Location = new System.Drawing.Point(-1, 133);
            this.buttonConfectionery.Name = "buttonConfectionery";
            this.buttonConfectionery.Size = new System.Drawing.Size(231, 69);
            this.buttonConfectionery.TabIndex = 2;
            this.buttonConfectionery.Text = "Confectionery";
            this.buttonConfectionery.UseVisualStyleBackColor = true;
            this.buttonConfectionery.Click += new System.EventHandler(this.buttonConfectionery_Click);
            // 
            // panelFruits
            // 
            this.panelFruits.Controls.Add(this.button8);
            this.panelFruits.Controls.Add(this.button9);
            this.panelFruits.Controls.Add(this.button10);
            this.panelFruits.Controls.Add(this.button11);
            this.panelFruits.Controls.Add(this.button12);
            this.panelFruits.Location = new System.Drawing.Point(0, 133);
            this.panelFruits.Name = "panelFruits";
            this.panelFruits.Size = new System.Drawing.Size(230, 0);
            this.panelFruits.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(-1, 94);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(230, 49);
            this.button8.TabIndex = 0;
            this.button8.Text = "Cheries";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1, 140);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(230, 50);
            this.button9.TabIndex = 0;
            this.button9.Text = "Grapes";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(-1, 187);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(230, 50);
            this.button10.TabIndex = 0;
            this.button10.Text = "Plums";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(0, 47);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(230, 49);
            this.button11.TabIndex = 0;
            this.button11.Text = "Pears";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(-1, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(230, 49);
            this.button12.TabIndex = 0;
            this.button12.Text = "Apples";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // buttonFruits
            // 
            this.buttonFruits.Location = new System.Drawing.Point(0, 67);
            this.buttonFruits.Name = "buttonFruits";
            this.buttonFruits.Size = new System.Drawing.Size(231, 69);
            this.buttonFruits.TabIndex = 2;
            this.buttonFruits.Text = "Fruits";
            this.buttonFruits.UseVisualStyleBackColor = true;
            this.buttonFruits.Click += new System.EventHandler(this.buttonFruits_Click);
            // 
            // panelVegetables
            // 
            this.panelVegetables.Controls.Add(this.button6);
            this.panelVegetables.Controls.Add(this.button5);
            this.panelVegetables.Controls.Add(this.button4);
            this.panelVegetables.Controls.Add(this.button3);
            this.panelVegetables.Controls.Add(this.button2);
            this.panelVegetables.Location = new System.Drawing.Point(0, 67);
            this.panelVegetables.Name = "panelVegetables";
            this.panelVegetables.Size = new System.Drawing.Size(230, 0);
            this.panelVegetables.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(-1, 188);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(230, 50);
            this.button6.TabIndex = 0;
            this.button6.Text = "Garlics";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-1, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 50);
            this.button5.TabIndex = 0;
            this.button5.Text = "Potatoes";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "Cucumbers";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 50);
            this.button3.TabIndex = 0;
            this.button3.Text = "Tomatoes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-1, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "Onions";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vegetables";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 20;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 20;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(280, 34);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(28, 28);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 588);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelConfectionery.ResumeLayout(false);
            this.panelOther.ResumeLayout(false);
            this.panelFruits.ResumeLayout(false);
            this.panelVegetables.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelVegetables;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonFruits;
        private System.Windows.Forms.Panel panelFruits;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelConfectionery;
        private System.Windows.Forms.Button buttonCakesAndPies;
        private System.Windows.Forms.Button buttonBunsAndDonuts;
        private System.Windows.Forms.Button buttonBread;
        private System.Windows.Forms.Button buttonConfectionery;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button buttonOther;
        private System.Windows.Forms.Button buttonHoney;
        private System.Windows.Forms.Button buttonLongLasting;
        private System.Windows.Forms.Button buttonHerbs;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Panel panelOther;
        private System.Windows.Forms.Button buttonSearch;
    }
}

