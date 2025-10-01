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
    public partial class Activity_4 : Form
    {
        private double total_amount = 0;
        private int total_qty = 0;
        public Activity_4()
        {
            InitializeComponent();
        }

        private void Activity_4_Load(object sender, EventArgs e)
        {
            //disable all the needed textboxes and boxes
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

            FoodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;

            // maximized the screen
            this.WindowState = FormWindowState.Maximized;
        }

        private void FoodARdbtn_CheckedChanged(object sender, EventArgs e)
        {
            //initialize
            double price;
            
            //display
            DisplayPictureBox.Image = Image.FromFile(@"C:\Users\jhovany\OneDrive\Pictures\Screenshots\collectibles.png");

            //disable 
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

            //formula
            Pricetxtbox.Text = "1,000.00";
            discounttxtbox.Text = "200.00";
            price = Convert.ToDouble(Pricetxtbox.Text);
            listBox1.Items.Add(FoodARdbtn.Text + ": P" + Pricetxtbox.Text);
            listBox1.Items.Add("Discount Amount: P" + discounttxtbox.Text);
            qtytxtbox.Text = "0";
            qtytxtbox.Focus();
        }

        private void foodBRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            //disable
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

            //display
            DisplayPictureBox.Image = Image.FromFile(@"C:\Users\jhovany\OneDrive\Pictures\Screenshots\collectibles2.png");

            //formula
            Pricetxtbox.Text = "1,299.00";
            discounttxtbox.Text = "194.85";
            listBox1.Items.Add(foodBRdbtn.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
