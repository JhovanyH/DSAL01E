using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LESSON1
{
    public partial class POS2_DATABASE : Form
    {
        Variables1 V = new Variables1();
        Price_Item_Value PIV = new Price_Item_Value();
        pos_dbconnection P = new pos_dbconnection();
        public POS2_DATABASE()
        {
            P.pos_connString();
            InitializeComponent();
        }
        

        private void quantityTextBox()
        {
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }
        private void foodradiobtn()
        {
            foodBRdbtn.Checked = false;
            FoodARdbtn.Checked = false;
        }

        private void GetPriceDiscountAmount()
        {
            // Get values from the Price_Item_Value object
            string priceStr = PIV.GetPrice();               // get the item price
            string discountStr = PIV.GetDiscountAmount();   // get the discount

            // Display them on the form
            Pricetxtbox.Text = priceStr;
            discounttxtbox.Text = discountStr;

            // Compute discounted total (optional)
            double price = Convert.ToDouble(priceStr);
            double discount = Convert.ToDouble(discountStr);
            discountedtxtbox.Text = (price - discount).ToString("n2");

            // Store in your Variables1 object
            V.price = price;
            V.discount_amt = discount;
        }

        private void AddItem(string itemName, string priceStr, string discountStr = "0.00")
        {
            PIV.SetPriceDiscountAmountValue(discountStr, priceStr);

            V.price = Convert.ToDouble(PIV.GetPrice());
            V.discount_amt = Convert.ToDouble(PIV.GetDiscountAmount());
            V.quantity = 0;

            // Update the textboxes so user sees the price and discount
            Pricetxtbox.Text = V.price.ToString("n");
            discounttxtbox.Text = V.discount_amt.ToString("n");
            discountedtxtbox.Text = "0.00"; // reset discounted amount for now

            listBox1.Items.Add($"{itemName}: P{V.price}");
            listBox1.Items.Add($"Discount: P{V.discount_amt}");

            quantityTextBox(); // resets qtytextbox
        }

        private void UpdateTotals()
        {
            try
            {
                int qty = Convert.ToInt32(qtytextbox.Text);

                // Correct discounted amount calculation
                V.discounted_amt = (V.price - V.discount_amt) * qty;

                V.qty_total = qty;
                V.discounted_total = V.discounted_amt;

                discountedtxtbox.Text = V.discounted_amt.ToString("n2");
                totalbillstxtbox.Text = V.discounted_total.ToString("n2");
                totalqtytxtbox.Text = V.qty_total.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }




        private void pos2_Load(object sender, EventArgs e)
        {
            try
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

                // retrieve images from database
                P.pos_select_cashier();
                P.pos_cmd();
                P.pos_sqladapterSelect();
                P.pos_sqldatasetSELECT();


                //codes for throwing data from tables inside 
                checkBox1.Text = P.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                checkBox2.Text = P.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                checkBox3.Text = P.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                checkBox4.Text = P.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                checkBox5.Text = P.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                checkBox6.Text = P.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                checkBox7.Text = P.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                checkBox8.Text = P.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                checkBox9.Text = P.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                checkBox10.Text = P.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                checkBox11.Text = P.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                checkBox12.Text = P.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                checkBox13.Text = P.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                checkBox14.Text = P.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                checkBox15.Text = P.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                checkBox16.Text = P.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                checkBox17.Text = P.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                checkBox18.Text = P.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                checkBox19.Text = P.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                checkBox20.Text = P.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

                //image
                picpath1.Text = P.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                if (!string.IsNullOrEmpty(picpath1.Text) && System.IO.File.Exists(picpath1.Text))
                    pictureBox1.Image = Image.FromFile(picpath1.Text);

                picpath2.Text = P.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                if (!string.IsNullOrEmpty(picpath2.Text) && System.IO.File.Exists(picpath2.Text))
                    pictureBox2.Image = Image.FromFile(picpath2.Text);

                picpath3.Text = P.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
                if (!string.IsNullOrEmpty(picpath3.Text) && System.IO.File.Exists(picpath3.Text))
                    pictureBox3.Image = Image.FromFile(picpath3.Text);

                picpath4.Text = P.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
                if (!string.IsNullOrEmpty(picpath4.Text) && System.IO.File.Exists(picpath4.Text))
                    pictureBox4.Image = Image.FromFile(picpath4.Text);

                picpath5.Text = P.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
                if (!string.IsNullOrEmpty(picpath5.Text) && System.IO.File.Exists(picpath5.Text))
                    pictureBox5.Image = Image.FromFile(picpath5.Text);

                picpath6.Text = P.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
                if (!string.IsNullOrEmpty(picpath6.Text) && System.IO.File.Exists(picpath6.Text))
                    pictureBox6.Image = Image.FromFile(picpath6.Text);

                picpath7.Text = P.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
                if (!string.IsNullOrEmpty(picpath7.Text) && System.IO.File.Exists(picpath7.Text))
                    pictureBox7.Image = Image.FromFile(picpath7.Text);

                picpath8.Text = P.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
                if (!string.IsNullOrEmpty(picpath8.Text) && System.IO.File.Exists(picpath8.Text))
                    pictureBox8.Image = Image.FromFile(picpath8.Text);

                picpath9.Text = P.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
                if (!string.IsNullOrEmpty(picpath9.Text) && System.IO.File.Exists(picpath9.Text))
                    pictureBox9.Image = Image.FromFile(picpath9.Text);

                picpath10.Text = P.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
                if (!string.IsNullOrEmpty(picpath10.Text) && System.IO.File.Exists(picpath10.Text))
                    pictureBox10.Image = Image.FromFile(picpath10.Text);

                picpath11.Text = P.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
                if (!string.IsNullOrEmpty(picpath11.Text) && System.IO.File.Exists(picpath11.Text))
                    pictureBox11.Image = Image.FromFile(picpath11.Text);

                picpath12.Text = P.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
                if (!string.IsNullOrEmpty(picpath12.Text) && System.IO.File.Exists(picpath12.Text))
                    pictureBox12.Image = Image.FromFile(picpath12.Text);

                picpath13.Text = P.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
                if (!string.IsNullOrEmpty(picpath13.Text) && System.IO.File.Exists(picpath13.Text))
                    pictureBox13.Image = Image.FromFile(picpath13.Text);

                picpath14.Text = P.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
                if (!string.IsNullOrEmpty(picpath14.Text) && System.IO.File.Exists(picpath14.Text))
                    pictureBox14.Image = Image.FromFile(picpath14.Text);

                picpath15.Text = P.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
                if (!string.IsNullOrEmpty(picpath15.Text) && System.IO.File.Exists(picpath15.Text))
                    pictureBox15.Image = Image.FromFile(picpath15.Text);

                picpath16.Text = P.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
                if (!string.IsNullOrEmpty(picpath16.Text) && System.IO.File.Exists(picpath16.Text))
                    pictureBox16.Image = Image.FromFile(picpath16.Text);

                picpath17.Text = P.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
                if (!string.IsNullOrEmpty(picpath17.Text) && System.IO.File.Exists(picpath17.Text))
                    pictureBox17.Image = Image.FromFile(picpath17.Text);

                picpath18.Text = P.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
                if (!string.IsNullOrEmpty(picpath18.Text) && System.IO.File.Exists(picpath18.Text))
                    pictureBox18.Image = Image.FromFile(picpath18.Text);

                picpath19.Text = P.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
                if (!string.IsNullOrEmpty(picpath19.Text) && System.IO.File.Exists(picpath19.Text))
                    pictureBox19.Image = Image.FromFile(picpath19.Text);

                picpath20.Text = P.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
                if (!string.IsNullOrEmpty(picpath20.Text) && System.IO.File.Exists(picpath20.Text))
                    pictureBox20.Image = Image.FromFile(picpath20.Text);



                //price
                price1.Text = P.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                price2.Text = P.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                price3.Text = P.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                price4.Text = P.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                price5.Text = P.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                price6.Text = P.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                price7.Text = P.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                price8.Text = P.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                price9.Text = P.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                price10.Text = P.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                price11.Text = P.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                price12.Text = P.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                price13.Text = P.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                price14.Text = P.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                price15.Text = P.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                price16.Text = P.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                price17.Text = P.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                price18.Text = P.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                price19.Text = P.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                price20.Text = P.pos_sql_dataset.Tables[0].Rows[0][65].ToString();


                //hide marie
                picpath1.Hide(); picpath2.Hide(); picpath3.Hide(); picpath4.Hide(); picpath5.Hide();
                picpath6.Hide(); picpath7.Hide(); picpath8.Hide(); picpath9.Hide(); picpath10.Hide();
                picpath11.Hide(); picpath12.Hide(); picpath13.Hide(); picpath14.Hide(); picpath15.Hide();
                picpath16.Hide(); picpath17.Hide(); picpath18.Hide(); picpath19.Hide(); picpath20.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occur during loading of the application. Kindly contact your administrator");
            }
            }

        private void FoodARdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!FoodARdbtn.Checked) return;

            foodBRdbtn.Checked = false;

            // Numeric values without commas
            V.price = 1000; // assign numeric directly
            V.discount_amt = 200;

            Pricetxtbox.Text = V.price.ToString("n0");
            discounttxtbox.Text = V.discount_amt.ToString("n0");

            // Set default quantity
            qtytextbox.Text = "1";

            // Calculate totals properly
            UpdateTotals();

            // Add to listbox
            listBox1.Items.Add(FoodARdbtn.Text + ": P" + V.price.ToString("n0"));
            listBox1.Items.Add("Discount Amount: P" + V.discount_amt.ToString("n0"));
        }

        private void foodBRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!foodBRdbtn.Checked) return;

            FoodARdbtn.Checked = false;

            V.price = 1300;
            V.discount_amt = 195;

            Pricetxtbox.Text = V.price.ToString("n0");
            discounttxtbox.Text = V.discount_amt.ToString("n0");

            qtytextbox.Text = "1";

            UpdateTotals();

            listBox1.Items.Add(foodBRdbtn.Text + ": P" + V.price.ToString("n0"));
            listBox1.Items.Add("Discount Amount: P" + V.discount_amt.ToString("n0"));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert the cash given by the customer
                V.cash_given = Convert.ToDouble(cashgiventxtbox.Text);

                // Compute change
                V.change = V.cash_given - V.discounted_total;
                changetxtbox.Text = V.change.ToString("n");

               

                // Display totals
                listBox1.Items.Add("--------------------------");
                listBox1.Items.Add("Total Bills: ₱" + V.discounted_total.ToString("n"));
                listBox1.Items.Add("Cash Given: ₱" + V.cash_given.ToString("n"));
                listBox1.Items.Add("Change: ₱" + V.change.ToString("n"));
                listBox1.Items.Add("Total Quantity: " + V.qty_total);
            }
            catch
            {
                MessageBox.Show("Invalid Input for Cash Render!");
                cashgiventxtbox.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
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
            Pricetxtbox.Clear();
            qtytextbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            totalbillstxtbox.Clear();
            totalqtytxtbox.Clear();
            cashgiventxtbox.Clear();
            changetxtbox.Clear();

            V.price = 0;
            V.discount_amt = 0;
            V.discounted_amt = 0;
            V.qty_total = 0;
            V.discounted_total = 0;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qtytextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int qty = Convert.ToInt32(qtytextbox.Text);
                V.quantity = qty;

                V.discounted_amt = (V.price * qty) - V.discount_amt;

                V.qty_total += qty;
                V.discounted_total += V.discounted_amt;

                totalqtytxtbox.Text = V.qty_total.ToString();
                totalbillstxtbox.Text = V.discounted_total.ToString("n");
                discountedtxtbox.Text = V.discounted_amt.ToString("n");
            }
            catch
            {
                MessageBox.Show("Invalid Input");
                qtytextbox.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price1.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox1.Text + " - P" + Pricetxtbox.Text);

            }
            

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price2.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox2.Text + " - P" + Pricetxtbox.Text);

            }
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price3.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox3.Text + " - P" + Pricetxtbox.Text);

            }
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price4.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox4.Text + " - P" + Pricetxtbox.Text);

            }
           
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price5.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox5.Text + " - P" + Pricetxtbox.Text);

            }
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price6.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox6.Text + " - P" + Pricetxtbox.Text);

            }
           
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price7.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox7.Text + " - P" + Pricetxtbox.Text);

            }
            
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price8.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox8.Text + " - P" + Pricetxtbox.Text);

            }
            
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price9.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox9.Text + " - P" + Pricetxtbox.Text);

            }
            
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price10.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox10.Text + " - P" + Pricetxtbox.Text);

            }
            
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price11.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox11.Text + " - P" + Pricetxtbox.Text);

            }
            
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price12.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox12.Text + " - P" + Pricetxtbox.Text);

            }
           
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price13.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox13.Text + " - P" + Pricetxtbox.Text);

            }
            
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price14.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox14.Text + " - P" + Pricetxtbox.Text);

            }
          
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price15.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox15.Text + " - P" + Pricetxtbox.Text);

            }
           
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price16.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox16.Text + " - P" + Pricetxtbox.Text);

            }
           
        }
        

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price17.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox17.Text + " - P" + Pricetxtbox.Text);

            }
            
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price18.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox18.Text + " - P" + Pricetxtbox.Text);

            }
           
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price19.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox19.Text + " - P" + Pricetxtbox.Text);

            }
            
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {


                PIV.SetPriceDiscountAmountValue("0.00", price20.Text);
                GetPriceDiscountAmount();
                quantityTextBox();
                listBox1.Items.Add(checkBox20.Text + " - P" + Pricetxtbox.Text);

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos2_Class_printform print = new pos2_Class_printform();
            print.printlistBox1.Items.AddRange(this.listBox1.Items);
            print.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pos2_Class_transfer tf = new pos2_Class_transfer();

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
