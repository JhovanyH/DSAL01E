using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1
{
    public partial class user_account : Form
    {
        useraccount_db_connection useraccount_db_connect = new useraccount_db_connection();

        public user_account()
        {
            InitializeComponent();
            useraccount_db_connect.useraccount_connString();
        }

        // Helper method to get actual textbox value (ignoring placeholder)
        private string GetTextBoxValue(TextBox textBox, string placeholderText)
        {
            if (textBox.Text == placeholderText)
                return "";
            return textBox.Text;
        }

        private void cleartextboxes()
        {
            emp_idTxtbox.Clear();
            userIDTxtbox.Clear();

            firstnameTxtbox.Clear();
            middlenameTxtbox.Clear();
            surnameTxtbox.Clear();
            designationTxtbox.Clear();

            // Reset placeholders for read-only fields
            SetPlaceholder(firstnameTxtbox, "firstname");
            SetPlaceholder(middlenameTxtbox, "middlename");
            SetPlaceholder(surnameTxtbox, "surname");

            // Reset placeholders
            SetPlaceholder(usernameTxtbox, "Username");
            SetPlaceholder(passwordTxtbox, "Password");
            SetPlaceholder(confirmPasswordTxtbox, "Confirm Password");

            // Clear comboboxes
            accountTypeComboBox.SelectedIndex = -1;
            account_statusComboBox.SelectedIndex = -1;

            // Clear picture
            try
            {
                pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\question.png");
            }
            catch
            {
                pictureBox1.Image = null;
            }
            picpathTxtbox.Clear();
        }

        private void user_account_Load(object sender, EventArgs e)
        {
            try
            {
                firstnameTxtbox.Enabled = false;
                middlenameTxtbox.Enabled = false;
                surnameTxtbox.Enabled = false;
                designationTxtbox.Enabled = false;
                picpathTxtbox.Enabled = false;
                picpathTxtbox.Hide();

                // Set placeholders for all textboxes
                SetPlaceholder(usernameTxtbox, "Username");
                SetPlaceholder(passwordTxtbox, "Password");
                SetPlaceholder(confirmPasswordTxtbox, "Confirm Password");
                SetPlaceholder(firstnameTxtbox, "firstname");
                SetPlaceholder(middlenameTxtbox, "middlename");
                SetPlaceholder(surnameTxtbox, "surname");

                // DON'T set placeholders for read-only fields - they will be filled when searching
                // Just clear them
                firstnameTxtbox.Clear();
                middlenameTxtbox.Clear();
                surnameTxtbox.Clear();
                designationTxtbox.Clear();

                // Set default picture on form load
                try
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\question.png");
                }
                catch
                {
                    pictureBox1.Image = null;
                }

                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();

                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading form: " + ex.Message);
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(emp_idTxtbox.Text))
                {
                    MessageBox.Show("Please enter an Employee ID");
                    return;
                }

                useraccount_db_connect.useraccount_sql = "SELECT emp_id, emp_fname, emp_mname, emp_surname, position, picpath FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtbox.Text + "'";

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();

                if (useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Employee not found!");
                    return;
                }

                firstnameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][1].ToString();
                firstnameTxtbox.ForeColor = System.Drawing.Color.Black;

                middlenameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][2].ToString();
                middlenameTxtbox.ForeColor = System.Drawing.Color.Black;

                surnameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][3].ToString();
                surnameTxtbox.ForeColor = System.Drawing.Color.Black;

                designationTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][4].ToString();
                picpathTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][5].ToString();

                if (!string.IsNullOrEmpty(picpathTxtbox.Text) && System.IO.File.Exists(picpathTxtbox.Text))
                {
                    pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\question.png");
                }

                MessageBox.Show("Employee found!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching employee: " + ex.Message);
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(userIDTxtbox.Text))
                {
                    MessageBox.Show("Please search for a user account first");
                    return;
                }

                string username = GetTextBoxValue(usernameTxtbox, "Username");
                string password = GetTextBoxValue(passwordTxtbox, "Password");

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter a username");
                    return;
                }

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter a password");
                    return;
                }

                useraccount_db_connect.useraccount_sql = "UPDATE useraccountTbl SET account_type = '" + accountTypeComboBox.Text + "', username = '" + username + "', password = '" + password + "', confirm_password = '" + password + "', user_status = '" + account_statusComboBox.Text + "' WHERE user_id = '" + userIDTxtbox.Text + "'";

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterUpdate();

                MessageBox.Show("User account updated successfully!");

                // Refresh the DataGridView
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];

                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user account: " + ex.Message);
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(userIDTxtbox.Text))
                {
                    MessageBox.Show("Please search for a user account first");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this user account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;

                useraccount_db_connect.useraccount_sql = "DELETE FROM useraccountTbl WHERE user_id = '" + userIDTxtbox.Text + "'";

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterDelete();

                MessageBox.Show("User account deleted successfully!");

                // Refresh the DataGridView
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];

                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user account: " + ex.Message);
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(userIDTxtbox.Text) || string.IsNullOrEmpty(emp_idTxtbox.Text))
                {
                    MessageBox.Show("Please fill in User ID and Employee ID");
                    return;
                }

                string username = GetTextBoxValue(usernameTxtbox, "Username");
                string password = GetTextBoxValue(passwordTxtbox, "Password");
                string confirmPassword = GetTextBoxValue(confirmPasswordTxtbox, "Confirm Password");

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter a username");
                    return;
                }

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter a password");
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match!");
                    return;
                }

                useraccount_db_connect.useraccount_sql = "INSERT INTO useraccountTbl (user_id, account_type, username, password, confirm_password, user_status, emp_id) VALUES ('" + userIDTxtbox.Text + "','" + accountTypeComboBox.Text + "','" + username + "','" + password + "','" + confirmPassword + "','" + account_statusComboBox.Text + "','" + emp_idTxtbox.Text + "')";

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterInsert();

                MessageBox.Show("User account created successfully!");

                // Refresh the DataGridView
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];

                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating user account: " + ex.Message);
            }
        }

        private void search_for_updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(userIDTxtbox.Text))
                {
                    MessageBox.Show("Please enter a User ID");
                    return;
                }

                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, picpath, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE user_id = '" + userIDTxtbox.Text + "'";

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();

                if (useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("User account not found!");
                    return;
                }

                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];

                firstnameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][1].ToString();
                firstnameTxtbox.ForeColor = System.Drawing.Color.Black;

                middlenameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][2].ToString();
                middlenameTxtbox.ForeColor = System.Drawing.Color.Black;

                surnameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][3].ToString();
                surnameTxtbox.ForeColor = System.Drawing.Color.Black;

                designationTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][4].ToString();
                picpathTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][5].ToString();

                // Load the image with validation
                if (!string.IsNullOrEmpty(picpathTxtbox.Text) && System.IO.File.Exists(picpathTxtbox.Text))
                {
                    pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\question.png");
                }

                usernameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][7].ToString();
                usernameTxtbox.ForeColor = System.Drawing.Color.Black;

                passwordTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][8].ToString();
                passwordTxtbox.ForeColor = System.Drawing.Color.Black;

                confirmPasswordTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][8].ToString();
                confirmPasswordTxtbox.ForeColor = System.Drawing.Color.Black;

                account_statusComboBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][9].ToString();
                accountTypeComboBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][10].ToString();

                MessageBox.Show("User account found!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching user account: " + ex.Message);
            }
        }

        // FIXED: Removed duplicate LostFocus event and fixed the method
        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = placeholderText;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.ForeColor = System.Drawing.Color.Gray;
                    textBox.Text = placeholderText;
                }
            };
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
            MessageBox.Show("All fields cleared!");
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}