using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Achievo
{
    public partial class loginForm : Form
    {
        public string connstring = "Server=localhost;Port=5432;Database=AchievoBeta;Username=postgres;Password=1234";
        public loginForm()
        {
            InitializeComponent();
            userBox.Anchor = AnchorStyles.None;
            passBox.Anchor = AnchorStyles.None;
            label1.Anchor = AnchorStyles.None;
            label2.Anchor = AnchorStyles.None;
            loginButton.Anchor = AnchorStyles.None;
            signupButton.Anchor = AnchorStyles.None;
            controlLabel.Anchor = AnchorStyles.None;

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string usernameVal = userBox.Text;
            string passwordVal = passBox.Text;

            string query1 = "insert into login (username, \"passwordVal\") values(@nameVal, @passVal)";
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query1, conn);
            cmd.Parameters.AddWithValue("nameVal", usernameVal);
            cmd.Parameters.AddWithValue ("passVal", passwordVal);
            cmd.ExecuteNonQuery();
            userBox.Clear();
            passBox.Clear();
            controlLabel.Text = "Signed up successfully";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string usernameVal = userBox.Text;
            string passwordVal = passBox.Text;

            string query = "select username, \"passwordVal\" from login where username = @username and \"passwordVal\" = @password";
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("username", usernameVal);
            cmd.Parameters.AddWithValue("password", passwordVal);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                string storedUsername = userBox.Text;
                controlLabel.Text = "Logged in successfully";
                Workspace form = new Workspace();
                form.storedUsername = storedUsername;
                form.ShowDialog();
                this.Close();            
            }
            else
            {
                controlLabel.Text = "Login failed";
            }
        }

        private void passBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
