using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1
{
    public partial class Lesson5_SaveForm : Form
    {
        public Lesson5_SaveForm()
        {
            InitializeComponent();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Lesson5_SaveForm_Load(object sender, EventArgs e)
        {
            employee_codesave.Enabled = false;
            employee_namesave.Enabled = false;
            companytxtbox.Enabled = false;
            department_save.Enabled = false;
            cutoff_save.Enabled = false;
            payperiod_save.Enabled = false;
            dayhrs_basic.Enabled = false;
            dayhrs_over.Enabled = false;
            dayshrs_honor.Enabled = false;
            dayshrs_sub.Enabled = false;
            dayshrs_tardy.Enabled = false;
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            textBox2.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;
            deductionsSAve.Enabled = false;
            withholdingtax_txtbox.Enabled=false;
            sss_contribSave.Enabled = false;
            hdmf_contribsave.Enabled = false;
            PhilhealthSave.Enabled = false;
            sss_WIspsave.Enabled = false;

            

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
