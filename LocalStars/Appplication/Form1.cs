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

namespace Appplication
{
    public partial class Form1 : Form
    {
        private readonly BuyerController m_buyerController;
        private readonly ProductController m_productController;
        private readonly SellerController m_sellerController;

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
    }
}
