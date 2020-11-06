using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.AspNetCore.Identity;
using Models;
using Server;
using Server.Providers;
using Forms;

namespace Forms
{
    public partial class SellerForm : Form
    {
        bool onClick = true;

        public SellerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reader = new StreamReader("SystemColors.txt");
            try
            {
                var option = reader.ReadLine();
                NewListingForm newListingForm = new NewListingForm { BackColor = Color.FromName(option) };
                newListingForm.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (onClick == true)
            {
                listView1.View = View.List;
                listView1.View = View.Details;
                listView1.FullRowSelect = true;

                listView1.Columns.Add("Title", 150);
                listView1.Columns.Add("Category", 150);
                listView1.Columns.Add("Price(€)", 80);
                listView1.Columns.Add("Description", 220);

                var products = Controllers.ProductController.Get().ToList();
                foreach (Product p in products)
                {
                    if (p.Seller.Id == Controllers.CurrentSeller.Id)
                    {
                        var items = new ListViewItem();
                        items.Text = p.Title;
                        items.SubItems.Add(p.Category);
                        items.SubItems.Add(p.Price.ToString());
                        items.SubItems.Add(p.Description);
                        items.Tag = p;
                        listView1.Items.Add(items);
                    }
  
                }

                listView1.highlightRows();

                onClick = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Are you sure you want to delete selected items?", "Delete selected items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem itm = listView1.SelectedItems[i];
                        listView1.Items[itm.Index].Remove();
                        DeleteProduct((Product)(itm.Tag));
                    }
                }
            }
            else MessageBox.Show("You have not selected an item to remove");
        }

        private void DeleteProduct(Product p)
        {
            Controllers.ProductController.RemoveById(new[] { p.Id } );
        }

    }
}
