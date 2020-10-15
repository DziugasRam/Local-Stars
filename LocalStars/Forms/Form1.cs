using Forms.Properties;
using Models;
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
        bool IsPanelVegetablesOpen = false;
        bool IsPaneFruitsOpen = false;
        bool IsPanelConfectioneryOpen = false;
        bool IsPanelOtherOpen = false;

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

        private void buttonVegetables_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (IsPaneFruitsOpen)
            {
                panelFruits.Height -=21;
                if (panelFruits.Height > 0) return;
                panelFruits.SendToBack();
                IsPaneFruitsOpen = false;
                timer2.Stop();
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

        private void buttonFruits_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void buttonConfectionery_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void buttonOther_Click(object sender, EventArgs e)
        {
            timer4.Start();
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var productViewModels = flowLayoutPanel1.Controls.Cast<SellerListingPreview>();
            foreach (var product in productViewModels)
            {
                if (product.Name1.Contains(textBox1.Text))
                {
                    product.Show();
                }
                else
                {
                    product.Hide();
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void PopulateList()
        {
            var products = Controllers.s_productController.Get();
            var viewmodel = products.Select(MapToSellerListingPreview);
            flowLayoutPanel1.Controls.AddRange(viewmodel.ToArray());
            
        }

        private Control MapToSellerListingPreview(Product product, int arg2)
        {
            var viewmodel = new SellerListingPreview
            {
                Name1 = product.Title,
                Description = product.Description,
                Price = product.Price.ToString(),
                Category = product.Category,
                Picture = Resources.missing_image,
            };

            return viewmodel;
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            var productViewModels = flowLayoutPanel1.Controls.Cast<SellerListingPreview>();

            foreach(var product in productViewModels)
            {
                if(product.Category == btn.Text)
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

            foreach (var product in productViewModels)
            {
                if (product.MouseClickCount % 2 != 0)
                {
                    product.Show();
                }
                else
                {
                    product.Hide();
                }

            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
