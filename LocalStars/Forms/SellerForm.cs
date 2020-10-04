using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using Server;

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
            NewListingForm newListingForm = new NewListingForm();
            newListingForm.Show();
            this.Hide();
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
                listView1.Columns.Add("Price(€)", 80);
                listView1.Columns.Add("Description", 150);

                foreach (Product p in MockData.Products)
                {
                    var items = new ListViewItem();
                    items.Text = p.Title;
                    items.SubItems.Add(p.Price.ToString());
                    items.SubItems.Add(p.Description);
                    listView1.Items.Add(items);
                }

                onClick = false;
            }
        }
    }
}
