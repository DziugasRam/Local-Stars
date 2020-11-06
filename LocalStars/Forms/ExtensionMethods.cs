using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Forms;
using Models;

namespace Forms
{
    public static class ExtensionMethods
    {
        public static void highlightRows(this ListView listView)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Index % 2 == 0)
                {
                    item.BackColor = Color.FloralWhite;
                }
                else item.BackColor = Color.LightYellow;
            }

        }
    }
}
