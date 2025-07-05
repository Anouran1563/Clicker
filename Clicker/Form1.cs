using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Clicker
{
    public partial class Form1 : Form
    {
        static string SqlConnection = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Dokumente\clkDB.mdf;Integrated Security=True;Connect Timeout=30");

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text;
        }

        private bool Login(string username)
        {
            using (var connection = new SqlConnection(SqlConnection)) // Fixed variable name  
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
