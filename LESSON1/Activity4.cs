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
    public partial class Activity4 : Form
    {
        public Activity4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
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

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
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
            Discounttxtbox.Clear();

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
    }
}
