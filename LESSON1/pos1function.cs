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
        int qty, qty_total = 0;
        double price, discount_amt, discounted_amt, discount_totalGiven, discounted_totalGiven, cash_rendered, change = 0;
        //auto size the application within the windows
        private Size baseSize;
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
            discounted_amt = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

        }
        private void price_item_txtvalue(string itemname, string price)
        {
            itemnametxtbox.Text = itemname;
            pricetxtbox.Text = price;
        }
        private void ResetTotals()
        {
            qty_total = 0;
            discount_totalGiven = 0;
            discounted_totalGiven = 0;
        }
        private void ClearAllFields()
        {
            itemnametxtbox.Clear();
            pricetxtbox.Clear();
            qtytxtbox.Clear();
            discounttxtbox.Clear();
            discountedtxtbox.Clear();
            qty_totaltxtbox.Clear();
            discount_totaltxtbox.Clear();
            discounted_totaltxtbox.Clear();
            changetxtbox.Clear();
            textBox9.Clear();
        }

        private void pos1function_Load(object sender, EventArgs e)
        {
            itemnametxtbox.Enabled = false;
            pricetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;

            //scaling to the highest level
            baseSize = this.Size;

            // maximize the window
            this.WindowState = FormWindowState.Maximized;

            // scale once to fit the screen
            ScaleToScreen();
        }
        private void ResetDiscountRadios()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Winx Doll", "90.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Happy Bird", "69.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Peek-A-Choo", "130.00");
            Quantitytxtbox();
            ResetDiscountRadios();  
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Woody Bunny", "70.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Piggie Plushie", "139.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("CureA-mee Plushie", "300.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("J.Rizal statue", "9999.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Winx Doll", "90.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Elsa Spinning High Voltage", "499.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Gnarly Dinasour", "48.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Car Parking Set", "569.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Bratty Doll sis Limited Edition", "780.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Ice Cream Set", "438.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Baby not so Alive", "313.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("sticky Bandage", "12.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Legit Haunted Doll", "666.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Multipurpose PerfumeSprayer", "214.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                qty = Convert.ToInt32(qtytxtbox.Text);
                discount_amt = Convert.ToDouble(discounttxtbox.Text);
                discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
                cash_rendered = Convert.ToDouble(textBox9.Text);

                qty_total += qty;
                discount_totalGiven += discount_amt;
                discounted_totalGiven += discounted_amt;

                change = cash_rendered - discounted_totalGiven;

                qty_totaltxtbox.Text = qty_total.ToString();
                discount_totaltxtbox.Text = discount_totalGiven.ToString("n");
                discounted_totaltxtbox.Text = discounted_totalGiven.ToString("n");
                changetxtbox.Text = change.ToString("n");
                textBox9.Text = cash_rendered.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure all fields are filled properly.");
                textBox9.Focus();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            ResetDiscountRadios();
            ResetTotals();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("BatangInaVlog Liptint", "69.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("Labubu Legit/No Scam", "1000.00");
            Quantitytxtbox();
            ResetDiscountRadios();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_txtvalue("BarangKateh Bestfriend Bracelet", "346.00");
            Quantitytxtbox();
            ResetDiscountRadios();
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
                discount_amt = (qty * price) * 0.20;
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
                discount_amt = (qty * price) * 0.15;
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
                discount_amt = (qty * price) * 0;
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
