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
        public static void HighlightRows(this ListView listView)
        {
            foreach (ListViewItem item in listView.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.FromArgb(244, 244, 244) : Color.FromArgb(251, 251, 251);
            }
        }
    }
}
