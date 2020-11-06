using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                if (panelVegetables.Height > 0) return;
                panelVegetables.SendToBack();
                timer1.Stop();
                IsPanelVegetablesOpen = false;
                button1.BackColor = Color.Empty;
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

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            SetVegetableButtonColor();
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

        private void buttonFruits_Click(object sender, EventArgs e)
        {
            timer2.Start();
            SetFruitButtonColor();
        }

        private void buttonConfectionery_Click(object sender, EventArgs e)
        {
            timer3.Start();
            SetConfectioneryButtonColor();
        }

        private void buttonOther_Click(object sender, EventArgs e)
        {
            timer4.Start();
            SetOtherButtonColor();
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

        private void button13_Click(object sender, EventArgs e)
        {
            var reader = new StreamReader("SystemColors.txt");
            try
            {
                var option = reader.ReadLine();
                SellerForm sellerForm = new SellerForm { BackColor = Color.FromName(option) };
                sellerForm.Show();
                this.Hide();
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

        private void ValidateNewListingValues(string title, string price, string description)
        {
            var titleRegex = new Regex(@"[\.@!#$%?{}\[\]]");
            var titleMatch = titleRegex.Match(title);
            if (titleMatch.Length > 0)
            {
                throw new ArgumentException($"Invalid character : {titleMatch.Groups[0]} found in title");
            }

            var numberRegex = new Regex(@"^[0-9]+$"); // TODO: float support (?:[,\.][0-9]+)?
            if (!numberRegex.IsMatch(price))
            {
                throw new ArgumentException("Price is not valid");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { 
                var price = int.Parse(textBox2.Text);
                var product = new Product(title: textBox1.Text, category: _category, price: price, seller: Controllers.CurrentSeller, description: richTextBox1.Text, id: Guid.NewGuid());

                var products = Controllers.ProductController.Get();
                var doesExist = products.Any(p => p == product);

                if(!doesExist)
                {
                    Controllers.ProductController.Insert(new[] { product });
                    NewListingStatus("Successfully added a new product!");
                }
                else
                    NewListingStatus("This product is already in market");
            }
            catch (ArgumentException exception)
            {
                NewListingStatus(exception.Message);
            }
            catch
            {
                NewListingStatus("Failed to add a new product");
            }
        }

        private void category_click(object sender, EventArgs e)
        {
            textBox3.Clear();
            var btn = sender as Button;
            _category = btn.Text;
            textBox3.AppendText(_category);
        }

        private void NewListingForm_Load(object sender, EventArgs e)
        {
            NewListingStatus(null);
        }

        private void NewListingStatus(string text)
        {
            label10.Text = text;
        }

        public void SetVegetableButtonColor()
        {
            button1.BackColor = Color.BurlyWood;
            button2.BackColor = Color.AntiqueWhite;
            button3.BackColor = Color.AntiqueWhite;
            button4.BackColor = Color.AntiqueWhite;
            button5.BackColor = Color.AntiqueWhite;
            button6.BackColor = Color.AntiqueWhite;
        }

        public void SetFruitButtonColor()
        {
            buttonFruits.BackColor = Color.BurlyWood;
            button8.BackColor = Color.AntiqueWhite;
            button9.BackColor = Color.AntiqueWhite;
            button10.BackColor = Color.AntiqueWhite;
            button11.BackColor = Color.AntiqueWhite;
            button12.BackColor = Color.AntiqueWhite;

        }

        public void SetConfectioneryButtonColor()
        {
            buttonConfectionery.BackColor = Color.BurlyWood;
            buttonBread.BackColor = Color.AntiqueWhite;
            buttonBunsAndDonuts.BackColor = Color.AntiqueWhite;
            buttonCakesAndPies.BackColor = Color.AntiqueWhite;
        }

        public void SetOtherButtonColor()
        {
            buttonOther.BackColor = Color.BurlyWood;
            buttonHerbs.BackColor = Color.AntiqueWhite;
            buttonHoney.BackColor = Color.AntiqueWhite;
            buttonLongLasting.BackColor = Color.AntiqueWhite;
        }

    }
}
