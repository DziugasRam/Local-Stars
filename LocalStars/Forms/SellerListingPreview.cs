using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server;

namespace Forms
{
    public partial class SellerListingPreview : UserControl
    {
        public SellerListingPreview()
        {
           /* foreach (var product in CurrentBuyer.FavoriteProducts)
            {
                if (guid == product.Id)
                {
                    iconFavorite.IconChar =FontAwesome.Sharp.IconChar.HeartBroken;
                }
            }*/
            InitializeComponent();

        }

        #region Properties

        private string name;
        private Guid guid;
        private string price;
        private string category;
        private string desctiption;
        private Image picture;
        Buyer CurrentBuyer = Controllers.s_buyerController.GetById(MockData.User1.AssociatedBuyer.Value);

        [Category("Custom Properties")]
        public string Name1
        {
            get => name;
            set { name = value; labelPName.Text = value; }
        }

        [Category("Custom Properties")]
        public Guid Guid
        {
            get => guid;
            set { guid = value;}
        }


        [Category("Custom Properties")]
        public string Price
        {
            get => price;
            set { price = value; labelPrice.Text = value; }
        }

        [Category("Custom Properties")]
        public string Description
        {
            get => desctiption;
            set { desctiption = value; labelDescription.Text = value; }
        }

        [Category("Custom Properties")]
        public string Category
        {
            get => category;
            set { category = value; labelCategory.Text = value; }
        }

        [Category("Custom Properties")]
        public Image Picture
        {
            get => picture;
            set { picture = value; pictureBox1.Image = value; }
        }

        [Category("Custom Properties")]
        public int MouseClickCount { get; private set; } = 0;

        #endregion

        private void SellerListingPreview_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void SellerListingPreview_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void SellerListingPreview_MouseClick(object sender, MouseEventArgs e)
        {
            var listingForm = new ListingForm(labelPName.Text, labelPrice.Text, labelDescription.Text ,labelCategory.Text, pictureBox1.Image);
            listingForm.Show();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

            MouseClickCount++;
            if(MouseClickCount % 2 != 0)
            {
                iconFavorite.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
                Controllers.s_buyerController.AddLikedProduct(CurrentBuyer.Id, Controllers.s_productController.Get(Guid));
            }
            else
            {
                iconFavorite.IconChar = FontAwesome.Sharp.IconChar.Heart;
                Controllers.s_buyerController.RemoveLikedProduct(CurrentBuyer.Id, Controllers.s_productController.Get(Guid));
            }
          
        }
    }
}
