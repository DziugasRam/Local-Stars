﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Server;
using Models;
using Microsoft.AspNetCore.Identity;
using System.Text.RegularExpressions;

namespace Forms
{
    public partial class NewListingForm : Form
    {
        bool IsPanelVegetablesOpen = false;
        bool IsPaneFruitsOpen = false;
        bool IsPanelConfectioneryOpen = false;
        bool IsPanelOtherOpen = false;
        string _category;

        public NewListingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsPanelVegetablesOpen)
            {
                panelVegetables.Height -= 21;
                if (panelVegetables.Height <= 0)
                {
                    panelVegetables.SendToBack();
                    timer1.Stop();
                    IsPanelVegetablesOpen = false;
                }
            }
            else if (!IsPanelVegetablesOpen)
            {
                panelVegetables.BringToFront();
                panelVegetables.Height += 21;
                if (panelVegetables.Height >= 351)
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
                panelFruits.Height -= 21;
                if (panelFruits.Height <= 0)
                {
                    panelFruits.SendToBack();
                    IsPaneFruitsOpen = false;
                    timer2.Stop();
                }
            }
            else
            {
                panelFruits.BringToFront();
                panelFruits.Height += 21;
                if (panelFruits.Height >= 282)
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
            else
            {
                panelConfectionery.BringToFront();
                panelConfectionery.Height += 21;
                if (panelConfectionery.Height >= 213)
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
                panelOther.Height -= 20;
                if (panelOther.Height <= 0)
                {
                    IsPanelOtherOpen = false;
                    panelOther.SendToBack();
                    timer4.Stop();
                }
            }
            else
            {
                panelOther.BringToFront();
                panelOther.Height += 20;
                if (panelOther.Height >= 150)
                {
                    IsPanelOtherOpen = true;
                    timer4.Stop();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int price = int.Parse(textBox2.Text);
            Product p = new Product(textBox1.Text, _category, price, Controllers.CurrentSeller, richTextBox1.Text, Guid.NewGuid());
            Controllers.ProductController.Insert(new[] { p });

            label10.Visible = true;
        }

        private void category_click(object sender, EventArgs e)
        {
            textBox3.Clear();
            Button btn = sender as Button;
            _category = btn.Text;
            textBox3.AppendText(_category);
        }

        private void NewListingForm_Load(object sender, EventArgs e)
        {
            label10.Visible = false;
        }
    }
}
