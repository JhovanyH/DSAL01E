using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1
{
    public partial class Activity3 : Form
    {
        //auto size the application within the windows
        private Size baseSize;

        

        
        public Activity3()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            itemnametxtbox.Enabled = false;
            pricetxtbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;

           

            label15.Text = "Winx Bloom Doll";
            label16.Text = "Angry Red Bird";
            label17.Text = "Pikachu Plushie";
            label18.Text = "Wooden Bunny";
            label19.Text = "Piggy Plushie";
            label20.Text = "Kuromi Keychain";
            label21.Text = "J. Rizal Statue";
            label22.Text = "Sniper Toy Gun";
            label23.Text = "Flying Elsa";
            label24.Text = "Dinasaur Green";

            //scaling to the highest level
            baseSize = this.Size;

            // maximize the window
            this.WindowState = FormWindowState.Maximized;

            // scale once to fit the screen
            ScaleToScreen();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int qty = 0, qty_total = 0;
                double discount_amt = 0, discounted_amt = 0, cash_rendered = 0, change = 0;
                double discount_totalGiven = 0, discounted_totalGiven = 0;


                qty = Convert.ToInt32(qtytxtbox.Text);
                discount_amt = Convert.ToDouble(discounttxtbox.Text);
                discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
                cash_rendered = Convert.ToDouble(textBox9.Text);

                qty_total += qty;
                discount_totalGiven += discount_amt;
                discounted_totalGiven += discounted_amt;
                change = cash_rendered - discounted_amt;


                qty_totaltxtbox.Text = qty_total.ToString();
                discount_totaltxtbox.Text += discount_totalGiven.ToString("n");
                discounted_totaltxtbox.Text = discounted_totalGiven.ToString("n");
                changetxtbox.Text = change.ToString("n");
                textBox9.Text = cash_rendered.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure cash given textbox is not empty invalid");
                textBox9.Clear();
                textBox9.Focus();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Haunted Doll";
            pricetxtbox.Text = "999";
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int qty;
                double price, discount_amt, discounted_amt;
                qty = Convert.ToInt32(qtytxtbox.Text);
                price = Convert.ToDouble(pricetxtbox.Text);
                discount_amt = (qty * price) * 0.30;
                discounted_amt = (qty * price) - discount_amt;
                discounttxtbox.Text = discount_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                qtytxtbox.Clear();
                qtytxtbox.Focus();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try

            {
                int qty;
                double price, discount_amt, discounted_amt;
                qty = Convert.ToInt32(qtytxtbox.Text);
                price = Convert.ToDouble(pricetxtbox.Text);
                discount_amt = (qty * price) * 0.10;
                discounted_amt = (qty * price) - discount_amt;
                discounttxtbox.Text = discount_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                qtytxtbox.Clear();
                qtytxtbox.Focus();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int qty;
                double price, discount_amt, discounted_amt;
                qty = Convert.ToInt32(qtytxtbox.Text);
                price = Convert.ToDouble(pricetxtbox.Text);
                discount_amt = (qty * price) * 0.15;
                discounted_amt = (qty * price) - discount_amt;
                discounttxtbox.Text = discount_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");
                radioButton2.Checked = false;
                radioButton1.Checked = false;
                radioButton4.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                qtytxtbox.Clear();
                qtytxtbox.Focus();
            }
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try

            {
                int qty;
                double price, discount_amt, discounted_amt;
                qty = Convert.ToInt32(qtytxtbox.Text);
                price = Convert.ToDouble(pricetxtbox.Text);
                discount_amt = (qty * price) * 0;
                discounted_amt = (qty * price) - discount_amt;
                discounttxtbox.Text = discount_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton1.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                qtytxtbox.Clear();
                qtytxtbox.Focus();

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetxtbox.Clear();
            qtytxtbox.Clear();
            qty_totaltxtbox.Clear();
            discounttxtbox.Clear();
            discountedtxtbox.Clear();
            changetxtbox.Clear();
            textBox9.Clear();
            discounted_totaltxtbox.Clear();
            discount_totaltxtbox.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Winx Doll Bloom";
            pricetxtbox.Text = "100";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Angry Bird Plushie";
            pricetxtbox.Text = "89";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "PIKACHU";
            pricetxtbox.Text = "50";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Wooden Bunny";
            pricetxtbox.Text = "109";

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Piggy Plushy";
            pricetxtbox.Text = "120";

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Kuromi Plushy";
            pricetxtbox.Text = "150";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "J.Rizal Statue";
            pricetxtbox.Text = "499";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Sniper Toy Gun";
            pricetxtbox.Text = "399";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Spinning Elsa";
            pricetxtbox.Text = "218";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Green Dino";
            pricetxtbox.Text = "79";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Cat Plushy";
            pricetxtbox.Text = "200";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Bratz Doll";
            pricetxtbox.Text = "400";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "ICE CREAM SET";
            pricetxtbox.Text = "678";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "BaBy Alive";
            pricetxtbox.Text = "800";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Band Aid";
            pricetxtbox.Text = "45";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Perfum Sprayer";
            pricetxtbox.Text = "67";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "BatangInaVlog Liptint";
            pricetxtbox.Text = "25";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Original Labubu";
            pricetxtbox.Text = "1200";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "BarangKateh Bracelet";
            pricetxtbox.Text = "120";
        }
        private void ScaleToScreen()
        {
            float scaleX = (float)Screen.PrimaryScreen.Bounds.Width / baseSize.Width;
            float scaleY = (float)Screen.PrimaryScreen.Bounds.Height / baseSize.Height;

            // Scale all controls
            this.Scale(new SizeF(scaleX, scaleY));

            // Scale fonts too
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = new Font(ctrl.Font.FontFamily, ctrl.Font.Size * Math.Min(scaleX, scaleY));
            }
        }


    }
}
