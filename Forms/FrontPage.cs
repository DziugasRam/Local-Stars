using Models;
using System;
using Server.Controllers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{

    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 openBuyerForm = new Form1();
            openBuyerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellerForm openSellerForm = new SellerForm();
            openSellerForm.Show();
        }
    }
}
