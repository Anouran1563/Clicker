using System;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {

        int clickCount = 0;
        int Cash = 0;
        public Form1()
        {
            InitializeComponent();

            lblCount.Text = clickCount.ToString();
            lblCash.Text = Cash.ToString();
        }

        private void btnChg_ClickEvent(object sender, EventArgs e)
        {
            clickCount++;
            lblCount.Text = clickCount.ToString();
        }

        private void btnSl_ClickEvent(object sender, EventArgs e)
        {
            if (clickCount > 0)
            {
                Cash += clickCount;
                lblCash.Text = Cash.ToString();
                clickCount = 0;
            }
            else
            {

            }
        }

        private void btnShop_ClickEvent(object sender, EventArgs e)
        {
            FormShop shop = new FormShop();
            shop.Show();
        }
    }
}
