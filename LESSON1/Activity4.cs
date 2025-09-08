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
            Pricetxtbox.Text = "P1299.00";
            discounttxtbox.Text = "(15% of the Price) P194.85";
            listBox1.Items.Add(FoodARdbtn.Text);


            
            
            
            
            
            
            this.BackColor = Color.SlateGray;
            FoodARdbtn.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\Screenshot 2025-08-26 150856.png");


            RandomPlushies.Checked = true;
            handmade.Checked = true;
            protectkit2.Checked = true;
            notebooks.Checked = true;
            limited2.Checked = true;

            Keychains.Checked = false;
            Plushies.Checked = false;
            ProtectKit1.Checked = false;
            Ballpens.Checked = false;
            randomCollect1.Checked = false;



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








        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            this.BackColor = Color.White;
            foodBRdbtn.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\Pikachu.png");


            RandomPlushies.Checked = false;
            handmade.Checked = false;
            protectkit2.Checked = false;
            notebooks.Checked = false;
            limited2.Checked = false;

            Keychains.Checked = true;
            Plushies.Checked = true;
            ProtectKit1.Checked = true;
            Ballpens.Checked = true;    
            randomCollect1.Checked = true;


            Pricetxtbox.Text = "1,000.00";
            discounttxtbox.Text = "200.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add(foodBRdbtn.Text + "" +
                Pricetxtbox.Text);
            listBox1.Items.Add("     Discount Amount: " + "" +
                discounttxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();






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

        }

        private void cashgiventxtbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            double cash_given, change, total_amountpaid;
            cash_given = Convert.ToDouble(cashgiventxtbox.Text);
            total_amountpaid = Convert.ToDouble(cashgiventxtbox.Text);
            change = cash_given - total_amountpaid;
            changetxtbox.Text = change.ToString("n");
            listBox1.Items.Add("Total Bills:  " + ""
                + totalbillstxtbox.Text);
            listBox1.Items.Add("Cash Given: " + "" +
                cashgiventxtbox.Text);
            listBox1.Items.Add("Total no. of Items: " + ""
                +totalqtytxtbox.Text);


        }

        private void button3_Click(object sender, EventArgs e)
        {

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
    }
}
