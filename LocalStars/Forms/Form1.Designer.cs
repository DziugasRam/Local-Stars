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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOther = new FontAwesome.Sharp.IconButton();
            this.buttonConfectionery = new FontAwesome.Sharp.IconButton();
            this.buttonFruits = new FontAwesome.Sharp.IconButton();
            this.panelConfectionery = new System.Windows.Forms.Panel();
            this.buttonCakesAndPies = new System.Windows.Forms.Button();
            this.buttonBunsAndDonuts = new System.Windows.Forms.Button();
            this.buttonBread = new System.Windows.Forms.Button();
            this.panelOther = new System.Windows.Forms.Panel();
            this.buttonLongLasting = new System.Windows.Forms.Button();
            this.buttonHerbs = new System.Windows.Forms.Button();
            this.buttonHoney = new System.Windows.Forms.Button();
            this.panelFruits = new System.Windows.Forms.Panel();
            this.buttonCherries = new System.Windows.Forms.Button();
            this.buttonGrapes = new System.Windows.Forms.Button();
            this.buttonPlums = new System.Windows.Forms.Button();
            this.buttonPears = new System.Windows.Forms.Button();
            this.buttonApples = new System.Windows.Forms.Button();
            this.panelVegetables = new System.Windows.Forms.Panel();
            this.buttonGarlics = new System.Windows.Forms.Button();
            this.buttonPotatoes = new System.Windows.Forms.Button();
            this.buttonCucumbers = new System.Windows.Forms.Button();
            this.buttonTomatoes = new System.Windows.Forms.Button();
            this.buttonOnions = new System.Windows.Forms.Button();
            this.buttonVegetables = new FontAwesome.Sharp.IconButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSearch = new FontAwesome.Sharp.IconButton();
            this.buttonFavorite = new FontAwesome.Sharp.IconButton();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.panelSortBy = new System.Windows.Forms.Panel();
            this.buttonZA = new FontAwesome.Sharp.IconButton();
            this.buttonAZ = new FontAwesome.Sharp.IconButton();
            this.buttonHighestPrice = new FontAwesome.Sharp.IconButton();
            this.buttonLowPrice = new FontAwesome.Sharp.IconButton();
            this.buttonSortBy = new FontAwesome.Sharp.IconButton();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelConfectionery.SuspendLayout();
            this.panelOther.SuspendLayout();
            this.panelFruits.SuspendLayout();
            this.panelVegetables.SuspendLayout();
            this.panelSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Search";
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
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.buttonOther);
            this.panel1.Controls.Add(this.buttonConfectionery);
            this.panel1.Controls.Add(this.buttonFruits);
            this.panel1.Controls.Add(this.panelConfectionery);
            this.panel1.Controls.Add(this.panelOther);
            this.panel1.Controls.Add(this.panelFruits);
            this.panel1.Controls.Add(this.panelVegetables);
            this.panel1.Controls.Add(this.buttonVegetables);
            this.panel1.Location = new System.Drawing.Point(11, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 433);
            this.panel1.TabIndex = 3;
            // 
            // buttonOther
            // 
            this.buttonOther.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonOther.IconChar = FontAwesome.Sharp.IconChar.Seedling;
            this.buttonOther.IconColor = System.Drawing.Color.Black;
            this.buttonOther.IconSize = 40;
            this.buttonOther.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOther.Location = new System.Drawing.Point(-2, 199);
            this.buttonOther.Name = "buttonOther";
            this.buttonOther.Rotation = 0D;
            this.buttonOther.Size = new System.Drawing.Size(231, 69);
            this.buttonOther.TabIndex = 2;
            this.buttonOther.Text = "Other";
            this.buttonOther.UseVisualStyleBackColor = true;
            this.buttonOther.Click += new System.EventHandler(this.buttonOther_Click);
            // 
            // buttonConfectionery
            // 
            this.buttonConfectionery.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonConfectionery.IconChar = FontAwesome.Sharp.IconChar.BreadSlice;
            this.buttonConfectionery.IconColor = System.Drawing.Color.Black;
            this.buttonConfectionery.IconSize = 40;
            this.buttonConfectionery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfectionery.Location = new System.Drawing.Point(-2, 133);
            this.buttonConfectionery.Name = "buttonConfectionery";
            this.buttonConfectionery.Rotation = 0D;
            this.buttonConfectionery.Size = new System.Drawing.Size(231, 69);
            this.buttonConfectionery.TabIndex = 2;
            this.buttonConfectionery.Text = "Confectionery";
            this.buttonConfectionery.UseVisualStyleBackColor = true;
            this.buttonConfectionery.Click += new System.EventHandler(this.buttonConfectionery_Click);
            // 
            // buttonFruits
            // 
            this.buttonFruits.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonFruits.IconChar = FontAwesome.Sharp.IconChar.AppleAlt;
            this.buttonFruits.IconColor = System.Drawing.Color.Black;
            this.buttonFruits.IconSize = 40;
            this.buttonFruits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFruits.Location = new System.Drawing.Point(-2, 67);
            this.buttonFruits.Name = "buttonFruits";
            this.buttonFruits.Rotation = 0D;
            this.buttonFruits.Size = new System.Drawing.Size(231, 69);
            this.buttonFruits.TabIndex = 2;
            this.buttonFruits.Text = "Fruits";
            this.buttonFruits.UseVisualStyleBackColor = true;
            this.buttonFruits.Click += new System.EventHandler(this.buttonFruits_Click);
            // 
            // panelConfectionery
            // 
            this.panelConfectionery.BackColor = System.Drawing.Color.Transparent;
            this.panelConfectionery.Controls.Add(this.buttonCakesAndPies);
            this.panelConfectionery.Controls.Add(this.buttonBunsAndDonuts);
            this.panelConfectionery.Controls.Add(this.buttonBread);
            this.panelConfectionery.Location = new System.Drawing.Point(1, 197);
            this.panelConfectionery.Name = "panelConfectionery";
            this.panelConfectionery.Size = new System.Drawing.Size(230, 0);
            this.panelConfectionery.TabIndex = 3;
            // 
            // buttonCakesAndPies
            // 
            this.buttonCakesAndPies.Location = new System.Drawing.Point(-2, 93);
            this.buttonCakesAndPies.Name = "buttonCakesAndPies";
            this.buttonCakesAndPies.Size = new System.Drawing.Size(230, 51);
            this.buttonCakesAndPies.TabIndex = 0;
            this.buttonCakesAndPies.Text = "Cakes and pies";
            this.buttonCakesAndPies.UseVisualStyleBackColor = true;
            this.buttonCakesAndPies.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonBunsAndDonuts
            // 
            this.buttonBunsAndDonuts.Location = new System.Drawing.Point(-2, 47);
            this.buttonBunsAndDonuts.Name = "buttonBunsAndDonuts";
            this.buttonBunsAndDonuts.Size = new System.Drawing.Size(230, 51);
            this.buttonBunsAndDonuts.TabIndex = 0;
            this.buttonBunsAndDonuts.Text = "Buns and donuts";
            this.buttonBunsAndDonuts.UseVisualStyleBackColor = true;
            this.buttonBunsAndDonuts.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonBread
            // 
            this.buttonBread.Location = new System.Drawing.Point(-2, 0);
            this.buttonBread.Name = "buttonBread";
            this.buttonBread.Size = new System.Drawing.Size(230, 51);
            this.buttonBread.TabIndex = 0;
            this.buttonBread.Text = "Bread";
            this.buttonBread.UseVisualStyleBackColor = true;
            this.buttonBread.Click += new System.EventHandler(this.buttonCategory_Click);
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
            this.buttonLongLasting.Size = new System.Drawing.Size(230, 51);
            this.buttonLongLasting.TabIndex = 2;
            this.buttonLongLasting.Text = "Long lasting products";
            this.buttonLongLasting.UseVisualStyleBackColor = true;
            this.buttonLongLasting.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonHerbs
            // 
            this.buttonHerbs.Location = new System.Drawing.Point(0, 48);
            this.buttonHerbs.Name = "buttonHerbs";
            this.buttonHerbs.Size = new System.Drawing.Size(230, 51);
            this.buttonHerbs.TabIndex = 1;
            this.buttonHerbs.Text = "Herbs tea";
            this.buttonHerbs.UseVisualStyleBackColor = true;
            this.buttonHerbs.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonHoney
            // 
            this.buttonHoney.Location = new System.Drawing.Point(0, 0);
            this.buttonHoney.Name = "buttonHoney";
            this.buttonHoney.Size = new System.Drawing.Size(230, 51);
            this.buttonHoney.TabIndex = 0;
            this.buttonHoney.Text = "Honey products";
            this.buttonHoney.UseVisualStyleBackColor = true;
            this.buttonHoney.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // panelFruits
            // 
            this.panelFruits.Controls.Add(this.buttonCherries);
            this.panelFruits.Controls.Add(this.buttonGrapes);
            this.panelFruits.Controls.Add(this.buttonPlums);
            this.panelFruits.Controls.Add(this.buttonPears);
            this.panelFruits.Controls.Add(this.buttonApples);
            this.panelFruits.Location = new System.Drawing.Point(0, 133);
            this.panelFruits.Name = "panelFruits";
            this.panelFruits.Size = new System.Drawing.Size(230, 0);
            this.panelFruits.TabIndex = 3;
            // 
            // buttonCherries
            // 
            this.buttonCherries.Location = new System.Drawing.Point(-1, 93);
            this.buttonCherries.Name = "buttonCherries";
            this.buttonCherries.Size = new System.Drawing.Size(230, 49);
            this.buttonCherries.TabIndex = 0;
            this.buttonCherries.Text = "Cherries";
            this.buttonCherries.UseVisualStyleBackColor = true;
            this.buttonCherries.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonGrapes
            // 
            this.buttonGrapes.Location = new System.Drawing.Point(1, 140);
            this.buttonGrapes.Name = "buttonGrapes";
            this.buttonGrapes.Size = new System.Drawing.Size(230, 51);
            this.buttonGrapes.TabIndex = 0;
            this.buttonGrapes.Text = "Grapes";
            this.buttonGrapes.UseVisualStyleBackColor = true;
            this.buttonGrapes.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonPlums
            // 
            this.buttonPlums.Location = new System.Drawing.Point(-1, 187);
            this.buttonPlums.Name = "buttonPlums";
            this.buttonPlums.Size = new System.Drawing.Size(230, 51);
            this.buttonPlums.TabIndex = 0;
            this.buttonPlums.Text = "Plums";
            this.buttonPlums.UseVisualStyleBackColor = true;
            this.buttonPlums.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonPears
            // 
            this.buttonPears.Location = new System.Drawing.Point(0, 47);
            this.buttonPears.Name = "buttonPears";
            this.buttonPears.Size = new System.Drawing.Size(230, 49);
            this.buttonPears.TabIndex = 0;
            this.buttonPears.Text = "Pears";
            this.buttonPears.UseVisualStyleBackColor = true;
            this.buttonPears.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonApples
            // 
            this.buttonApples.Location = new System.Drawing.Point(-1, 0);
            this.buttonApples.Name = "buttonApples";
            this.buttonApples.Size = new System.Drawing.Size(230, 49);
            this.buttonApples.TabIndex = 0;
            this.buttonApples.Text = "Apples";
            this.buttonApples.UseVisualStyleBackColor = true;
            this.buttonApples.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // panelVegetables
            // 
            this.panelVegetables.Controls.Add(this.buttonGarlics);
            this.panelVegetables.Controls.Add(this.buttonPotatoes);
            this.panelVegetables.Controls.Add(this.buttonCucumbers);
            this.panelVegetables.Controls.Add(this.buttonTomatoes);
            this.panelVegetables.Controls.Add(this.buttonOnions);
            this.panelVegetables.Location = new System.Drawing.Point(0, 67);
            this.panelVegetables.Name = "panelVegetables";
            this.panelVegetables.Size = new System.Drawing.Size(230, 0);
            this.panelVegetables.TabIndex = 3;
            // 
            // buttonGarlics
            // 
            this.buttonGarlics.Location = new System.Drawing.Point(-1, 188);
            this.buttonGarlics.Name = "buttonGarlics";
            this.buttonGarlics.Size = new System.Drawing.Size(230, 51);
            this.buttonGarlics.TabIndex = 0;
            this.buttonGarlics.Text = "Garlics";
            this.buttonGarlics.UseVisualStyleBackColor = true;
            this.buttonGarlics.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonPotatoes
            // 
            this.buttonPotatoes.Location = new System.Drawing.Point(-1, 141);
            this.buttonPotatoes.Name = "buttonPotatoes";
            this.buttonPotatoes.Size = new System.Drawing.Size(230, 51);
            this.buttonPotatoes.TabIndex = 0;
            this.buttonPotatoes.Text = "Potatoes";
            this.buttonPotatoes.UseVisualStyleBackColor = true;
            this.buttonPotatoes.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonCucumbers
            // 
            this.buttonCucumbers.Location = new System.Drawing.Point(0, 93);
            this.buttonCucumbers.Name = "buttonCucumbers";
            this.buttonCucumbers.Size = new System.Drawing.Size(230, 51);
            this.buttonCucumbers.TabIndex = 0;
            this.buttonCucumbers.Text = "Cucumbers";
            this.buttonCucumbers.UseVisualStyleBackColor = true;
            this.buttonCucumbers.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonTomatoes
            // 
            this.buttonTomatoes.Location = new System.Drawing.Point(0, 47);
            this.buttonTomatoes.Name = "buttonTomatoes";
            this.buttonTomatoes.Size = new System.Drawing.Size(230, 51);
            this.buttonTomatoes.TabIndex = 0;
            this.buttonTomatoes.Text = "Tomatoes";
            this.buttonTomatoes.UseVisualStyleBackColor = true;
            this.buttonTomatoes.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonOnions
            // 
            this.buttonOnions.Location = new System.Drawing.Point(-1, 0);
            this.buttonOnions.Name = "buttonOnions";
            this.buttonOnions.Size = new System.Drawing.Size(230, 51);
            this.buttonOnions.TabIndex = 0;
            this.buttonOnions.Text = "Onions";
            this.buttonOnions.UseVisualStyleBackColor = true;
            this.buttonOnions.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonVegetables
            // 
            this.buttonVegetables.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonVegetables.IconChar = FontAwesome.Sharp.IconChar.Carrot;
            this.buttonVegetables.IconColor = System.Drawing.Color.Black;
            this.buttonVegetables.IconSize = 40;
            this.buttonVegetables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVegetables.Location = new System.Drawing.Point(-2, 0);
            this.buttonVegetables.Name = "buttonVegetables";
            this.buttonVegetables.Rotation = 0D;
            this.buttonVegetables.Size = new System.Drawing.Size(264, 92);
            this.buttonVegetables.TabIndex = 2;
            this.buttonVegetables.Text = "Vegetables";
            this.buttonVegetables.UseVisualStyleBackColor = true;
            this.buttonVegetables.Click += new System.EventHandler(this.buttonVegetables_Click);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(363, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(655, 588);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearch.IconColor = System.Drawing.Color.Black;
            this.buttonSearch.IconSize = 16;
            this.buttonSearch.Location = new System.Drawing.Point(293, 33);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Rotation = 0D;
            this.buttonSearch.Size = new System.Drawing.Size(32, 29);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonFavorite
            // 
            this.buttonFavorite.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonFavorite.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.buttonFavorite.IconColor = System.Drawing.Color.Black;
            this.buttonFavorite.IconSize = 16;
            this.buttonFavorite.Location = new System.Drawing.Point(331, 33);
            this.buttonFavorite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFavorite.Name = "buttonFavorite";
            this.buttonFavorite.Rotation = 0D;
            this.buttonFavorite.Size = new System.Drawing.Size(32, 29);
            this.buttonFavorite.TabIndex = 9;
            this.buttonFavorite.UseVisualStyleBackColor = true;
            this.buttonFavorite.Click += new System.EventHandler(this.buttonFavorite_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(3, 3);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(94, 29);
            this.buttonGoBack.TabIndex = 0;
            this.buttonGoBack.Text = "Go back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // panelSortBy
            // 
            this.panelSortBy.Controls.Add(this.buttonZA);
            this.panelSortBy.Controls.Add(this.buttonAZ);
            this.panelSortBy.Controls.Add(this.buttonHighestPrice);
            this.panelSortBy.Controls.Add(this.buttonLowPrice);
            this.panelSortBy.Controls.Add(this.buttonSortBy);
            this.panelSortBy.Location = new System.Drawing.Point(254, 105);
            this.panelSortBy.MaximumSize = new System.Drawing.Size(109, 125);
            this.panelSortBy.MinimumSize = new System.Drawing.Size(109, 25);
            this.panelSortBy.Name = "panelSortBy";
            this.panelSortBy.Size = new System.Drawing.Size(109, 25);
            this.panelSortBy.TabIndex = 10;
            // 
            // buttonZA
            // 
            this.buttonZA.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonZA.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonZA.IconColor = System.Drawing.SystemColors.Control;
            this.buttonZA.IconSize = 16;
            this.buttonZA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonZA.Location = new System.Drawing.Point(0, 99);
            this.buttonZA.Name = "buttonZA";
            this.buttonZA.Rotation = 0D;
            this.buttonZA.Size = new System.Drawing.Size(109, 29);
            this.buttonZA.TabIndex = 0;
            this.buttonZA.Text = "Z-A";
            this.buttonZA.UseVisualStyleBackColor = true;
            this.buttonZA.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonAZ
            // 
            this.buttonAZ.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonAZ.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonAZ.IconColor = System.Drawing.Color.Black;
            this.buttonAZ.IconSize = 16;
            this.buttonAZ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAZ.Location = new System.Drawing.Point(0, 73);
            this.buttonAZ.Name = "buttonAZ";
            this.buttonAZ.Rotation = 0D;
            this.buttonAZ.Size = new System.Drawing.Size(109, 29);
            this.buttonAZ.TabIndex = 0;
            this.buttonAZ.Text = "A-Z";
            this.buttonAZ.UseVisualStyleBackColor = true;
            this.buttonAZ.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonHighestPrice
            // 
            this.buttonHighestPrice.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonHighestPrice.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonHighestPrice.IconColor = System.Drawing.Color.Black;
            this.buttonHighestPrice.IconSize = 16;
            this.buttonHighestPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHighestPrice.Location = new System.Drawing.Point(0, 48);
            this.buttonHighestPrice.Name = "buttonHighestPrice";
            this.buttonHighestPrice.Rotation = 0D;
            this.buttonHighestPrice.Size = new System.Drawing.Size(109, 29);
            this.buttonHighestPrice.TabIndex = 0;
            this.buttonHighestPrice.Text = "Highest Price";
            this.buttonHighestPrice.UseVisualStyleBackColor = true;
            this.buttonHighestPrice.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonLowPrice
            // 
            this.buttonLowPrice.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonLowPrice.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonLowPrice.IconColor = System.Drawing.Color.Black;
            this.buttonLowPrice.IconSize = 16;
            this.buttonLowPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLowPrice.Location = new System.Drawing.Point(0, 23);
            this.buttonLowPrice.Name = "buttonLowPrice";
            this.buttonLowPrice.Rotation = 0D;
            this.buttonLowPrice.Size = new System.Drawing.Size(109, 29);
            this.buttonLowPrice.TabIndex = 0;
            this.buttonLowPrice.Text = "Lowest Price";
            this.buttonLowPrice.UseVisualStyleBackColor = true;
            this.buttonLowPrice.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonSortBy
            // 
            this.buttonSortBy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSortBy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonSortBy.IconColor = System.Drawing.Color.Black;
            this.buttonSortBy.IconSize = 16;
            this.buttonSortBy.Location = new System.Drawing.Point(0, 0);
            this.buttonSortBy.Name = "buttonSortBy";
            this.buttonSortBy.Rotation = 0D;
            this.buttonSortBy.Size = new System.Drawing.Size(109, 29);
            this.buttonSortBy.TabIndex = 0;
            this.buttonSortBy.Text = "Sort By";
            this.buttonSortBy.UseVisualStyleBackColor = true;
            this.buttonSortBy.Click += new System.EventHandler(this.buttonSortBy_Click);
            // 
            // timer5
            // 
            this.timer5.Interval = 20;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 588);
            this.Controls.Add(this.panelSortBy);
            this.Controls.Add(this.buttonFavorite);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonGoBack);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelConfectionery.ResumeLayout(false);
            this.panelOther.ResumeLayout(false);
            this.panelFruits.ResumeLayout(false);
            this.panelVegetables.ResumeLayout(false);
            this.panelSortBy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelVegetables;
        private System.Windows.Forms.Button buttonPotatoes;
        private System.Windows.Forms.Button buttonCucumbers;
        private System.Windows.Forms.Button buttonTomatoes;
        private System.Windows.Forms.Button buttonOnions;
        private System.Windows.Forms.Button buttonGarlics;
        private System.Windows.Forms.Panel panelFruits;
        private System.Windows.Forms.Button buttonCherries;
        private System.Windows.Forms.Button buttonGrapes;
        private System.Windows.Forms.Button buttonPlums;
        private System.Windows.Forms.Button buttonPears;
        private System.Windows.Forms.Button buttonApples;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelConfectionery;
        private System.Windows.Forms.Button buttonCakesAndPies;
        private System.Windows.Forms.Button buttonBunsAndDonuts;
        private System.Windows.Forms.Button buttonBread;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button buttonHoney;
        private System.Windows.Forms.Button buttonLongLasting;
        private System.Windows.Forms.Button buttonHerbs;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Panel panelOther;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton buttonVegetables;
        private FontAwesome.Sharp.IconButton buttonFruits;
        private FontAwesome.Sharp.IconButton buttonConfectionery;
        private FontAwesome.Sharp.IconButton buttonOther;
        private FontAwesome.Sharp.IconButton buttonSearch;
        private FontAwesome.Sharp.IconButton buttonFavorite;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Panel panelSortBy;
        private FontAwesome.Sharp.IconButton buttonLowPrice;
        private FontAwesome.Sharp.IconButton buttonSortBy;
        private FontAwesome.Sharp.IconButton buttonZA;
        private FontAwesome.Sharp.IconButton buttonAZ;
        private FontAwesome.Sharp.IconButton buttonHighestPrice;
        private System.Windows.Forms.Timer timer5;
    }
}

