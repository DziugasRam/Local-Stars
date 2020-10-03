using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class SellerListingPreview : UserControl
    {
        public SellerListingPreview()
        {
            InitializeComponent();
        }

        #region Properties

        private string name;
        private string price;
        private string desctiption;
        private Image picture;

        [Category("Custom Properties")]
        public string Name
        {
            get { return name; }
            set { name = value; labelPName.Text = value; }
        }

        [Category("Custom Properties")]
        public string Price
        {
            get { return price; }
            set { price = value; labelPrice.Text = value; }
        }

        [Category("Custom Properties")]
        public string Desciption
        {
            get { return desctiption; }
            set { desctiption = value; labelDescription.Text = value; }
        }

        [Category("Custom Properties")]
        public Image Picture
        {
            get { return picture; }
            set { picture = value; pictureBox1.Image = value; }
        }

        #endregion

        private void SellerListingPreview_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void SellerListingPreview_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
