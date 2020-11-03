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
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace Forms
{
    public partial class SellerListingPreview : UserControl
    {
        public SellerListingPreview()
        {

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
        public Guid id
        {
            get => _guid;
            set { _guid = value;}
        }


        [Category("Custom Properties")]
        public string Price
        {
            get => _price;
            set { _price = value; labelPrice.Text = $"{value} €"; }
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
        public bool IsLikedProduct { 
            get {
                return Controllers.BuyerController.IsLikedProduct(_currentBuyer.Id, Controllers.ProductController.Get(id));
            }
            private set { 
            
                if(value)
                { 
                    Controllers.BuyerController.AddLikedProduct(_currentBuyer.Id, Controllers.ProductController.Get(id)); 
                }
                else
                {
                    Controllers.BuyerController.RemoveLikedProduct(_currentBuyer.Id, Controllers.ProductController.Get(id));
                }
            }
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

        private void SellerListingPreview_MouseClick(object sender, MouseEventArgs e)
        {
            var reader = new StreamReader("SystemColors.txt");
            try
            {
                var option = reader.ReadLine();
                var listingForm = new ListingForm(_name, _price, _desctiption, _category, _picture, PhoneNumber);
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
            IsLikedProduct = !IsLikedProduct;
            iconFavorite.IconChar = IsLikedProduct ? FontAwesome.Sharp.IconChar.Heartbeat : FontAwesome.Sharp.IconChar.Heart;

        }

        private void Form_Load(object sender, EventArgs e)
        {
            iconFavorite.IconChar = IsLikedProduct ? FontAwesome.Sharp.IconChar.Heartbeat : FontAwesome.Sharp.IconChar.Heart;
        }

    }
}
