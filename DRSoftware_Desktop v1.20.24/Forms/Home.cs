using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DRSoftware_Desktop_v1._20._24.Forms
{
    public partial class Home : Telerik.WinControls.UI.ShapedForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void POSPage_MouseDown(object sender, MouseEventArgs e)
        {
            //radCallout1.Show(POSPage.Location);
        }

        private void radButtonTextBox1_TextChanged(object sender, EventArgs e)
        {
            radCallout1.Show(radButtonTextBox1.Location);

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            radCallout1.Show(radButton1.Location);

        }
    }
}
