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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.labelDescription.Size = new System.Drawing.Size(371, 91);
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
            // SellerListingPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel panel1;
    }
}
