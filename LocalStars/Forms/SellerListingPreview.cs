using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
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

        private string _name;
        private Guid _guid;
        private string _price;
        private string _category;
        private string _desctiption;
        private Image _picture;
        private readonly Buyer _currentBuyer = Controllers.CurrentBuyer;

        public string PhoneNumber { get; set; }

        [Category("Custom Properties")]
        public string Name1
        {
            get => _name;
            set { _name = value; labelPName.Text = value; }
        }

        [Category("Custom Properties")]
        public Guid Guid
        {
            get => _guid;
            set { _guid = value;}
        }


        [Category("Custom Properties")]
        public string Price
        {
            get => _price;
            set { _price = value; labelPrice.Text = value; }
        }

        [Category("Custom Properties")]
        public string Description
        {
            get => _desctiption;
            set { _desctiption = value; labelDescription.Text = value; }
        }

        [Category("Custom Properties")]
        public string Category
        {
            get => _category;
            set { _category = value; labelCategory.Text = value; }
        }

        [Category("Custom Properties")]
        public Image Picture
        {
            get => _picture;
            set { _picture = value; pictureBox1.Image = value; }
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
            var reader = new StreamReader("SystemColors.txt");
            try
            {
                var option = reader.ReadLine();
                var listingForm = new ListingForm(labelPName.Text, labelPrice.Text, labelDescription.Text, labelCategory.Text, pictureBox1.Image, PhoneNumber) {BackColor = Color.FromName(option)};
                listingForm.Show();
            }
            catch (IOException exception)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(exception.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

            MouseClickCount++;
            if(MouseClickCount % 2 != 0)
            {
                iconFavorite.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
                Controllers.BuyerController.AddLikedProduct(_currentBuyer.Id, Controllers.ProductController.Get(Guid));
            }
            else
            {
                iconFavorite.IconChar = FontAwesome.Sharp.IconChar.Heart;
                Controllers.BuyerController.RemoveLikedProduct(_currentBuyer.Id, Controllers.ProductController.Get(Guid));
            }
          
        }
    }
}
