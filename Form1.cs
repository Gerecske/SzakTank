using MySql.Data.MySqlClient;
using System.Drawing;

namespace SzakTank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reg(object sender, EventArgs e)
        {
            string username = tBUser.Text;
            string password = tBPas.Text;
            string passa = tBPasA.Text;
            if (password != passa)
            {
                lError.Text = "A két jelszó nem eggyezik!";
            }
            else
            {
                string server = "localhost";
                string database = "tank";
                string dbuser = "root";
                string dbpass = "";
                string constring = $"SERVER={server};DATABASE={database};UID={dbuser};PASSWORLD={dbpass}";
                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();
                string q = $"INSERT INTO `users`(`Username`, `Passworld`) VALUES ('{username}','{password}')";
                MySqlCommand cmd = new MySqlCommand(q, conn);
                int value = cmd.ExecuteNonQuery();
                MessageBox.Show(value.ToString());
            }
        }
    }
}