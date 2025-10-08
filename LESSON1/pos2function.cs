using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1
{
    public partial class pos2function : Form
    {
        private double total_amount = 0;
        private int total_qty = 0;
        public pos2function()
        {
            InitializeComponent();
        }

        private void pos2function_Load(object sender, EventArgs e)
        {
            Pricetxtbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            discounttxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            totalbillstxtbox.Enabled = false;
            totalqtytxtbox.Enabled = false;

            Keychains.Enabled = false;
            Plushies.Enabled = false;
            ProtectKit1.Enabled = false;
            Ballpens.Enabled = false;
            randomCollect1.Enabled = false;
            RandomPlushies.Enabled = false;
            handmade.Enabled = false;
            protectkit2.Enabled = false;
            notebooks.Enabled = false;
            limited2.Enabled = false;
        }
        private void Quantitytxtbox()
        {
            qtytextbox.Clear();
            qtytextbox.Focus();

        }
        
        private void item_priceValue(double discountamount, double price)
        {
            discounttxtbox.Text = discountamount.ToString();
            Pricetxtbox.Text = price.ToString();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue(0.00, 90.00);
            Quantitytxtbox();
        }

        private void FoodARdbtn_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            foodBRdbtn.Checked = false;
            Keychains.Checked = true;
            Plushies.Checked = true;
            ProtectKit1.Checked = true;
            Ballpens.Checked = true;
            randomCollect1.Checked = true;
            RandomPlushies.Checked = false;
            handmade.Checked = false;
            protectkit2.Checked = false;
            notebooks.Checked = false;
            limited2.Checked = false;
            Pricetxtbox.Text = "1,000";
            discounttxtbox.Text = "200";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add(FoodARdbtn.Text + ": P" + Pricetxtbox.Text);
            listBox1.Items.Add("Discount Amount: P" + discounttxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();

        }

        private void foodBRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            FoodARdbtn.Checked = false;
            Keychains.Checked = false;
            Plushies.Checked = false;
            ProtectKit1.Checked = false;
            Ballpens.Checked = false;
            randomCollect1.Checked = false;

            RandomPlushies.Checked = true;
            handmade.Checked = true;
            protectkit2.Checked = true;
            notebooks.Checked = true;
            limited2.Checked = true;
            Pricetxtbox.Text = "1,300";
            discounttxtbox.Text = "195";
            listBox1.Items.Add(FoodARdbtn.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double cash_given, change, total_amountPaid;
                cash_given = Convert.ToDouble(cashgiventxtbox.Text);
                total_amountPaid = Convert.ToDouble(totalbillstxtbox.Text);
                change = cash_given - total_amountPaid;
                changetxtbox.Text = change.ToString("n");

                listBox1.Items.Add("Total Bills: " + totalbillstxtbox.Text);
                listBox1.Items.Add("Cash Given: " + cashgiventxtbox.Text);
                listBox1.Items.Add("Change: " + changetxtbox.Text);
                listBox1.Items.Add("Total Quantity: " + totalqtytxtbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input for Cash Render!");
                cashgiventxtbox.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foodBRdbtn.Checked = false;
            FoodARdbtn.Checked = false;
            RandomPlushies.Checked = false;
            handmade.Checked = false;
            protectkit2.Checked = false;
            notebooks.Checked = false;
            limited2.Checked = false;

            Keychains.Checked = false;
            Plushies.Checked = false;
            ProtectKit1.Checked = false;
            Ballpens.Checked = false;
            randomCollect1.Checked = false;

            Pricetxtbox.Clear();
            qtytextbox.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            listBox1.Items.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qtytextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double price, discounted_amount, discount_amount;
                int qty;
                price = Convert.ToDouble(Pricetxtbox.Text);
                qty = Convert.ToInt32(qtytextbox.Text);
                discount_amount = Convert.ToDouble(discounttxtbox.Text);
                discounted_amount = (qty * price) - discount_amount;
                total_qty += qty;
                totalqtytxtbox.Text = total_qty.ToString();
                total_amount += discounted_amount;
                totalbillstxtbox.Text = total_amount.ToString();
                discountedtxtbox.Text = discounted_amount.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
                qtytextbox.Focus();
            }
        }
    }
}
