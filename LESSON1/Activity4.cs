using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1
{
    public partial class Activity4 : Form
    {
        private double total_amount = 0;
        private int total_qty = 0;
        public Activity4()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (foodBRdbtn.Checked)
            {
                double price = 1899.00;  // bundle base price
                double discount = 250.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add("Bundle B: -P" + discounted.ToString("n2"));
                DisplayPictureBox.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\Screenshots\\collectibles2.png");

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

            }
            }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
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


            this.WindowState = FormWindowState.Maximized;
            




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (FoodARdbtn.Checked)
            {
                double price = 1299.00;  // bundle base price
                double discount = 194.85;
                int qty = 1;
                double discounted = (price * qty) - discount;

                // Show in textboxes
                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                // Update totals
                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                // Show details in listbox
                listBox1.Items.Add("Bundle A: -P" + discounted.ToString("n2"));

                DisplayPictureBox.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\Screenshots\\collectibles.png");



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


            }




           }

        private void button1_Click(object sender, EventArgs e)
        {
            FoodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;

            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\Question.png");
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
            qtytxtbox.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Keychains_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void randomCollect1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try

            {
                double cash = Convert.ToDouble(cashgiventxtbox.Text);
                double total = Convert.ToDouble(totalbillstxtbox.Text);
                double change = cash - total;

                changetxtbox.Text = change.ToString("n2");

                listBox1.Items.Add("Total Bills: P" + total.ToString("n2"));
                listBox1.Items.Add("Cash Given: P" + cash.ToString("n2"));
                listBox1.Items.Add("Change: P" + change.ToString("n2"));
                listBox1.Items.Add("---------------------------");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter Valid data in cash given textbox!");
                cashgiventxtbox.Clear();
                cashgiventxtbox.Focus();

            }
        }
        private void cashgiventxtbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt (listBox1.SelectedIndex);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Activitty4_PrintForm print = new Activitty4_PrintForm();
            print.printlistBox1.Items.AddRange(this.listBox1.Items);
            print.Show();





        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FoodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\question.png");
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
            qtytxtbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            totalbillstxtbox.Clear();
            totalqtytxtbox.Clear();
            cashgiventxtbox.Clear();
            changetxtbox.Clear();
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


            total_amount = 0;
            total_qty = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void qtytxtbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                double price, discounted_amount, discount_amount;

                int qty;

                price = Convert.ToDouble(Pricetxtbox.Text);
                qty = Convert.ToInt32(qtytxtbox.Text);
                discount_amount = Convert.ToDouble(discounttxtbox.Text);
                discounted_amount = (price * qty) - discount_amount;
                total_qty += qty;
                totalqtytxtbox.Text = total_qty.ToString();
                total_amount += discounted_amount;
                totalbillstxtbox.Text = total_amount.ToString("n");
                discountedtxtbox.Text = discounted_amount.ToString("n");


            }
            catch (Exception)
            {
                MessageBox.Show("Enter number of quantity ordered!");
                qtytxtbox.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                double price = 99.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox1.Text + " - P" + price.ToString("n2"));
            }

            }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                double price = 150.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox2.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                double price = 200.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox3.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                double price = 250.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox4.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                double price = 300.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox5.Text + " - P" + price.ToString("n2"));
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                double price = 78.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox6.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                double price = 190.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox7.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                double price = 399.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox8.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                double price = 299.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox9.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                double price = 30.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox10.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                double price = 199.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox11.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                double price = 230.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox12.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                double price = 320.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox13.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                double price = 399.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox14.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                double price = 699.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox15.Text + " - P" + price.ToString("n2"));
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                double price = 9.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox16.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                double price = 270.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox17.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                double price = 40.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox18.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                double price = 999.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox19.Text + " - P" + price.ToString("n2"));
            }

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                double price = 150.00;
                double discount = 0.00;
                int qty = 1;
                double discounted = (price * qty) - discount;

                Pricetxtbox.Text = price.ToString("n2");
                qtytxtbox.Text = qty.ToString();
                discounttxtbox.Text = discount.ToString("n2");
                discountedtxtbox.Text = discounted.ToString("n2");

                total_amount += discounted;
                total_qty += qty;
                totalbillstxtbox.Text = total_amount.ToString("n2");
                totalqtytxtbox.Text = total_qty.ToString();

                listBox1.Items.Add(checkBox20.Text + " - P" + price.ToString("n2"));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        
            
        {
            Activity4_transfer tf = new Activity4_transfer();

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
                tf.qtytxtbox.Text = qtytxtbox.Text;
                tf.discounttxtbox.Text = discounttxtbox.Text;
                tf.discountedtxtbox.Text = discountedtxtbox.Text;
                tf.totalbillstxtbox.Text = totalbillstxtbox.Text;
                tf.totalqtytxtbox.Text = totalqtytxtbox.Text;
                tf.cashgiventxtbox.Text = cashgiventxtbox.Text;
                tf.changetxtbox.Text = changetxtbox.Text;



                tf.Show();
            
        }

        private void DisplayPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void discountedtxtbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

