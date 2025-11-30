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
            course_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][40].ToString();
            YearGrad4ComboBox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][41].ToString();
            Award4_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][42].ToString();
            Others_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][43].ToString();
            position_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][44].ToString();
            Emp_Stat_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][45].ToString();
            DateHiredComboBox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][46].ToString();
            dept_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][47].ToString();
            no_Dept_Txtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][48].ToString();
            picpathTxtbox.Text = edb.employee_sql_dataset.Tables[0].Rows[0][49].ToString();
            pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);


        }

        private void Add_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
