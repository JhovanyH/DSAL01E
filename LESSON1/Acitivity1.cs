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
    using System.Data.SqlClient;
    using System.Data;
    public partial class Activity1 : Form
    {
        string picpath;
        string connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;
  

        public Activity1()
        {
            InitializeComponent();
            connectionString = @"Data Source = LAPTOP-8COQ8R8Q\SQLEXPRESS; Initial Catalog = simpledatabaseDb;Integrated Security=True;";
            connection = new SqlConnection(connectionString);
        }

        private void Activity1_Load_1(object sender, EventArgs e)
        {
            connection.Open();
            sql = "Select * from studenttbl";
            command = new SqlCommand(sql, connection);
            adaptersql = new SqlDataAdapter(command);
            dset = new DataSet();
            adaptersql.Fill(dset, "studenttbl");
            dataGridView1.DataSource = dset.Tables[0];
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "INSERT INTO studenttbl (stud_id, stud_name, stud_dept, picpath) " +
            "VALUES ('" + student_numtxtbox.Text + "', '" +
                  stud_nametxtbox.Text + "', '" +
                  stud_depttxtbox.Text + "', '" +
                  picturepathtxtbox.Text + "')";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            sql = "Select * from studenttbl ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            // command.ExecuteNonQuery();  <-- DELETE THIS LINE!

            dset = new DataSet();
            adaptersql.Fill(dset, "studenttbl");
            dataGridView1.DataSource = dset.Tables[0];
            picturebox.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\baby.png");
            student_numtxtbox.Clear();
            stud_depttxtbox.Clear();
            stud_nametxtbox.Clear();
            picturepathtxtbox.Clear();
            connection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();

            sql = "Select * from studenttbl where stud_id = '" +
                student_numtxtbox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            //command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studenttbl");

            dataGridView1.DataSource = dset.Tables[0];

            stud_nametxtbox.Text = dset.Tables[0].Rows[0][1].ToString();
            stud_depttxtbox.Text = dset.Tables[0].Rows[0][3].ToString();
            picturepathtxtbox.Text = dset.Tables[0].Rows[0][2].ToString();
            //iba code ni mam
            if (System.IO.File.Exists(picturepathtxtbox.Text))
            {
                picturebox.Image = Image.FromFile(picturepathtxtbox.Text);
            }
            else
            {
                picturebox.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\baby.png");
            }
            //
            connection.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();

            sql = "delete from studenttbl where stud_id = '" + student_numtxtbox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();


            sql = "select * from studenttbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            adaptersql.SelectCommand = command;  // ADD THIS LINE!


            dset = new DataSet();
            adaptersql.Fill(dset, "studenttbl");

            dataGridView1.DataSource = dset.Tables[0];

            picturebox.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\haunted.png");
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "UPDATE studenttbl SET " +
        "stud_name = '" + stud_nametxtbox.Text + "', " +
        "stud_dept = '" + stud_depttxtbox.Text + "', " +
        "picpath = '" + picturepathtxtbox.Text + "' " +
        "WHERE stud_id = '" + student_numtxtbox.Text + "'";

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand  = command;
            command.ExecuteNonQuery();


            sql = "select * from studenttbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            adaptersql.SelectCommand = command;  // ADD THIS LINE!

            dset = new DataSet();
            adaptersql.Fill(dset, "studenttbl");

            dataGridView1.DataSource = dset.Tables[0];

            picturebox.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\baby.png");
            student_numtxtbox.Clear();
            stud_depttxtbox.Clear();
            stud_nametxtbox.Clear();
            picturepathtxtbox.Clear();

            connection.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            picturebox.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\baby.png");
            student_numtxtbox.Clear();
            stud_depttxtbox.Clear();
            stud_nametxtbox.Clear();
            picturepathtxtbox.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            picturebox.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\baby.png");
            student_numtxtbox.Clear();
            stud_depttxtbox.Clear();
            stud_nametxtbox.Clear();
            picturepathtxtbox.Clear();
        }

        private void picturebox_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog ofd = new OpenFileDialog();

            // Set filter for image files
            ofd.Filter = "Image Files|*.gif;*.jpg;*.jpeg;*.png;*.bmp";

            // Show the dialog
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Display the selected image in the PictureBox
                picturebox.Image = Image.FromFile(ofd.FileName);

                // Save the path in a variable and textbox
                picpath = ofd.FileName;
                picturepathtxtbox.Text = picpath;
            }

        }
    }
}
