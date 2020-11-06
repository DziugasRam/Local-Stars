using Models;
using System;
using Server.Controllers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace Forms
{
    public partial class FrontPage : Form
    {
        private const string SystemColorsFileName = "SystemColors.txt";

        public FrontPage()
        {
            InitializeComponent();
        }

        private Color GetBackColor()
        {
            var reader = new StreamReader(SystemColorsFileName);
            try
            {
                var fileContent = reader.ReadLine();
                return Color.FromName(fileContent);
            }
            finally
            {
                reader.Close();
            }
        }

        private void SetBackColor(Color color)
        {
            File.WriteAllText(SystemColorsFileName, color.Name);
            BackColor = color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 openBuyerForm = new Form1 { BackColor = GetBackColor() };
            openBuyerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellerForm openSellerForm = new SellerForm { BackColor = GetBackColor() };
            openSellerForm.Show();
        }

        private void radioButtonDark_CheckedChanged(object sender, EventArgs e)
        {
            SetBackColor(Color.FromName("ControlDark"));
        }

        private void radioButtonLight_CheckedChanged(object sender, EventArgs e)
        { 
            SetBackColor(Color.FromName("Control"));
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {
            BackColor = GetBackColor();
            if (BackColor.Name == "Control") {
                radioButtonLight.Checked = true;
            } else if (BackColor.Name == "ControlDark") {
                radioButtonDark.Checked = true;
            }
        }
    }
}
