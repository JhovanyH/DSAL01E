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
    public partial class Activity3 : Form
    {
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



            
            pictureBox20.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\haunted.png");
            pictureBox19.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\perfum.png");
            pictureBox18.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\liptint.png");
            pictureBox17.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\labubu.png");
            pictureBox16.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\brace.png");






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
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int qty = 0, qty_total = 0;
            double discount_amt = 0, discounted_amt = 0, cash_rendered = 0, change = 0;
            double discount_totalGiven = 0, discounted_totalGiven = 0;


            qty = Convert.ToInt32(textBox3.Text);
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
                double price, discount_amt, discounted_amt;
            qty = Convert.ToInt32(textBox3.Text);
            price = Convert.ToDouble(pricetxtbox.Text);
            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;
            qty = Convert.ToInt32(textBox3.Text);
            price = Convert.ToDouble(pricetxtbox.Text);
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;
            qty = Convert.ToInt32(textBox3.Text);
            price = Convert.ToDouble(pricetxtbox.Text);
            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            radioButton4.Checked = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;
            qty = Convert.ToInt32(textBox3.Text);
            price = Convert.ToDouble(pricetxtbox.Text);
            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton1.Checked = false;
        }
    }
}
