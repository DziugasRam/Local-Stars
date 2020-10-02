using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Server.Controllers;

namespace Forms
{
    public partial class SellerForm : Form
    {

        public SellerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewListingForm openNewListingForm = new NewListingForm();
            openNewListingForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
