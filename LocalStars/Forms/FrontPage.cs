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
        public FrontPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reader = new StreamReader("SystemColors.txt");
            try
            {
                var option = reader.ReadLine();
                Form1 openBuyerForm = new Form1 { BackColor = Color.FromName(option) };
                openBuyerForm.Show();
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
            var reader = new StreamReader("SystemColors.txt");
            try
            {
                var option = reader.ReadLine();
                SellerForm openSellerForm = new SellerForm { BackColor = Color.FromName(option) };
                openSellerForm.Show();
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

        private void FrontPage_Load(object sender, EventArgs e)
        {
            try
            {
                using (var sr = new StreamReader("ColorTheme.txt"))
                {
                    var value = sr.ReadToEnd();
                    var matches = Regex.Match(value, @"r(\d*)g(\d*)b(\d*)").Groups.Values;
                    if(matches.Count() == 4)
                    {
                        var intMatches = matches.Skip(1).Select(m => Int32.Parse(m.Value)).ToArray();
                        BackColor = Color.FromArgb(intMatches[0], intMatches[1] , intMatches[2]);
                    }
                }
            }
            catch (IOException exception)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(exception.Message);
            }
        }

        private void radioButtonDark_CheckedChanged(object sender, EventArgs e)
        {
            File.WriteAllText("SystemColors.txt", "ControlDark");
        }

        private void radioButtonLight_CheckedChanged(object sender, EventArgs e)
        {
            File.WriteAllText("SystemColors.txt", "Control");
        }
    }
}
