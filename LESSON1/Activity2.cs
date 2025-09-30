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
    public partial class Activity2 : Form
    {
        public Activity2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Clear();
            pricetxtbox.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "BABY ALIVE DOLL";
            pricetxtbox.Text = "P250.00";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "BAND AID";
            pricetxtbox.Text = "P10.00";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "ANGERY RED BIRD";
            pricetxtbox.Text = "P70.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "LIMITED BRATZ DOLL";
            pricetxtbox.Text = "P1200.00";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "WOOD STACK PUZZLE BUNNY";
            pricetxtbox.Text = "P150.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "4 CUTE CAT";
            pricetxtbox.Text = "P175.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "FLYING ELSA";
            pricetxtbox.Text = "P499.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "ICE CREAM SET";
            pricetxtbox.Text = "P550.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "J. RIZAL STATUE";
            pricetxtbox.Text = "P980.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "PELLET TOY GUN";
            pricetxtbox.Text = "P400.00";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "KUROMI PLUSHY";
            pricetxtbox.Text = "P99.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "PIGGY PLUSHY";
            pricetxtbox.Text = "P79.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "SLEEPING PIKACHU COLLECTIBLE";
            pricetxtbox.Text = "P399.00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "DINASAUR GREEN";
            pricetxtbox.Text = "P55.00";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ITEMNAMETXTBOX.Text = "WINX BLOOM DOLL";
            pricetxtbox.Text = "P60.00";
        }

        private void Activity2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
