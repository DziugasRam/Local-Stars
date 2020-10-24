using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class ListingForm : Form
    {
        public ListingForm(string name, string price, string description,string category, Image image)
        {
            InitializeComponent();
            labelProductName.Text = name;
            labelPrice.Text = price;
            labelDescription.Text = description;
            pictureBox1.Image = image;
            labelCategory.Text = category;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
