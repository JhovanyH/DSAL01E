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
    public partial class pos1function : Form
    {
        int qty = 0;
        double price = 0;
        Double discount_amt = 0;
        public pos1function()
        {
            InitializeComponent();
        }

        private void Quantitytxtbox()
        {
            qtytxtbox.Clear();
            qtytxtbox.Focus();

        }
        private void quantity_price()
        {
            qty = Convert.ToInt32(qtytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);
        }

        private void computation_data_andDisplay()
        {
            discount_amt = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discount_amt.ToString("n");

        }
        private void price_item_txtvalue(string itemname, string price)
        {
            itemnametxtbox.Text = itemname;
            pricetxtbox.Text = price;
        }

        private void pos1function_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Winx Doll", "90.00");
            Quantitytxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Happy Bird", "69.00");
            Quantitytxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Peek-A-Choo", "130.00");
            Quantitytxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Woody Bunny", "70.00");
            Quantitytxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Piggie Plushie", "139.00");
            Quantitytxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("CureA-mee Plushie", "300.00");
            Quantitytxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("J.Rizal statue", "9999.00");
            Quantitytxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Winx Doll", "90.00");
            Quantitytxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Elsa Spinning High Voltage", "499.00");
            Quantitytxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Gnarly Dinasour", "48.00");
            Quantitytxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Car Parking Set", "569.00");
            Quantitytxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Bratty Doll sis Limited Edition", "780.00");
            Quantitytxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Ice Cream Set", "438.00");
            Quantitytxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Baby not so Alive", "313.00");
            Quantitytxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("sticky Bandage", "12.00");
            Quantitytxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Legit Haunted Doll", "666.00");
            Quantitytxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Multipurpose PerfumeSprayer", "214.00");
            Quantitytxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("BatangInaVlog Liptint", "69.00");
            Quantitytxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Labubu Legit/No Scam", "1000.00");
            Quantitytxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("BarangKateh Bestfriend Bracelet", "346.00");
            Quantitytxtbox();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price();
                discount_amt = (qty * price) * 0.30;
                computation_data_andDisplay();
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            catch(Exception) {
                MessageBox.Show("Input is invalid");
                Quantitytxtbox();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price();
                discount_amt = (qty * price) * 0.30;
                computation_data_andDisplay();
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            catch(Exception)
            {
                MessageBox.Show("Input is invalid");
                Quantitytxtbox();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price();
                discount_amt = (qty * price) * 0.30;
                computation_data_andDisplay();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton4.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                Quantitytxtbox();
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price();
                discount_amt = (qty * price) * 0.30;
                computation_data_andDisplay();
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton2.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                Quantitytxtbox();
            }
        }
    }
}
