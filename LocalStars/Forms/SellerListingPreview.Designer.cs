using FontAwesome.Sharp;

namespace Forms
{
    partial class SellerListingPreview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconFavorite = new FontAwesome.Sharp.IconPictureBox();
            this.labelCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SellerListingPreview_MouseClick);
            // 
            // labelPName
            // 
            this.labelPName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPName.Location = new System.Drawing.Point(153, 9);
            this.labelPName.Name = "labelPName";
            this.labelPName.Size = new System.Drawing.Size(225, 23);
            this.labelPName.TabIndex = 1;
            this.labelPName.Text = "Product Name";
            this.labelPName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SellerListingPreview_MouseClick);
            this.labelPName.MouseEnter += new System.EventHandler(this.SellerListingPreview_MouseEnter);
            this.labelPName.MouseLeave += new System.EventHandler(this.SellerListingPreview_MouseLeave);
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(153, 32);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(239, 23);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            this.labelPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SellerListingPreview_MouseClick);
            this.labelPrice.MouseEnter += new System.EventHandler(this.SellerListingPreview_MouseEnter);
            this.labelPrice.MouseLeave += new System.EventHandler(this.SellerListingPreview_MouseLeave);
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(153, 55);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(371, 65);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description";
            this.labelDescription.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SellerListingPreview_MouseClick);
            this.labelDescription.MouseEnter += new System.EventHandler(this.SellerListingPreview_MouseEnter);
            this.labelDescription.MouseLeave += new System.EventHandler(this.SellerListingPreview_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(153, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 1);
            this.panel1.TabIndex = 2;
            // 
            // iconFavorite
            // 
            this.iconFavorite.BackColor = System.Drawing.Color.Transparent;
            this.iconFavorite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconFavorite.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.iconFavorite.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconFavorite.IconSize = 51;
            this.iconFavorite.Location = new System.Drawing.Point(460, 9);
            this.iconFavorite.Name = "iconFavorite";
            this.iconFavorite.Size = new System.Drawing.Size(64, 51);
            this.iconFavorite.TabIndex = 3;
            this.iconFavorite.TabStop = false;
            this.iconFavorite.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.Location = new System.Drawing.Point(155, 120);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(73, 21);
            this.labelCategory.TabIndex = 4;
            this.labelCategory.Text = "Category";
            this.labelCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SellerListingPreview_MouseClick);
            this.labelCategory.MouseEnter += new System.EventHandler(this.SellerListingPreview_MouseEnter);
            this.labelCategory.MouseLeave += new System.EventHandler(this.SellerListingPreview_MouseLeave);
            // 
            // SellerListingPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.iconFavorite);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SellerListingPreview";
            this.Size = new System.Drawing.Size(540, 154);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SellerListingPreview_MouseClick);
            this.MouseEnter += new System.EventHandler(this.SellerListingPreview_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SellerListingPreview_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFavorite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconFavorite;
        private System.Windows.Forms.Label labelCategory;
    }
}
