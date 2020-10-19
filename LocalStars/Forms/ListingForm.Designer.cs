namespace Forms
{
    partial class ListingForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 288);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProductName.Location = new System.Drawing.Point(373, 12);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(432, 56);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Product Name";
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(818, 10);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(99, 71);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(375, 94);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(521, 127);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(842, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.Location = new System.Drawing.Point(374, 266);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(131, 38);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Category";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneNumber.Location = new System.Drawing.Point(374, 225);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(521, 41);
            this.labelPhoneNumber.TabIndex = 6;
            this.labelPhoneNumber.Text = "PhoneNumber";
            // 
            // ListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 320);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListingForm";
            this.Text = "Close";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelPhoneNumber;
    }
}