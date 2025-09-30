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
    public partial class LoginFrm1 : Form
    {
        public LoginFrm1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginFrm1_Load(object sender, EventArgs e)
        {
            usernameTxtbox.Focus();
            passwordTxtbox.PasswordChar = '*';
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (usernameTxtbox.Text == "Cashier1" && passwordTxtbox.Text == "jhovany")
            {
                MessageBox.Show("Welcome .|.");
                Activity3 activity3 = new Activity3();
                activity3.Show();
                this.Hide();
            }
            else if
                (usernameTxtbox.Text == "Cashier2" && passwordTxtbox.Text == "honorio")
            {
                MessageBox.Show("Welcome .|.");
                Activity4 activity4 = new Activity4();
                activity4.Show();
                this.Hide();
            }
            else if (usernameTxtbox.Text == "Admin" && passwordTxtbox.Text == "admin123")
            {
                MessageBox.Show("Welcome .|.");
                MainForm adminfrm = new MainForm();
                adminfrm.Show();
                this.Hide();
            }
            else if (usernameTxtbox.Text == "Accountant" && passwordTxtbox.Text == "accounting")
            {
                MessageBox.Show("Welcome .|.");
                Lesson5_Activity activity5 = new Lesson5_Activity();
                activity5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error mhie/dhie!");

            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void passwordTxtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void usernameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
