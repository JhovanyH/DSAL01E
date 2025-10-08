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
    public partial class pos2 : Form
    {
        private double total_amount = 0;
        private int total_qty = 0;
        public pos2()
        {
            InitializeComponent();
        }

        private void pos2_Load(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "100.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Winx Doll:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "99.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Angry Bird:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "79.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Pikachu Plushy:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "69.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Wood Bunny:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "80.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Piggy Plushy:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "199.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Kuromi Plushy    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "499.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Jose Rizal Statue:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "350.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Sniper Toy Gun::    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "399.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Spinning Elsa:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "49.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Green Dinasaur:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "560.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Cat Plushy Set:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "700.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("limited Bratz Doll:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "677.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Ice Cream Set:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "400.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Baby Alive:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "10.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Band Aid:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "899.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Haunted Legit Doll:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }
        

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "120.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Perfume Sprayer:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "37.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("BatangInaVlog Liptint:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "1000.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("Legit Labubu:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttxtbox.Text = "0.00";
            Pricetxtbox.Text = "290.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add("BarangKaTeh bracelet:    " + Pricetxtbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos2_printform print = new pos2_printform();
            print.printlistBox1.Items.AddRange(this.listBox1.Items);
            print.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           pos2_transfer tf = new pos2_transfer();

            // Copy radio buttons


            tf.FoodARdbtn.Checked = FoodARdbtn.Checked;


            tf.foodBRdbtn.Checked = foodBRdbtn.Checked;

            tf.Keychains.Checked = Keychains.Checked;
            tf.Plushies.Checked = Plushies.Checked;
            tf.ProtectKit1.Checked = ProtectKit1.Checked;
            tf.Ballpens.Checked = Ballpens.Checked;
            tf.randomCollect1.Checked = randomCollect1.Checked;


            tf.RandomPlushies.Checked = RandomPlushies.Checked;
            tf.handmade.Checked = handmade.Checked;
            tf.protectkit2.Checked = protectkit2.Checked;
            tf.notebooks.Checked = notebooks.Checked;
            tf.limited2.Checked = limited2.Checked;


            // Copy textboxes
            tf.Pricetxtbox.Text = Pricetxtbox.Text;
            tf.qtytxtbox.Text = qtytextbox.Text;
            tf.discounttxtbox.Text = discounttxtbox.Text;
            tf.discountedtxtbox.Text = discountedtxtbox.Text;
            tf.totalbillstxtbox.Text = totalbillstxtbox.Text;
            tf.totalqtytxtbox.Text = totalqtytxtbox.Text;
            tf.cashgiventxtbox.Text = cashgiventxtbox.Text;
            tf.changetxtbox.Text = changetxtbox.Text;



            tf.Show();
        }
    }
}
