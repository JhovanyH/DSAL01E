using System;
using System.Data;
using System.Data.SqlClient; // Standard SQL library
using System.Drawing;
using System.IO; // Needed for file checks
using System.Windows.Forms;

namespace LESSON1
{
    public partial class Activity1 : Form
    {
        // 1. Keep the connection string centralized.
        // NOTE: Ideally, put this in App.config, but this works for now.
        string connectionString = "Data Source=LAPTOP-8COQ8R8Q\\SQLEXPRESS;Initial Catalog=simpledatabaseDb;Integrated Security=True";
        private Size baseSize;
        // Variable to hold the selected image path
        string globalPicPath = "";

        public Activity1()
        {
            InitializeComponent();
        }

        private void Activity1_Load_1(object sender, EventArgs e)
        {
            LoadData(); // Call a reusable method to load the grid
        }

        // --- HELPER METHOD: LOADS DATA INTO GRID ---
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM studenttbl";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        // --- HELPER METHOD: SAFELY LOADS IMAGES ---
        private void SafeLoadImage(string path)
        {
            // Clear current image first to release memory
            if (picturebox.Image != null)
            {
                picturebox.Image.Dispose();
                picturebox.Image = null;
            }

            if (File.Exists(path))
            {
                // This method prevents the file from being "locked" by the program
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    picturebox.Image = Image.FromStream(stream);
                }
            }
            else
            {
                // Load a default error image if file not found
                // Ensure this file actually exists on your machine or remove this line
                // picturebox.Image = Image.FromFile(@"C:\Path\To\Default.png"); 
                picturebox.Image = null;
            }
        }

        // --- HELPER METHOD: CLEAR INPUTS ---
        private void ClearInputs()
        {
            student_numtxtbox.Clear();
            stud_nametxtbox.Clear();
            stud_depttxtbox.Clear();
            picturepathtxtbox.Clear();
            picturebox.Image = null;
            globalPicPath = "";
        }

        // --- BUTTON 1: SAVE (INSERT) ---
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // PARAMETERIZED QUERY (Prevents SQL Injection)
                    string sql = "INSERT INTO studenttbl (stud_id, stud_name, stud_dept, picpath) VALUES (@id, @name, @dept, @pic)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Add values to parameters
                        command.Parameters.AddWithValue("@id", student_numtxtbox.Text);
                        command.Parameters.AddWithValue("@name", stud_nametxtbox.Text);
                        command.Parameters.AddWithValue("@dept", stud_depttxtbox.Text);
                        command.Parameters.AddWithValue("@pic", picturepathtxtbox.Text);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record Saved!");
                LoadData(); // Refresh Grid
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving: " + ex.Message);
            }
        }

        // --- BUTTON 2: SEARCH ---
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM studenttbl WHERE stud_id = @id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", student_numtxtbox.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                stud_nametxtbox.Text = reader["stud_name"].ToString();
                                stud_depttxtbox.Text = reader["stud_dept"].ToString();
                                picturepathtxtbox.Text = reader["picpath"].ToString();

                                SafeLoadImage(picturepathtxtbox.Text);
                            }
                            else
                            {
                                MessageBox.Show("Student not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Searching: " + ex.Message);
            }
        }

        // --- BUTTON 3: DELETE ---
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM studenttbl WHERE stud_id = @id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", student_numtxtbox.Text);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Record Deleted.");
                        else
                            MessageBox.Show("ID not found to delete.");
                    }
                }
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Deleting: " + ex.Message);
            }
        }

        // --- BUTTON 6: EDIT / UPDATE ---
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE studenttbl SET stud_name=@name, stud_dept=@dept, picpath=@pic WHERE stud_id=@id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", stud_nametxtbox.Text);
                        command.Parameters.AddWithValue("@dept", stud_depttxtbox.Text);
                        command.Parameters.AddWithValue("@pic", picturepathtxtbox.Text);
                        command.Parameters.AddWithValue("@id", student_numtxtbox.Text);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Record Updated!");
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating: " + ex.Message);
            }
        }

        // --- BUTTON 4: CANCEL / CLEAR ---
        private void button4_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // --- BUTTON 5: NEW (Same as Cancel usually) ---
        private void button5_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // --- PICTURE BOX CLICK (Upload) ---
        private void picturebox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.gif;*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Display using safe loader
                SafeLoadImage(ofd.FileName);

                // Save path to textbox
                picturepathtxtbox.Text = ofd.FileName;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: If you want clicking the grid to fill the textboxes, 
            // you can add logic here.
        }
    }
}