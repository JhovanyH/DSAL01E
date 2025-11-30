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
    public partial class EMP_REGISTRATION_DATABASE : Form
    {
        private OpenFileDialog openFileDialog1;
        string picpath;
        employee_dbconnection edb = new employee_dbconnection();
        public EMP_REGISTRATION_DATABASE()
        {
            edb.employee_connString();
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
        }
        private void cleartextboxes()
        {
            emp_idTxtbox.Clear(); fname_Txtbox.Clear(); mname_Txtbox.Clear(); Sname_Txtbox.Clear();
            SSS_no_Txtbox.Clear(); Philhealth_Txtbox.Clear(); Pagibig_Txtbox.Clear(); TIN_no_Txtbox.Clear();
            Height_Txtbox.Clear(); Weight_Txtbox.Clear(); Years_stay_Txtbox.Clear(); House_no_Txtbox.Clear();
            subdname_Txtbox.Clear(); phone_no_Txtbox.Clear(); street_Txtbox.Clear(); brgy_Txtbox.Clear();
            municip_Txtbox.Clear(); city_Txtbox.Clear(); country_Txtbox.Clear(); state_Txtbox.Clear();
            zip_Txtbox.Clear(); ElemSchool_Txtbox.Clear(); Address1_Txtbox.Clear(); Award1_Txtbox.Clear();
            JuniorHigh_Txtbox.Clear(); Address2_Txtbox.Clear(); Award2_Txtbox.Clear(); SeniorHigh_Txtbox.Clear();
            Address3_Txtbox.Clear(); Award3_Txtbox.Clear(); Track_Txtbox.Clear(); College_Txtbox.Clear();
            Address4_Txtbox.Clear(); course_Txtbox.Clear(); Award4_Txtbox.Clear(); Others_Txtbox.Clear();
            position_Txtbox.Clear(); dept_Txtbox.Clear(); Emp_Stat_Txtbox.Clear(); no_Dept_Txtbox.Clear();
            picpathTxtbox.Clear();
            pictureBox1.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\question.png");
            emp_idTxtbox.Focus();

        }

        private void EMP_REGISTRATION_DATABASE_Load(object sender, EventArgs e)
        {
            picpathTxtbox.Hide();
            pictureBox1.Image = pictureBox1.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\question.png");
            edb.employee_sql = "SELECT * FROM pos_empRegTbl";
            edb.employee_cmd();
            edb.employee_sqladapterSelect();
            edb.employee_sqldatasetSELECT();
            dataGridView1.DataSource = edb.employee_sql_dataset.Tables[0];

            PopulateComboBoxes();
        }

        private void Browse_Button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp; *.jpeg";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpathTxtbox.Text = picpath;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            edb.employee_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtbox.Text + "'";
            edb.employee_cmd();
            edb.employee_sqladapterSelect();
            edb.employee_sqldatasetSELECT();
            dataGridView1.DataSource = edb.employee_sql_dataset.Tables[0];
            fname_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][2].ToString();
            mname_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][3].ToString();
            Sname_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][4].ToString();
            AgecomboBox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][5].ToString();
            GenderComboBox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][6].ToString();
            SSS_no_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][7].ToString();
            TIN_no_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][8].ToString();
            Philhealth_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][9].ToString();
            Pagibig_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][10].ToString();
            StatusComboBox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][11].ToString();
            Height_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][12].ToString();
            Weight_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][13].ToString();
            Years_stay_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][14].ToString();
            House_no_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][15].ToString();
            subdname_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][16].ToString();
            phone_no_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][17].ToString();
            street_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][18].ToString();
            brgy_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][19].ToString();
            municip_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][20].ToString();
            city_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][21].ToString();
            state_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][22].ToString();
            country_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][23].ToString();
            zip_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][24].ToString();
            ElemSchool_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][25].ToString();
            Address1_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][26].ToString();
            YearGraduatedComboBox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][27].ToString();
            Award1_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][28].ToString();
            JuniorHigh_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][29].ToString();
            Address2_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][30].ToString();
            YearGrad2ComboBox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][31].ToString();
            Award2_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][32].ToString();
            SeniorHigh_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][33].ToString();
            Address3_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][34].ToString();
            yearGrad3ComboBox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][35].ToString();
            Award3_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][36].ToString();
            Track_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][37].ToString();
            College_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][38].ToString();
            Address4_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][39].ToString();
            YearGrad4ComboBox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][40].ToString();
            Award4_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][41].ToString();
            course_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][42].ToString();
            Others_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][43].ToString();
            position_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][44].ToString();
            Emp_Stat_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][45].ToString();
            DateHiredComboBox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][46].ToString();
            dept_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][47].ToString();
            no_Dept_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][48].ToString();
            picpathTxtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][49].ToString();

            //modified code to let the program run whithout error if picture path is invalid
            if (!string.IsNullOrEmpty(picpathTxtbox.Text) && System.IO.File.Exists(picpathTxtbox.Text))
            {
                pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);
            }
            else
            {
                // Show default image if path is empty or file doesn't exist
                pictureBox1.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\question.png");
            }


        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            edb.employee_sql = "INSERT INTO pos_empRegTbl (emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender," +
                "emp_sss_no, emp_tin_no, emp_philhealth_no, emp_pagibig_no, emp_status, emp_height, emp_weight, add_yrs_stay," +
                "add_house_no, add_sub_name, add_phase_no, add_street, add_baranggay, add_municipality, add_city, add_state_province," +
                "add_country, add_zipcode, elem_name, elem_address, elem_yr_grad, elem_award, junior_high_name, junior_high_address, " +
                "junior_high_yr_grad, junior_high_award, senior_high_name, senior_high_address, senior_high_yr_grad, senior_high_award," +
                "track, college_school_name, college_address, college_yr_grad, college_award, college_course, others, position," +
                "emp_work_status, emp_date_hired, emp_department, emp_no_of_dependents, picpath) VALUES ('" + emp_idTxtbox.Text + "','" + fname_Txtbox.Text + "','" + mname_Txtbox.Text + "','" + Sname_Txtbox.Text +
                "','" + AgecomboBox.Text + "','" + GenderComboBox.Text + "','" + SSS_no_Txtbox.Text + "','" + TIN_no_Txtbox.Text +
                "','" + Philhealth_Txtbox.Text + "','" + Pagibig_Txtbox.Text + "','" + StatusComboBox.Text + "','" + Height_Txtbox.Text +
                "','" + Weight_Txtbox.Text + "','" + Years_stay_Txtbox.Text + "','" + House_no_Txtbox.Text + "','" + subdname_Txtbox.Text +
                "','" + phone_no_Txtbox.Text + "','" + street_Txtbox.Text + "','" + brgy_Txtbox.Text + "','" + municip_Txtbox.Text + "','" + city_Txtbox.Text +
                "','" + state_Txtbox.Text + "','" + country_Txtbox.Text + "','" + zip_Txtbox.Text + "','" + ElemSchool_Txtbox.Text +
                "','" + Address1_Txtbox.Text + "','" + YearGraduatedComboBox.Text + "','" + Award1_Txtbox.Text + "','" + JuniorHigh_Txtbox.Text +
                "','" + Address2_Txtbox.Text + "','" + YearGrad2ComboBox.Text + "','" + Award2_Txtbox.Text + "','" + SeniorHigh_Txtbox.Text +
                "','" + Address3_Txtbox.Text + "','" + yearGrad3ComboBox.Text + "','" + Award3_Txtbox.Text + "','" + Track_Txtbox.Text +
                "','" + College_Txtbox.Text + "','" + Address4_Txtbox.Text + "','" + YearGrad4ComboBox.Text + "','" + Award4_Txtbox.Text +
                "','" + course_Txtbox.Text + "','" + Others_Txtbox.Text + "','" + position_Txtbox.Text + "','" + Emp_Stat_Txtbox.Text +
                "','" + DateHiredComboBox.Text + "','" + dept_Txtbox.Text + "','" + no_Dept_Txtbox.Text + "','" + picpathTxtbox.Text + "')";
            edb.employee_cmd();
            edb.employee_sqladapterInsert();
            edb.employee_sql = "SELECT * FROM pos_empRegTbl";
            edb.employee_cmd();
            edb.employee_sqladapterSelect();
            edb.employee_sqldatasetSELECT();
            dataGridView1.DataSource = edb.employee_sql_dataset.Tables[0];
            cleartextboxes();


        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            edb.employee_sql = "UPDATE pos_empRegTbl SET emp_fname = '" + fname_Txtbox.Text + "', emp_mname = '" + mname_Txtbox.Text +
                "', emp_surname = '" + Sname_Txtbox.Text + "', emp_age = '" + AgecomboBox.Text + "'," +
                "emp_gender = '" + GenderComboBox.Text + "', emp_sss_no = '" + SSS_no_Txtbox.Text + "', emp_tin_no = '" + TIN_no_Txtbox.Text + "'," +
                "emp_philhealth_no = '" + Philhealth_Txtbox.Text + "', emp_pagibig_no = '" + Pagibig_Txtbox.Text + "', emp_status = '" + StatusComboBox.Text + "'," +
                "emp_height = '" + Height_Txtbox.Text + "', emp_weight = '" + Weight_Txtbox.Text + "', add_yrs_stay = '" + Years_stay_Txtbox.Text + "'," +
                "add_house_no = '" + House_no_Txtbox.Text + "', add_sub_name = '" + subdname_Txtbox.Text + "', add_phase_no = '" + phone_no_Txtbox.Text + "'," +
                "add_street = '" + street_Txtbox.Text + "', add_baranggay = '" + brgy_Txtbox.Text + "', add_municipality = '" + municip_Txtbox.Text + "'," +
                "add_city = '" + city_Txtbox.Text + "', add_state_province = '" + state_Txtbox.Text + "', add_country = '" + country_Txtbox.Text + "'," +
                "add_zipcode = '" + zip_Txtbox.Text + "', elem_name = '" + ElemSchool_Txtbox.Text + "', elem_address = '" + Address1_Txtbox.Text + "'," +
                "elem_yr_grad = '" + YearGraduatedComboBox.Text + "', elem_award = '" + Award1_Txtbox.Text + "', junior_high_name = '" + JuniorHigh_Txtbox.Text + "'," +
                "junior_high_address = '" + Address2_Txtbox.Text + "', junior_high_yr_grad = '" + YearGrad2ComboBox.Text + "', junior_high_award = '" + Award2_Txtbox.Text + "'," +
                "senior_high_name = '" + SeniorHigh_Txtbox.Text + "', senior_high_address = '" + Address3_Txtbox.Text + "', senior_high_yr_grad = '" + yearGrad3ComboBox.Text + "'," +
                "senior_high_award = '" + Award3_Txtbox.Text + "', track = '" + Track_Txtbox.Text + "', college_school_name = '" + College_Txtbox.Text + "'," +
                "college_address = '" + Address4_Txtbox.Text + "', college_yr_grad = '" + YearGrad4ComboBox.Text + "', college_award = '" + Award4_Txtbox.Text + "'," +
                "college_course = '" + course_Txtbox.Text + "', others = '" + Others_Txtbox.Text + "', position = '" + position_Txtbox.Text + "'," +
                "emp_work_status = '" + Emp_Stat_Txtbox.Text + "', emp_date_hired = '" + DateHiredComboBox.Text + "', emp_department = '" + dept_Txtbox.Text + "'," +
                "emp_no_of_dependents = '" + no_Dept_Txtbox.Text + "', picpath = '" + picpathTxtbox.Text + "' WHERE emp_id = '" + emp_idTxtbox.Text + "'";
            edb.employee_cmd();
            edb.employee_sqladapterInsert();
            edb.employee_sql = "SELECT * FROM pos_empRegTbl";
            edb.employee_cmd();
            edb.employee_sqladapterSelect();
            edb.employee_sqldatasetSELECT();
            dataGridView1.DataSource = edb.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            edb.employee_sql = "DELETE FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtbox.Text + "'";
            edb.employee_cmd();
            edb.employee_sqladapterDelete();
            edb.employee_sql = "SELECT * FROM pos_empRegTbl";
            edb.employee_cmd();
            edb.employee_sqladapterSelect();
            edb.employee_sqldatasetSELECT();
            dataGridView1.DataSource = edb.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateComboBoxes()
        {
            // Age ComboBox (18-70)
            AgecomboBox.Items.Clear();
            for (int i = 18; i <= 70; i++)
            {
                AgecomboBox.Items.Add(i.ToString());
            }

            // Gender ComboBox
            GenderComboBox.Items.Clear();
            GenderComboBox.Items.Add("Male");
            GenderComboBox.Items.Add("Female");

            // Status ComboBox (Civil Status)
            StatusComboBox.Items.Clear();
            StatusComboBox.Items.Add("Single");
            StatusComboBox.Items.Add("Married");
            StatusComboBox.Items.Add("Divorced");
            StatusComboBox.Items.Add("Widowed");
            StatusComboBox.Items.Add("Separated");

            // Year Graduated ComboBoxes (Elementary, Junior High, Senior High, College)
            PopulateYearComboBox(YearGraduatedComboBox);
            PopulateYearComboBox(YearGrad2ComboBox);
            PopulateYearComboBox(yearGrad3ComboBox);
            PopulateYearComboBox(YearGrad4ComboBox);

            // Date Hired ComboBox
            PopulateDateComboBox(DateHiredComboBox);
        }

        // Helper method to populate year ComboBoxes
        private void PopulateYearComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= 1950; i--)
            {
                comboBox.Items.Add(i.ToString());
            }
        }

        // Helper method to populate date ComboBoxes
        private void PopulateDateComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            for (int month = 1; month <= 12; month++)
            {
                for (int day = 1; day <= DateTime.DaysInMonth(DateTime.Now.Year, month); day++)
                {
                    string date = $"{month:00}/{day:00}/{DateTime.Now.Year}";
                    comboBox.Items.Add(date);
                }
            }
        }
    }
}
