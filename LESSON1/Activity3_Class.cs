using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1
{
    public partial class Activity3_Class : Form
    {
        //auto size the application within the windows
        private Dictionary<Control, float> originalFontSizes = new Dictionary<Control, float>();
        private Size designSize;


        Price_Item_Value piv = new Price_Item_Value();
        Variables1 v = new Variables1();

        
        public Activity3_Class()
        {
            InitializeComponent();

            // Prevent automatic WinForms scaling
            this.AutoScaleMode = AutoScaleMode.None;

            // Store original font sizes and design-time size
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Font != null)
                    originalFontSizes[ctrl] = ctrl.Font.Size;
            }
            designSize = this.Size;

            // Maximize form and scale controls once
            this.WindowState = FormWindowState.Maximized;
            ScaleControlsToScreen();
        }
        
        private void GetPriceItemValue()
        {
            itemnametxtbox.Text = (piv.GetItemName());
            pricetxtbox.Text = (piv.GetPrice());
        }
        private void Computation_FOrmula_DisplayData()
        {
            v.discounted_amt = (v.quantity * v.price) - v.discount_amt;
            discounttxtbox.Text = v.discount_amt.ToString("n2");
            discountedtxtbox.Text = v.discounted_amt.ToString("n2");
        }
        private void Quantitytxtbox()
        {
            qtytxtbox.Clear();
            qtytxtbox.Focus();

        }

        private void quantity_price()
        {
            v.quantity = Convert.ToInt32(qtytxtbox.Text);
            v.price = Convert.ToDouble(pricetxtbox.Text);
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

           

            label15.Text = "Winx Bloom Doll";
            label16.Text = "Angry Red Bird";
            label17.Text = "Pikachu Plushie";
            label18.Text = "Wooden Bunny";
            label19.Text = "Piggy Plushie";
            label20.Text = "Kuromi Keychain";
            label21.Text = "J. Rizal Statue";
            label22.Text = "Sniper Toy Gun";
            label23.Text = "Flying Elsa";
            label24.Text = "Dinasaur Green";

          
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
                v.cash_given = Convert.ToDouble(cash_renderedtxtbox.Text);

                v.qty_total += v.quantity;
                v.discount_totalgiven += v.discount_amt;
                v.discounted_total += v.discounted_amt;
                v.change = v.cash_given - v.discounted_total;

                qty_totaltxtbox.Text = v.qty_total.ToString();
                discount_totaltxtbox.Text = v.discount_totalgiven.ToString("n");
                discounted_totaltxtbox.Text = v.discounted_total.ToString("n");
                changetxtbox.Text = v.change.ToString("n2");
                cash_renderedtxtbox.Text = v.cash_given.ToString("n");          
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure cash given textbox is not empty invalid");
                cash_renderedtxtbox.Clear();
                cash_renderedtxtbox.Focus();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("Haunted Doll", "999");
            GetPriceItemValue();
           
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price();
                v.discount_amt = (v.quantity * v.price) * 0.30;
                Computation_FOrmula_DisplayData();
               

            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                qtytxtbox.Clear();
                qtytxtbox.Focus();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try

            {
                quantity_price();
                v.discount_amt = (v.quantity * v.price) * 0.10;
                Computation_FOrmula_DisplayData();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                qtytxtbox.Clear();
                qtytxtbox.Focus();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price();
                v.discount_amt = (v.quantity * v.price) * 0.15;
                Computation_FOrmula_DisplayData();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                qtytxtbox.Clear();
                qtytxtbox.Focus();
            }
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try

            {
                quantity_price();
                v.discount_amt = (v.quantity * v.price) * 0;
                Computation_FOrmula_DisplayData();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                qtytxtbox.Clear();
                qtytxtbox.Focus();

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
            cash_renderedtxtbox.Clear();
            discounted_totaltxtbox.Clear();
            discount_totaltxtbox.Clear();

            v.qty_total = 0;
            v.discount_totalgiven = 0;
            v.discounted_total = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("Winx Doll", "90.00");
            GetPriceItemValue();
            Quantitytxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("Angry Bird Plushie", "89");
            GetPriceItemValue();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("PIKACHU", "50");
            GetPriceItemValue();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("Wooden Bunny", "109");
            GetPriceItemValue();
            

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("Piggy Plushy", "120");
            GetPriceItemValue();
            

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("Kuromi Plushy", "150");
            GetPriceItemValue();
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("J.Rizal Statue", "499");
            GetPriceItemValue();
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("Sniper Toy Gun", "399");
            GetPriceItemValue();
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("Spinning Elsa", "218");
            GetPriceItemValue();
  
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("Green Dino", "79");
            GetPriceItemValue();
           
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("Cat Plushy", "200");
            GetPriceItemValue();
            
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("Bratz Doll", "400");
            GetPriceItemValue();
          
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("ICE CREAM SET", "678");
            GetPriceItemValue();
            
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("BaBy Alive", "800");
            GetPriceItemValue();
           
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("Band Aid", "45");
            GetPriceItemValue();
            
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Perfum Sprayer";
            pricetxtbox.Text = "67";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("BatangInaVlog Liptint", "25");
            GetPriceItemValue();
            
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("Original Labubu", "1200");
            GetPriceItemValue();
            
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            piv.SetPriceItemValue("BarangKateh Bracelet", "120");
            GetPriceItemValue();
        }
        private void ScaleControlsToScreen()
        {
            float scaleX = (float)Screen.PrimaryScreen.Bounds.Width / designSize.Width;
            float scaleY = (float)Screen.PrimaryScreen.Bounds.Height / designSize.Height;
            float scale = Math.Min(scaleX, scaleY);

            this.SuspendLayout();

            this.Scale(new SizeF(scale, scale));

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Font != null && originalFontSizes.ContainsKey(ctrl))
                {
                    ctrl.Font = new Font(ctrl.Font.FontFamily, originalFontSizes[ctrl] * scale, ctrl.Font.Style);
                }
            }

            this.ResumeLayout();
        }

        private void qtytxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
