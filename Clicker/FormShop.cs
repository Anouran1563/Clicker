using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class FormShop : Form
    {
        public FormShop()
        {
            InitializeComponent();
            User obj = new User();
            int multiplyer = obj.Multiplyer;
            lblMultiplier.Text = multiplyer.ToString();
        }
    }
}
