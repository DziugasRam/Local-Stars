using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using Models;
using Server;


namespace Forms
{
    public partial class NewListingForm : Form
    {
        public NewListingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerForm openSellerForm = new SellerForm();
            openSellerForm.Show();
            this.Close();

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
           // Product p = new Product(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, richTextBox1.Text, new Guid());

           // MockData.s_products.Add(p);

            //Stream stream = File.Open("products.bin", FileMode.Create);
            //BinaryFormatter formatter = new BinaryFormatter();

           // formatter.Serialize(stream, p);
           // stream.Close();
        }

        private void NewListingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
