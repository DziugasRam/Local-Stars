using Forms.Properties;
using Models;
using Server;
using Server.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        private bool IsPanelVegetablesOpen = false;
        private bool IsPaneFruitsOpen = false;
        private bool IsPanelConfectioneryOpen = false;
        private bool IsPanelOtherOpen = false;
        private bool IsPanelSortByOpen = false;
        private bool IsButtonFavoritesClicked = false;
        Buyer CurrentBuyer = Controllers.CurrentBuyer;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsPanelVegetablesOpen)
            {
                panelVegetables.Height -= 21;
                if (panelVegetables.Height > 0) return;
                panelVegetables.SendToBack();
                timer1.Stop();
                IsPanelVegetablesOpen = false;
                buttonVegetables.BackColor = Color.Empty;
            }
            else if (!IsPanelVegetablesOpen)
            {
                panelVegetables.BringToFront();
                panelVegetables.Height += 21;
                if (panelVegetables.Height < 351) return;
                timer1.Stop();
                IsPanelVegetablesOpen = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (IsPaneFruitsOpen)
            {
                panelFruits.Height -= 21;
                if (panelFruits.Height > 0) return;
                panelFruits.SendToBack();
                IsPaneFruitsOpen = false;
                timer2.Stop();
                buttonFruits.BackColor = Color.Empty;
            }
            else
            {
                panelFruits.BringToFront();
                panelFruits.Height += 21;
                if (panelFruits.Height < 282) return;
                IsPaneFruitsOpen = true;
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (IsPanelConfectioneryOpen)
            {
                panelConfectionery.Height -= 21;
                if (panelConfectionery.Height != 0) return;
                IsPanelConfectioneryOpen = false;
                panelConfectionery.SendToBack();
                timer3.Stop();
                buttonConfectionery.BackColor = Color.Empty;
            }
            else
            {
                panelConfectionery.BringToFront();
                panelConfectionery.Height += 21;
                if (panelConfectionery.Height < 213) return;
                IsPanelConfectioneryOpen = true;
                timer3.Stop();
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (IsPanelOtherOpen)
            {
                panelOther.Height -= 20;
                if (panelOther.Height > 0) return;
                IsPanelOtherOpen = false;
                panelOther.SendToBack();
                timer4.Stop();
                buttonOther.BackColor = Color.Empty;
            }
            else
            {
                panelOther.BringToFront();
                panelOther.Height += 20;
                if (panelOther.Height < 150) return;
                IsPanelOtherOpen = true;
                timer4.Stop();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (!IsPanelSortByOpen)
            {
                panelSortBy.Height += 10;
                if (panelSortBy.Size != panelSortBy.MaximumSize) return;
                timer5.Stop();
                IsPanelSortByOpen = true;
            }
            else
            {
                panelSortBy.Height -= 10;
                if (panelSortBy.Size != panelSortBy.MinimumSize) return;
                timer5.Stop();
                IsPanelSortByOpen = false;
            }
        }

        private void buttonVegetables_Click(object sender, EventArgs e)
        {
            timer1.Start();
            setVegetableButtonColor();
        }

        private void buttonFruits_Click(object sender, EventArgs e)
        {
            timer2.Start();
            setFruitButtonColor();
        }

        private void buttonConfectionery_Click(object sender, EventArgs e)
        {
            timer3.Start();
            setConfectionaryButtonColor();
        }

        private void buttonOther_Click(object sender, EventArgs e)
        {
            timer4.Start();
            setOtherButtonColor();
        }

        private void buttonSortBy_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void PopulateList()
        {
            var products = Controllers.ProductController.Get();
            var viewmodel = products.Select(MapToSellerListingPreview);
            flowLayoutPanel1.Controls.AddRange(viewmodel.ToArray());
        }

        private Control MapToSellerListingPreview(Product product, int arg2)
        {
            var viewmodel = new SellerListingPreview
            {
                Name1 = product.Title,
                Guid = product.Id,
                Description = product.Description,
                Price = product.Price.ToString(),
                Category = product.Category,
                Picture = Resources.missing_image,
                PhoneNumber = product.Seller.PhoneNumber
            };

            return viewmodel;
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            var productViewModels = flowLayoutPanel1.Controls.Cast<SellerListingPreview>();

            foreach (var product in productViewModels)
            {
                if (product.Category == btn.Text)
                {
                    product.Show();
                }
                else
                {
                    product.Hide();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var productViewModels = flowLayoutPanel1.Controls.Cast<SellerListingPreview>();
            foreach (var product in productViewModels)
            {
                if (product.Name1.Contains(textBox1.Text) ||
                    product.Description.Contains(textBox1.Text))
                {
                    product.Show();
                }
                else
                {
                    product.Hide();
                }
            }
        }

        private void buttonFavorite_Click(object sender, EventArgs e)
        {
            var productViewModels = flowLayoutPanel1.Controls.Cast<SellerListingPreview>();

            if (!IsButtonFavoritesClicked)
            {
                foreach (var product in productViewModels)
                {
                    product.Hide();
                    foreach (var favProduct in CurrentBuyer.BuyerProducts)
                    {
                        if (product.Guid == favProduct.ProductId)
                        {
                            product.Show();
                        }
                    }
                }
                IsButtonFavoritesClicked = true;
            }
            else
            {
                foreach (var product in productViewModels)
                {
                    product.Show();
                }
                IsButtonFavoritesClicked = false;
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
          
            var btn = sender as Button;
            var sortedProducts = flowLayoutPanel1.Controls.Cast<SellerListingPreview>();
            hide_Products();

            switch(btn.Text)
            {
                case "Lowest Price":
                    sortedProducts = sortedProducts.OrderBy(o => o.Price);
                    break;
                case "Highest Price":
                    sortedProducts = sortedProducts.OrderByDescending(o => o.Price);
                    break;
                case "A-Z":
                    sortedProducts = sortedProducts.OrderBy(o => o.Name1);
                    break;
                case "Z-A":
                    sortedProducts = sortedProducts.OrderByDescending(o => o.Name1);
                    break;
            }
           

            flowLayoutPanel1.Controls.AddRange(sortedProducts.ToArray());

            foreach (var product in sortedProducts)
            {
                if (IsButtonFavoritesClicked)
                {

                    foreach (var favProduct in CurrentBuyer.BuyerProducts)
                    {
                        if (product.Guid == favProduct.ProductId)
                        {
                            product.Show();
                        }
                    }

                }
                else
                product.Show();
            }
        }

  
        private void hide_Products()
        {
            var productViewModels = flowLayoutPanel1.Controls.Cast<SellerListingPreview>().ToArray();
            foreach (var product in productViewModels)
            {
                product.Hide();
            }
        
   
        }
         

        public void setVegetableButtonColor()
        {
            buttonVegetables.BackColor = Color.BurlyWood;
            buttonOnions.BackColor = Color.AntiqueWhite;
            buttonTomatoes.BackColor = Color.AntiqueWhite;
            buttonCucumbers.BackColor = Color.AntiqueWhite;
            buttonPotatoes.BackColor = Color.AntiqueWhite;
            buttonGarlics.BackColor = Color.AntiqueWhite;
        }

        public void setFruitButtonColor()
        {
            buttonFruits.BackColor = Color.BurlyWood;
            buttonCherries.BackColor = Color.AntiqueWhite;
            buttonGrapes.BackColor = Color.AntiqueWhite;
            buttonPlums.BackColor = Color.AntiqueWhite;
            buttonPears.BackColor = Color.AntiqueWhite;
            buttonApples.BackColor = Color.AntiqueWhite;

        }

        public void setConfectionaryButtonColor()
        {
            buttonConfectionery.BackColor = Color.BurlyWood;
            buttonBread.BackColor = Color.AntiqueWhite;
            buttonBunsAndDonuts.BackColor = Color.AntiqueWhite;
            buttonCakesAndPies.BackColor = Color.AntiqueWhite;
        }

        public void setOtherButtonColor()
        {
            buttonOther.BackColor = Color.BurlyWood;
            buttonHerbs.BackColor = Color.AntiqueWhite;
            buttonHoney.BackColor = Color.AntiqueWhite;
            buttonLongLasting.BackColor = Color.AntiqueWhite;
        }
    }

}
