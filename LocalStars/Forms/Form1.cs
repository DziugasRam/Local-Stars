using Server.Controllers;
using System;
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
        private readonly BuyerController m_buyerController;
        private readonly ProductController m_productController;
        private readonly SellerController m_sellerController;

        bool IsPanelVegetablesOpen = false;
        bool IsPaneFruitsOpen = false;
        bool IsPanelConfectioneryOpen = false;
        bool IsPanelOtherOpen = false;

        public Form1(BuyerController buyerController, ProductController productController, SellerController sellerController)
        {
            m_buyerController = buyerController;
            m_productController = productController;
            m_sellerController = sellerController;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var products = m_productController.SearchProducts(textBox1.Text);
            var listViewItems = products.Select(p => new ListViewItem($"{p.Title}\n")).ToArray();

            listView1.Items.Clear();
            listView1.Items.AddRange(listViewItems);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsPanelVegetablesOpen)
            {
                panelVegetables.Height -= 13;
                if (panelVegetables.Height == 0)
                {
                    panelVegetables.SendToBack();
                    timer1.Stop();
                    IsPanelVegetablesOpen = false;
                }
            }
            else if (!IsPanelVegetablesOpen)
            {
                panelVegetables.BringToFront();
                panelVegetables.Height += 13;
                if(panelVegetables.Height==351)
                {
                    timer1.Stop();
                    IsPanelVegetablesOpen = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (IsPaneFruitsOpen)
            {
                panelFruits.Height -= 6;
                if (panelFruits.Height == 0)
                {
                    panelFruits.SendToBack();
                    IsPaneFruitsOpen = false;
                    timer2.Stop();
                }
            }
            else if (!IsPaneFruitsOpen)
            {
                panelFruits.BringToFront();
                panelFruits.Height += 6;
                if (panelFruits.Height == 282)
                {
                    
                    IsPaneFruitsOpen = true;
                    timer2.Stop();
                }
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
                if (panelConfectionery.Height == 0)
                {                  
                    IsPanelConfectioneryOpen = false;
                    panelConfectionery.SendToBack();
                    timer3.Stop();
                }
            }
            else if (!IsPanelConfectioneryOpen)
            {
                panelConfectionery.BringToFront();
                panelConfectionery.Height += 21;
                if (panelConfectionery.Height == 210)
                {                    
                    IsPanelConfectioneryOpen = true;
                    timer3.Stop();
                }
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (IsPanelOtherOpen)
            {
                panelOther.Height -= 15;
                if (panelOther.Height == 0)
                {
                    IsPanelOtherOpen = false;
                    panelOther.SendToBack();
                    timer4.Stop();
                }
            }
            else if (!IsPanelOtherOpen)
            {
                panelOther.BringToFront();
                panelOther.Height += 15;
                if (panelOther.Height == 150)
                {
                    IsPanelOtherOpen = true;
                    timer4.Stop();
                }
            }
        }
    }
}
