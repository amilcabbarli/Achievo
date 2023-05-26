using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Achievo
{
    public partial class Workspace : Form
    {
        public string connstring = "Server=localhost;Port=5432;Database=AchievoBeta;Username=postgres;Password=1234";
        public string storedUsername { get; set; }
        public Workspace()
        {
            InitializeComponent();
        }

        private void Workspace_Load(object sender, EventArgs e)
        {
            profileLabel.Text = storedUsername;
            RetrieveCheckboxes();
        }

        //Add new note to database and to checkedListBox
        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(checkTextBox.Text))
            {
                controlLabel.Text = "Please add name for your note";
            }
            else
            {
                controlLabel.Text = null;

                string checkBoxText = checkTextBox.Text;
                string checkBoxName = getUniqueName();
                bool isChecked2 = false;

                CheckboxItem checkboxItem = new CheckboxItem(checkBoxText, isChecked2, checkBoxName);
                checkedListBox1.Items.Add(checkboxItem);

                string query = "insert into checkboxtable (username, checkboxname, checkboxtext, checked) values (@username, @checkname, @checktext, @checked)";
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("username", storedUsername);
                cmd.Parameters.AddWithValue("checkname", checkBoxName);
                cmd.Parameters.AddWithValue("checktext", checkBoxText);
                cmd.Parameters.AddWithValue("checked", isChecked2);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            checkTextBox.Clear();
        }

        //addButton_Click event when "Enter" key is pressed
        private void checkTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addButton_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //retrieve checkboxes from postgresql database and populate checkedListBox with those values    
        private void RetrieveCheckboxes()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            try
            {

                string retrieveQuery = "select username, checkboxname, checkboxtext, checked from checkboxtable where username = @username order by id asc";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(retrieveQuery, conn))
                {
                    cmd.Parameters.AddWithValue("username", storedUsername);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string checkboxName = reader.GetString(1);
                            string checkboxText = reader.GetString(2);
                            bool Checked = reader.GetBoolean(3);

                            CheckboxItem checkboxItem = new CheckboxItem(checkboxText, Checked, checkboxName);
                            checkedListBox1.Items.Add(checkboxItem);
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error retrieving checkboxes: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private string getUniqueName()
        {
            string uniqueName = Guid.NewGuid().ToString();
            return uniqueName;
        }



        public class CheckboxItem
        {
            public string Text { get; set; }
            public string Name { get; set; }
            public bool IsChecked { get; set; }

            public CheckboxItem(string text, bool isChecked, string name)
            {
                Text = text;
                Name = name;
                IsChecked = isChecked;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(checkedListBox1.SelectedIndex != -1)
            {
                deleteButton.Visible = true;
            }

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            string query = "update checkboxtable set checked = true where checkboxtext = @checktext";
            string checkedItem = checkedListBox1.Items[e.Index].ToString();
            bool isChecked = (e.NewValue == CheckState.Checked);
            if (isChecked)
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("checktext", checkedItem);
                cmd.ExecuteNonQuery();
            }
            else
            {
                Console.WriteLine($"Checkbox unchecked: {checkedItem}");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            string query = "delete from checkboxtable where checkboxtext = @checkText";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            if (checkedListBox1.SelectedIndex != -1)
            {
                string selectedItemName = checkedListBox1.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("checkText", selectedItemName);
                cmd.ExecuteNonQuery();
                //Console.WriteLine(selectedItemName);
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
                deleteButton.Visible = false;
            }
            else
            {
                controlLabel.Text = "Please select a note to delete";
            }
        }

        private void profileLabel_MouseHover(object sender, EventArgs e)
        {
            profileLabel.ForeColor = Color.Magenta;
        }

        private void profileLabel_MouseLeave(object sender, EventArgs e)
        {
            profileLabel.ForeColor = Color.Black;
        }
    }
}
