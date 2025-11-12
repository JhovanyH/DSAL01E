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
        private OpenFileDialog openFileDialog1;
        public POS_Admin()
        {
            posdb.pos_connString();
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog(); // Initialize it here
            openFileDialog1.Filter = "Image Files (*.gif, *.jpg, *.png, *.bmp)|*.gif;*.jpg;*.png;*.bmp";
        }

        private void POS_Admin_Load(object sender, EventArgs e)
        {
            try
            {
                picpath1.Hide(); picpath2.Hide(); picpath3.Hide(); picpath4.Hide(); picpath5.Hide();
                picpath6.Hide(); picpath7.Hide(); picpath8.Hide(); picpath9.Hide(); picpath10.Hide();
                picpath11.Hide(); picpath12.Hide(); picpath13.Hide(); picpath14.Hide(); picpath15.Hide();
                picpath16.Hide(); picpath17.Hide(); picpath18.Hide(); picpath19.Hide(); picpath20.Hide();
                //accessing pos_dbconnection
                posdb.pos_select();
                posdb.pos_cmd();
                posdb.pos_sqladapterSelect();
                posdb.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb.pos_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                //MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }

        }

        
        private void cleartextboxes()
        {
            try
             {
            //pic = Image.FromFile("C:\\Users\\C203-36\\Pictures\\perfum.png");\
            pic = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\question.png");

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
            openFileDialog1.ShowDialog();
        
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
           // try
           //{
                posdb.pos_sql = "INSERT INTO pos_nameTbl (pos_id, name1, name2, name3, name4, name5," +
                    "name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, name17," +
                    "name18, name19, name20) VALUES('" + pos_Id_noComboBox.Text + "', '" + nametxtbox1.Text +
                    "', '" + nametxtbox2.Text + "', '" + nametxtbox3.Text + "', '" + nametxtbox4.Text + "', '" +
                    nametxtbox5.Text + "', '" + nametxtbox6.Text + "', '" + nametxtbox7.Text + "', '" + nametxtbox8.Text + "', '" +
                    nametxtbox9.Text + "', '" + nametxtbox10.Text + "', '" + nametxtbox11.Text + "', '" + nametxtbox12.Text + "', '" +
                    nametxtbox13.Text + "', '" + nametxtbox14.Text + "', '" + nametxtbox15.Text + "', '" + nametxtbox16.Text + "', '" +
                    nametxtbox17.Text + "', '" + nametxtbox18.Text + "', '" + nametxtbox19.Text + "', '" + nametxtbox20.Text + "')";
                posdb.pos_cmd();
                posdb.pos_sqladapterInsert();
                
                
                posdb.pos_sql = "INSERT INTO pos_priceTbl (price1, price2, price3, price4, price5, price6, price7, price8, price9, price10," +
                    "price11, price12, price13, price14, price15, price16, price17, price18, price19, price20, pos_id) VALUES ('" + pricetxtbox1.Text +
                    "', '" + pricetxtbox2.Text + "' , '" + pricetxtbox3.Text + "' , '" + pricetxtbox4.Text + "' , '" + pricetxtbox5.Text + "' , '" +
                    pricetxtbox6.Text + "' , '" + pricetxtbox7.Text + "' , '" + pricetxtbox8.Text + "' , '" + pricetxtbox9.Text + "' , '" +
                    pricetxtbox10.Text + "' , '" + pricetxtbox11.Text + "' , '" + pricetxtbox12.Text + "' , '" + pricetxtbox13.Text + "' , '" +
                    pricetxtbox14.Text + "' , '" + pricetxtbox15.Text + "' , '" + pricetxtbox16.Text + "' , '" + pricetxtbox17.Text + "' , '" +
                    pricetxtbox18.Text + "' , '" + pricetxtbox19.Text + "' , '" + pricetxtbox20.Text + "' , '" + pos_Id_noComboBox.Text + "')";
                posdb.pos_cmd();
                posdb.pos_sqladapterInsert();


                posdb.pos_sql = "INSERT INTO pos_picTbl (pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10," +
                    "pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pos_id) VALUES ('" + picpath1.Text + "', '" + picpath2.Text + "', '"
                    + picpath3.Text + "', '" + picpath4.Text + "', '" + picpath5.Text + "', '" + picpath6.Text + "', '" + picpath7.Text +
                    "', '" + picpath8.Text + "', '" + picpath9.Text + "', '" + picpath10.Text + "', '" + picpath11.Text + "', '" + picpath12.Text +
                    "', '" + picpath13.Text + "', '" + picpath14.Text + "', '" + picpath15.Text + "', '" + picpath16.Text + "', '" + picpath17.Text +
                    "', '" + picpath18.Text + "', '" + picpath19.Text + "', '" + picpath20.Text + "', '" + pos_Id_noComboBox.Text + "')";
                posdb.pos_cmd();
                posdb.pos_sqladapterInsert();

                posdb.pos_select();
                posdb.pos_cmd();
                posdb.pos_sqladapterSelect();
                posdb.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb.pos_sql_dataset.Tables[0];
                cleartextboxes();

           //}
           //catch (Exception)
           // {
           //    MessageBox.Show("Error occurs in this area. Please contact your administrator!");
           //}
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                posdb.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN " +
                 "pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id = '" + pos_Id_noComboBox.Text + "'";
                posdb.pos_cmd();
                posdb.pos_sqladapterSelect();
                posdb.pos_sqldatasetSELECT();

                if (posdb.pos_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No record found with ID: " + pos_Id_noComboBox.Text);
                    return;
                }

                dataGridView1.DataSource = posdb.pos_sql_dataset.Tables[0];

                // Load names
                nametxtbox1.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                nametxtbox2.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                nametxtbox3.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                nametxtbox4.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                nametxtbox5.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                nametxtbox6.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                nametxtbox7.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                nametxtbox8.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                nametxtbox9.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                nametxtbox10.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                nametxtbox11.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                nametxtbox12.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                nametxtbox13.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                nametxtbox14.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                nametxtbox15.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                nametxtbox16.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                nametxtbox17.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                nametxtbox18.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                nametxtbox19.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                nametxtbox20.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

                // Load images with validation
                picpath1.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                if (!string.IsNullOrEmpty(picpath1.Text) && System.IO.File.Exists(picpath1.Text))
                    picturebox1.Image = Image.FromFile(picpath1.Text);

                picpath2.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                if (!string.IsNullOrEmpty(picpath2.Text) && System.IO.File.Exists(picpath2.Text))
                    picturebox2.Image = Image.FromFile(picpath2.Text);

                picpath3.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
                if (!string.IsNullOrEmpty(picpath3.Text) && System.IO.File.Exists(picpath3.Text))
                    picturebox3.Image = Image.FromFile(picpath3.Text);

                picpath4.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
                if (!string.IsNullOrEmpty(picpath4.Text) && System.IO.File.Exists(picpath4.Text))
                    picturebox4.Image = Image.FromFile(picpath4.Text);

                picpath5.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
                if (!string.IsNullOrEmpty(picpath5.Text) && System.IO.File.Exists(picpath5.Text))
                    picturebox5.Image = Image.FromFile(picpath5.Text);

                picpath6.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
                if (!string.IsNullOrEmpty(picpath6.Text) && System.IO.File.Exists(picpath6.Text))
                    picturebox6.Image = Image.FromFile(picpath6.Text);

                picpath7.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
                if (!string.IsNullOrEmpty(picpath7.Text) && System.IO.File.Exists(picpath7.Text))
                    picturebox7.Image = Image.FromFile(picpath7.Text);

                picpath8.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
                if (!string.IsNullOrEmpty(picpath8.Text) && System.IO.File.Exists(picpath8.Text))
                    picturebox8.Image = Image.FromFile(picpath8.Text);

                picpath9.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
                if (!string.IsNullOrEmpty(picpath9.Text) && System.IO.File.Exists(picpath9.Text))
                    picturebox9.Image = Image.FromFile(picpath9.Text);

                picpath10.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
                if (!string.IsNullOrEmpty(picpath10.Text) && System.IO.File.Exists(picpath10.Text))
                    picturebox10.Image = Image.FromFile(picpath10.Text);

                picpath11.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
                if (!string.IsNullOrEmpty(picpath11.Text) && System.IO.File.Exists(picpath11.Text))
                    picturebox11.Image = Image.FromFile(picpath11.Text);

                picpath12.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
                if (!string.IsNullOrEmpty(picpath12.Text) && System.IO.File.Exists(picpath12.Text))
                    picturebox12.Image = Image.FromFile(picpath12.Text);

                picpath13.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
                if (!string.IsNullOrEmpty(picpath13.Text) && System.IO.File.Exists(picpath13.Text))
                    picturebox13.Image = Image.FromFile(picpath13.Text);

                picpath14.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
                if (!string.IsNullOrEmpty(picpath14.Text) && System.IO.File.Exists(picpath14.Text))
                    picturebox14.Image = Image.FromFile(picpath14.Text);

                picpath15.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
                if (!string.IsNullOrEmpty(picpath15.Text) && System.IO.File.Exists(picpath15.Text))
                    picturebox15.Image = Image.FromFile(picpath15.Text);

                picpath16.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
                if (!string.IsNullOrEmpty(picpath16.Text) && System.IO.File.Exists(picpath16.Text))
                    picturebox16.Image = Image.FromFile(picpath16.Text);

                picpath17.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
                if (!string.IsNullOrEmpty(picpath17.Text) && System.IO.File.Exists(picpath17.Text))
                    picturebox17.Image = Image.FromFile(picpath17.Text);

                picpath18.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
                if (!string.IsNullOrEmpty(picpath18.Text) && System.IO.File.Exists(picpath18.Text))
                    picturebox18.Image = Image.FromFile(picpath18.Text);

                picpath19.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
                if (!string.IsNullOrEmpty(picpath19.Text) && System.IO.File.Exists(picpath19.Text))
                    picturebox19.Image = Image.FromFile(picpath19.Text);

                picpath20.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
                if (!string.IsNullOrEmpty(picpath20.Text) && System.IO.File.Exists(picpath20.Text))
                    picturebox20.Image = Image.FromFile(picpath20.Text);

                // Load prices
                pricetxtbox1.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                pricetxtbox2.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                pricetxtbox3.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                pricetxtbox4.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                pricetxtbox5.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                pricetxtbox6.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                pricetxtbox7.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                pricetxtbox8.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                pricetxtbox9.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                pricetxtbox10.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                pricetxtbox11.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                pricetxtbox12.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                pricetxtbox13.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                pricetxtbox14.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                pricetxtbox15.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                pricetxtbox16.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                pricetxtbox17.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                pricetxtbox18.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                pricetxtbox19.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                pricetxtbox20.Text = posdb.pos_sql_dataset.Tables[0].Rows[0][65].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            //try
            //{
            posdb.pos_sql = "UPDATE pos_nameTbl SET name1 = '" + nametxtbox1.Text + "', name2 = '" + nametxtbox2.Text + "'," +
                " name3 = '" + nametxtbox3.Text + "',  name4 = '" + nametxtbox4.Text + "',  name5 = '" + nametxtbox5.Text + "'," +
                " name6 = '" + nametxtbox6.Text + "',  name7 = '" + nametxtbox7.Text + "',  name8 = '" + nametxtbox8.Text + "'," +
                " name9 = '" + nametxtbox9.Text + "',  name10 = '" + nametxtbox10.Text + "',  name11 = '" + nametxtbox11.Text + "', " +
                " name12 = '" + nametxtbox12.Text + "',  name13 = '" + nametxtbox13.Text + "',  name14 = '" + nametxtbox14.Text + "', " +
                " name15 = '" + nametxtbox15.Text + "',  name16 = '" + nametxtbox16.Text + "',  name17 = '" + nametxtbox17.Text + "', " +
                " name18 = '" + nametxtbox18.Text + "',  name19 = '" + nametxtbox19.Text + "',  name20 = '" + nametxtbox20.Text + "' WHERE " +
                "pos_id = '" + pos_Id_noComboBox.Text + "'";
            posdb.pos_cmd();
            posdb.pos_sqladapterUpdate();

            posdb.pos_sql = "UPDATE pos_picTbl SET pic1 = '" + picpath1.Text + "', pic2 = '" + picpath2.Text + "', pic3 = '" + picpath3.Text + "'," +
                "pic4 = '" + picpath4.Text + "', pic5 = '" + picpath5.Text + "', pic6 = '" + picpath6.Text + "', pic7 = '" + picpath7.Text + "'," +
                "pic8 = '" + picpath8.Text + "', pic9 = '" + picpath9.Text + "', pic10 = '" + picpath10.Text + "', pic11 = '" + picpath11.Text + "'," +
                "pic12 = '" + picpath12.Text + "', pic13 = '" + picpath13.Text + "', pic14 = '" + picpath14.Text + "', pic15 = '" + picpath15.Text + "'," +
                "pic16 = '" + picpath16.Text + "', pic17 = '" + picpath17.Text + "', pic18 = '" + picpath18.Text + "', pic19 = '" + picpath19.Text + "', " +
                "pic20 = '" + picpath20.Text + "' WHERE pos_id = '" + pos_Id_noComboBox.Text + "'";
            posdb.pos_cmd();
            posdb.pos_sqladapterUpdate();

            posdb.pos_sql = "UPDATE pos_priceTbl SET price1 = '" + pricetxtbox1.Text + "', price2 = '" + pricetxtbox2.Text + "'," +
            "price3 = '" + pricetxtbox3.Text + "', price4 = '" + pricetxtbox4.Text + "', price5 = '" + pricetxtbox5.Text + "'," +
            "price6 = '" + pricetxtbox6.Text + "', price7 = '" + pricetxtbox7.Text + "', price8 = '" + pricetxtbox8.Text + "'," +
            "price9 = '" + pricetxtbox9.Text + "', price10 = '" + pricetxtbox10.Text + "', price11 = '" + pricetxtbox11.Text + "'," +
            "price12 = '" + pricetxtbox12.Text + "', price13 = '" + pricetxtbox13.Text + "', price14 = '" + pricetxtbox14.Text + "'," +
            "price15 = '" + pricetxtbox15.Text + "', price16 = '" + pricetxtbox16.Text + "', price17 = '" + pricetxtbox17.Text + "'," +
            "price18 = '" + pricetxtbox18.Text + "', price19 = '" + pricetxtbox19.Text + "', price20 = '" + pricetxtbox20.Text + "' WHERE " +
            "pos_id = '" + pos_Id_noComboBox.Text + "'";
            posdb.pos_cmd();
            posdb.pos_sqladapterUpdate();

            posdb.pos_select();
            posdb.pos_cmd();
            posdb.pos_sqladapterSelect();
            posdb.pos_sqldatasetSELECT();
            dataGridView1.DataSource = posdb.pos_sql_dataset.Tables[0];
            cleartextboxes();

            //}
            //catch (Exception)
            //{
            //MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            //}
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
            posdb.pos_sql = "DELETE FROM pos_priceTbl WHERE pos_priceTbl.pos_id = '" + pos_Id_noComboBox.Text + "'";
            posdb.pos_cmd();
            posdb.pos_sqladapterDelete();

            posdb.pos_sql = "DELETE FROM pos_picTbl WHERE pos_picTbl.pos_id = '" + pos_Id_noComboBox.Text + "'";
            posdb.pos_cmd();
            posdb.pos_sqladapterDelete();

            posdb.pos_sql = "DELETE FROM pos_nameTbl WHERE pos_nameTbl.pos_id = '" + pos_Id_noComboBox.Text + "'";
            posdb.pos_cmd();
            posdb.pos_sqladapterDelete();

            posdb.pos_select();
            posdb.pos_cmd();
            posdb.pos_sqladapterSelect();
            posdb.pos_sqldatasetSELECT();
            dataGridView1.DataSource = posdb.pos_sql_dataset.Tables[0];
            cleartextboxes();

            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void new_cancelbutton_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picturebox1_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox1.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath1.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox2_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox2.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath2.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox3_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox3.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath3.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox4_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox4.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath4.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox5_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox5.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath5.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox6_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox6.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath6.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox7_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox7.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath7.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox8_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox8.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath8.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox9_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox9.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath9.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox10_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox10.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath10.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox11_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox11.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath11.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox12_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox12.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath12.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox13_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox13.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath13.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox14_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox14.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath14.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox15_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox15.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath15.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox16_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox16.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath16.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox17_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox17.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath17.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox18_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox18.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath18.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox19_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox19.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath19.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void picturebox20_Click(object sender, EventArgs e)
        {
            try
            {
            open_file_image();
            picturebox20.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpath20.Text = picpath;
            }
            catch (Exception)
            {
            MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
    }  
}
