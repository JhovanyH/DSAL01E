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
    public partial class POS1_DATABASE : Form
    {
        pos_dbconnection pb = new pos_dbconnection();
        Price_Item_Value piv = new Price_Item_Value();
        Variables1 v = new Variables1();

        //auto size the application within the windows
        private Size baseSize;

        int qty_total = 0;
        double discount_totalGiven = 0;
        double discounted_totalGiven = 0;
        int qty = 0;
        double discount_amt = 0, discounted_amt = 0, cash_rendered = 0, change = 0;

        //admin
        private string _terminalNo = "1";
        private string _empId = "";
        private string _firstName = "";
        private string _surname = "";
        private bool _isAdminMode = false;

        public POS1_DATABASE()
        {
            pb.pos_connString();
            InitializeComponent();
        }
        //admin purposes
        public void SetTerminalInfo(string terminalNo, string empId, string firstName, string surname)
        {
            _terminalNo = terminalNo;
            _empId = empId;
            _firstName = firstName;
            _surname = surname;
            _isAdminMode = false;
        }

        //admin purposes
        public void SetAsAdminMode(string terminalNo)
        {
            _terminalNo = terminalNo;
            _empId = "ADMIN-TEST";
            _firstName = "Admin";
            _surname = "Testing";
            _isAdminMode = true;
        }
        private void quantityTxtbox()
        {
            qtytxtbox.Clear();
            qtytxtbox.Focus();
        }

        private void quantity_price_convert()
        {
            v.quantity = Convert.ToInt32(qtytxtbox.Text);
            v.price = Convert.ToDouble(pricetxtbox.Text);
        }

        private void computation_formula_and_displaydata()
        {
            v.discounted_amt = (v.quantity * v.price) - v.discount_amt;
            discounttxtbox.Text = v.discount_amt.ToString("n");
            discountedtxtbox.Text = v.discounted_amt.ToString("n");
        }

        private void GetpriceItemValue()
        {
            itemnametxtbox.Text = (piv.GetItemName());
            pricetxtbox.Text = (piv.GetPriceItem());
        }

        private void clearTxtboxes()
        {
            itemnametxtbox.Clear();
            pricetxtbox.Clear();
            qtytxtbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            textBox9.Clear();
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

           

            name1.Text = "Winx Bloom Doll";
            name2.Text = "Angry Red Bird";
            name3.Text = "Pikachu Plushie";
            name4.Text = "Wooden Bunny";
            name5.Text = "Piggy Plushie";
            name6.Text = "Kuromi Keychain";
            name7.Text = "J. Rizal Statue";
            name8.Text = "Sniper Toy Gun";
            name9.Text = "Flying Elsa";
            name10.Text = "Dinasaur Green";


            //hide marie
            picpath1.Hide(); picpath2.Hide(); picpath3.Hide(); picpath4.Hide(); picpath5.Hide();
            picpath6.Hide(); picpath7.Hide(); picpath8.Hide(); picpath9.Hide(); picpath10.Hide();
            picpath11.Hide(); picpath12.Hide(); picpath13.Hide(); picpath14.Hide(); picpath15.Hide();
            picpath16.Hide(); picpath17.Hide(); picpath18.Hide(); picpath19.Hide(); picpath20.Hide();

            //retrieve data from the database and display it in the interface object
            pb.pos_select_cashier();
            pb.pos_cmd();
            pb.pos_sqladapterSelect();
            pb.pos_sqldatasetSELECT();

            //codes for throwing data from tables inside 
            name1.Text = pb.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            name2.Text = pb.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            name3.Text = pb.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
            name4.Text = pb.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
            name5.Text = pb.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
            name6.Text = pb.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
            name7.Text = pb.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
            name8.Text = pb.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
            name9.Text = pb.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
            name10.Text = pb.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
            name11.Text = pb.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
            name12.Text = pb.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
            name13.Text = pb.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
            name14.Text = pb.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
            name15.Text = pb.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
            name16.Text = pb.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
            name17.Text = pb.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
            name18.Text = pb.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
            name19.Text = pb.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
            name20.Text = pb.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

            //image
            picpath1.Text = pb.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
            if (!string.IsNullOrEmpty(picpath1.Text) && System.IO.File.Exists(picpath1.Text))
                pictureBox1.Image = Image.FromFile(picpath1.Text);

            picpath2.Text = pb.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
            if (!string.IsNullOrEmpty(picpath2.Text) && System.IO.File.Exists(picpath2.Text))
                pictureBox2.Image = Image.FromFile(picpath2.Text);

            picpath3.Text = pb.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
            if (!string.IsNullOrEmpty(picpath3.Text) && System.IO.File.Exists(picpath3.Text))
                pictureBox3.Image = Image.FromFile(picpath3.Text);

            picpath4.Text = pb.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
            if (!string.IsNullOrEmpty(picpath4.Text) && System.IO.File.Exists(picpath4.Text))
                pictureBox4.Image = Image.FromFile(picpath4.Text);

            picpath5.Text = pb.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
            if (!string.IsNullOrEmpty(picpath5.Text) && System.IO.File.Exists(picpath5.Text))
                pictureBox5.Image = Image.FromFile(picpath5.Text);

            picpath6.Text = pb.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
            if (!string.IsNullOrEmpty(picpath6.Text) && System.IO.File.Exists(picpath6.Text))
                pictureBox6.Image = Image.FromFile(picpath6.Text);

            picpath7.Text = pb.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
            if (!string.IsNullOrEmpty(picpath7.Text) && System.IO.File.Exists(picpath7.Text))
                pictureBox7.Image = Image.FromFile(picpath7.Text);

            picpath8.Text = pb.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
            if (!string.IsNullOrEmpty(picpath8.Text) && System.IO.File.Exists(picpath8.Text))
                pictureBox8.Image = Image.FromFile(picpath8.Text);

            picpath9.Text = pb.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
            if (!string.IsNullOrEmpty(picpath9.Text) && System.IO.File.Exists(picpath9.Text))
                pictureBox9.Image = Image.FromFile(picpath9.Text);

            picpath10.Text = pb.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
            if (!string.IsNullOrEmpty(picpath10.Text) && System.IO.File.Exists(picpath10.Text))
                pictureBox10.Image = Image.FromFile(picpath10.Text);

            picpath11.Text = pb.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
            if (!string.IsNullOrEmpty(picpath11.Text) && System.IO.File.Exists(picpath11.Text))
                pictureBox11.Image = Image.FromFile(picpath11.Text);

            picpath12.Text = pb.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
            if (!string.IsNullOrEmpty(picpath12.Text) && System.IO.File.Exists(picpath12.Text))
                pictureBox12.Image = Image.FromFile(picpath12.Text);

            picpath13.Text = pb.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
            if (!string.IsNullOrEmpty(picpath13.Text) && System.IO.File.Exists(picpath13.Text))
                pictureBox13.Image = Image.FromFile(picpath13.Text);

            picpath14.Text = pb.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
            if (!string.IsNullOrEmpty(picpath14.Text) && System.IO.File.Exists(picpath14.Text))
                pictureBox14.Image = Image.FromFile(picpath14.Text);

            picpath15.Text = pb.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
            if (!string.IsNullOrEmpty(picpath15.Text) && System.IO.File.Exists(picpath15.Text))
                pictureBox15.Image = Image.FromFile(picpath15.Text);

            picpath16.Text = pb.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
            if (!string.IsNullOrEmpty(picpath16.Text) && System.IO.File.Exists(picpath16.Text))
                pictureBox16.Image = Image.FromFile(picpath16.Text);

            picpath17.Text = pb.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
            if (!string.IsNullOrEmpty(picpath17.Text) && System.IO.File.Exists(picpath17.Text))
                pictureBox17.Image = Image.FromFile(picpath17.Text);

            picpath18.Text = pb.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
            if (!string.IsNullOrEmpty(picpath18.Text) && System.IO.File.Exists(picpath18.Text))
                pictureBox18.Image = Image.FromFile(picpath18.Text);

            picpath19.Text = pb.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
            if (!string.IsNullOrEmpty(picpath19.Text) && System.IO.File.Exists(picpath19.Text))
                pictureBox19.Image = Image.FromFile(picpath19.Text);

            picpath20.Text = pb.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
            if (!string.IsNullOrEmpty(picpath20.Text) && System.IO.File.Exists(picpath20.Text))
                pictureBox20.Image = Image.FromFile(picpath20.Text);

            //price
            price1.Text = pb.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
            price2.Text = pb.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
            price3.Text = pb.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
            price4.Text = pb.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
            price5.Text = pb.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
            price6.Text = pb.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
            price7.Text = pb.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
            price8.Text = pb.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
            price9.Text = pb.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
            price10.Text = pb.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
            price11.Text = pb.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
            price12.Text = pb.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
            price13.Text = pb.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
            price14.Text = pb.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
            price15.Text = pb.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
            price16.Text = pb.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
            price17.Text = pb.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
            price18.Text = pb.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
            price19.Text = pb.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
            price20.Text = pb.pos_sql_dataset.Tables[0].Rows[0][65].ToString();

            //codes for retrieving data from the tables inside the database 
            pb.pos_select_cashier_display();
            pb.pos_cmd();
            pb.pos_sqladapterSelect();
            pb.pos_select_cashier_SELECTdisplay();

            //codes for throwing data from tables 
            terminal_no.Text = pb.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            emp_id.Text = pb.pos_sql_dataset.Tables[0].Rows[0][0].ToString();
            emp_fname.Text = pb.pos_sql_dataset.Tables[0].Rows[0][1].ToString();
            emp_surname.Text = pb.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            DateTime dt = DateTime.Now;
            time_date.Text = dt.ToString("MMMM dd, yyyy");

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
                
               


                v.quantity = Convert.ToInt32(qtytxtbox.Text);
                v.discount_amt = Convert.ToDouble(discounttxtbox.Text);
                v.discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
                v.cash_given= Convert.ToDouble(textBox9.Text);

                v.qty_total += v.quantity;
                v.discount_totalgiven += v.discount_amt;
                v.discounted_total += v.discounted_amt;
                v.change = v.cash_given - v.discounted_total;


                qty_totaltxtbox.Text = v.qty_total.ToString();
                discount_totaltxtbox.Text = v.discount_totalgiven.ToString("n");
                discounted_totaltxtbox.Text = v.discounted_total.ToString("n");
                changetxtbox.Text = v.change.ToString("n");
                textBox9.Text = v.cash_given.ToString("n");
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
            piv.SetPriceItemValue(name16.Text, price16.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //int qty;
                //double price, discount_amt, discounted_amt;
                //qty = Convert.ToInt32(qtytxtbox.Text);
                //price = Convert.ToDouble(pricetxtbox.Text);
                //discount_amt = (qty * price) * 0.30;
                //discounted_amt = (qty * price) - discount_amt;
                //discounttxtbox.Text = discount_amt.ToString("n");
                //discountedtxtbox.Text = discounted_amt.ToString("n");
                //radioButton2.Checked = false;
                //radioButton3.Checked = false;
                //radioButton4.Checked = false;
                quantity_price_convert();
                v.discount_amt = (v.quantity * v.price) * 0.30;
                computation_formula_and_displaydata();
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try

            {
                //int qty;
                //double price, discount_amt, discounted_amt;
                //qty = Convert.ToInt32(qtytxtbox.Text);
                //price = Convert.ToDouble(pricetxtbox.Text);
                //discount_amt = (qty * price) * 0.10;
                //discounted_amt = (qty * price) - discount_amt;
                //discounttxtbox.Text = discount_amt.ToString("n");
                //discountedtxtbox.Text = discounted_amt.ToString("n");
                //radioButton1.Checked = false;
                //radioButton3.Checked = false;
                //radioButton4.Checked = false;
                quantity_price_convert();
                v.discount_amt = (v.quantity * v.price) * 0.10;
                computation_formula_and_displaydata();
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //int qty;
                //double price, discount_amt, discounted_amt;
                //qty = Convert.ToInt32(qtytxtbox.Text);
                //price = Convert.ToDouble(pricetxtbox.Text);
                //discount_amt = (qty * price) * 0.15;
                //discounted_amt = (qty * price) - discount_amt;
                //discounttxtbox.Text = discount_amt.ToString("n");
                //discountedtxtbox.Text = discounted_amt.ToString("n");
                //radioButton2.Checked = false;
                //radioButton1.Checked = false;
                //radioButton4.Checked = false;

                quantity_price_convert();
                v.discount_amt = (v.quantity * v.price) * 0.15;
                computation_formula_and_displaydata();
                radioButton2.Checked = false;
                radioButton1.Checked = false;
                radioButton4.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try

            {
                //int qty;
                //double price, discount_amt, discounted_amt;
                //qty = Convert.ToInt32(qtytxtbox.Text);
                //price = Convert.ToDouble(pricetxtbox.Text);
                //discount_amt = (qty * price) * 0;
                //discounted_amt = (qty * price) - discount_amt;
                //discounttxtbox.Text = discount_amt.ToString("n");
                //discountedtxtbox.Text = discounted_amt.ToString("n");
                //radioButton2.Checked = false;
                //radioButton3.Checked = false;
                //radioButton1.Checked = false;

                quantity_price_convert();
                v.discount_amt = (v.quantity * v.price) * 0;
                computation_formula_and_displaydata();
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton1.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();

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
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            qty_total = 0;
            discount_totalGiven = 0;
            discounted_totalGiven = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name1.Text, price1.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name2.Text, price2.Text);
            GetpriceItemValue();
            quantityTxtbox();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name3.Text, price3.Text);
            GetpriceItemValue();
            quantityTxtbox(); ;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name4.Text, price4.Text);
            GetpriceItemValue();
            quantityTxtbox();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name5.Text, price5.Text);
            GetpriceItemValue();
            quantityTxtbox();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name6.Text, price6.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name7.Text, price7.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name8.Text, price8.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name9.Text, price9.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name10.Text, price10.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name11.Text, price11.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name12.Text, price12.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name13.Text, price13.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name14.Text, price14.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name15.Text, price15.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name17.Text, price17.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name18.Text, price18.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pb.pos_sql = "INSERT INTO salesTbl (product_name, product_quantity_per_transaction, product_price, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, summary_total_disc_given, " +
                              "summary_total_discounted_amount, terminal_no, time_date, emp_id) VALUES ('" + itemnametxtbox.Text + "', '" + qtytxtbox.Text
                               + "', '" + pricetxtbox.Text + "', '" + radioButton1.Text + "', '" + discounttxtbox.Text + "', '" + discountedtxtbox.Text +
                               "', '" + qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" + discounted_totaltxtbox.Text + "', '" + terminal_no.Text + "', '" +
                               time_date.Text + "', '" + emp_id.Text + "')";
                pb.pos_cmd();
                pb.pos_sqladapterInsert();
                clearTxtboxes();

            }
            else if (radioButton2.Checked == true)
            {
                pb.pos_sql = "INSERT INTO salesTbl (product_name, product_quantity_per_transaction, product_price, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, summary_total_disc_given, " +
                              "summary_total_discounted_amount, terminal_no, time_date, emp_id) VALUES ('" + itemnametxtbox.Text + "', '" + qtytxtbox.Text
                               + "', '" + pricetxtbox.Text + "', '" + radioButton2.Text + "', '" + discounttxtbox.Text + "', '" + discountedtxtbox.Text +
                               "', '" + qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" + discounted_totaltxtbox.Text + "', '" + terminal_no.Text + "', '" +
                               time_date.Text + "', '" + emp_id.Text + "')";
                pb.pos_cmd();
                pb.pos_sqladapterInsert();
                clearTxtboxes();


            }
            else if (radioButton3.Checked == true)
            {
                pb.pos_sql = "INSERT INTO salesTbl (product_name, product_quantity_per_transaction, product_price, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, summary_total_disc_given, " +
                              "summary_total_discounted_amount, terminal_no, time_date, emp_id) VALUES ('" + itemnametxtbox.Text + "', '" + qtytxtbox.Text
                               + "', '" + pricetxtbox.Text + "', '" + radioButton3.Text + "', '" + discounttxtbox.Text + "', '" + discountedtxtbox.Text +
                               "', '" + qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" + discounted_totaltxtbox.Text + "', '" + terminal_no.Text + "', '" +
                               time_date.Text + "', '" + emp_id.Text + "')";
                pb.pos_cmd();
                pb.pos_sqladapterInsert();
                clearTxtboxes();
            }
            else if (radioButton4.Checked == true)
            {
                pb.pos_sql = "INSERT INTO salesTbl (product_name, product_quantity_per_transaction, product_price, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, summary_total_disc_given, " +
                              "summary_total_discounted_amount, terminal_no, time_date, emp_id) VALUES ('" + itemnametxtbox.Text + "', '" + qtytxtbox.Text
                               + "', '" + pricetxtbox.Text + "', '" + radioButton4.Text + "', '" + discounttxtbox.Text + "', '" + discountedtxtbox.Text +
                               "', '" + qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" + discounted_totaltxtbox.Text + "', '" + terminal_no.Text + "', '" +
                               time_date.Text + "', '" + emp_id.Text + "')";
                pb.pos_cmd();
                pb.pos_sqladapterInsert();
                clearTxtboxes();
            }
            else
                MessageBox.Show("No selected discount option!");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name19.Text, price19.Text);
            GetpriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue(name20.Text, price20.Text);
            GetpriceItemValue();
            quantityTxtbox();
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
