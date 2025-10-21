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
    public partial class POS_Admin : Form
    {
        pos_dbconnection posdb = new pos_dbconnection();
        private string picpath;
        private Image pic;


        public POS_Admin()
        {
            posdb.pos_connString();
            InitializeComponent();
        }

        private void POS_Admin_Load(object sender, EventArgs e)
        {

        }
        private void cleartextboxes()
        {
            try
            {
                pic = Image.FromFile("C:\\Users\\C203-36\\Pictures\\perfum.png");

                //picpath
                picpath1.Clear(); picpath2.Clear(); picpath3.Clear(); picpath4.Clear(); picpath5.Clear();
                picpath6.Clear(); picpath7.Clear(); picpath8.Clear(); picpath9.Clear(); picpath10.Clear();
                picpath11.Clear(); picpath12.Clear(); picpath13.Clear(); picpath14.Clear(); picpath15.Clear();
                picpath16.Clear(); picpath17.Clear(); picpath18.Clear(); picpath19.Clear(); picpath20.Clear();
                //picbox
                picturebox1.Image = pic; picturebox2.Image = pic; picturebox3.Image = pic; picturebox4.Image = pic; picturebox5.Image = pic;
                picturebox6.Image = pic; picturebox7.Image = pic; picturebox8.Image = pic; picturebox9.Image = pic; picturebox10.Image = pic;
                picturebox11.Image = pic; picturebox12.Image = pic; picturebox13.Image = pic; picturebox14.Image = pic; picturebox15.Image = pic;
                picturebox16.Image = pic; picturebox17.Image = pic; picturebox18.Image = pic; picturebox19.Image = pic; picturebox20.Image = pic;
                //pricetxtbox
                pricetxtbox1.Clear(); pricetxtbox2.Clear(); pricetxtbox3.Clear(); pricetxtbox4.Clear(); pricetxtbox5.Clear();
                pricetxtbox6.Clear(); pricetxtbox7.Clear(); pricetxtbox8.Clear(); pricetxtbox9.Clear(); pricetxtbox10.Clear();
                pricetxtbox11.Clear(); pricetxtbox12.Clear(); pricetxtbox13.Clear(); pricetxtbox14.Clear(); pricetxtbox15.Clear();
                pricetxtbox16.Clear(); pricetxtbox17.Clear(); pricetxtbox18.Clear(); pricetxtbox19.Clear(); pricetxtbox20.Clear();
                //nametxtbox
                nametxtbox1.Clear(); nametxtbox2.Clear(); nametxtbox3.Clear(); nametxtbox4.Clear(); nametxtbox5.Clear();
                nametxtbox6.Clear(); nametxtbox7.Clear(); nametxtbox8.Clear(); nametxtbox9.Clear(); nametxtbox10.Clear();
                nametxtbox11.Clear(); nametxtbox12.Clear(); nametxtbox13.Clear(); nametxtbox14.Clear(); nametxtbox15.Clear();
                nametxtbox16.Clear(); nametxtbox17.Clear(); nametxtbox18.Clear(); nametxtbox19.Clear(); nametxtbox20.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
        private void open_file_image()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.gif, *.jpg, *.png, *.bmp)|*.gif;*.jpg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
                // You can now use selectedFile however you like

            }
        }
    }  
}
