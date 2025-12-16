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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pOSVanyColleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Allow Admin to open POS1 (Terminal 1) for testing
            POS1_DATABASE pos1Form = new POS1_DATABASE();

            // Set it as admin mode (no terminal required)
            pos1Form.SetAsAdminMode("2"); // Test Terminal 1

            pos1Form.MdiParent = this;
            pos1Form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

        }

        private void pOSVanyOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Allow Admin to open POS2 (Terminal 2) for testing
            POS2_DATABASE pos2Form = new POS2_DATABASE();

            // Set it as admin mode (no terminal required)
            pos2Form.SetAsAdminMode("1"); // Test Terminal 2

            pos2Form.MdiParent = this;
            pos2Form.Show();
        }

        private void payrollApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson5_Activity activity5 = new Lesson5_Activity();
            activity5.MdiParent = this;
            activity5.Show();
        }

        private void simplePOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS_Admin activity2 = new POS_Admin();
            activity2.MdiParent = this;
            activity2.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vanyPOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity3 activity3 = new Activity3();
            activity3.MdiParent = this;
            activity3.Show();
        }

        private void vanyPOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity4 activity4 = new Activity4();
            activity4.MdiParent = this;
            activity4.Show();
        }

        private void userAccountPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payrol useracc = new payrol();
            useracc.MdiParent = this;
            useracc.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //all child forms in vertical display
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //all child forms in horizontal display
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //all child forms in cascade display
            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void pOSAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PAYROL_DATABASE pb = new PAYROL_DATABASE();
            pb.MdiParent = this;
            pb.Show();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EMP_REGISTRATION_DATABASE er = new EMP_REGISTRATION_DATABASE();
            er.MdiParent = this;
            er.Show();
        }

        private void payrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_account ua = new user_account();
            ua.MdiParent = this;
            ua.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales_reports sr = new sales_reports();
            sr.MdiParent = this;
            sr.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Reports er = new Employee_Reports();   
            er.MdiParent = this;
            er.Show();
        }

        private void payrolReportsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            payrol_reports pr = new payrol_reports();
            pr.MdiParent = this;
            pr.Show();
        }

        private void userAccountReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            useraccount_report uar = new useraccount_report();
            uar.MdiParent = this;
            uar.Show();
        }

        private void activity1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity1 A1 = new Activity1();
            A1.MdiParent = this;
            A1.Show();
        }

        private void activity2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity2 A2 = new Activity2(); 
            A2.MdiParent = this;
            A2.Show();
        }

        private void activity3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity3 A3 = new Activity3();
            A3.MdiParent = this;
            A3.Show();
        }

        private void activity4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity4 A4 = new Activity4();
            A4.MdiParent = this;
            A4.Show();
        }

        private void activity5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson5_Activity A5 = new Lesson5_Activity();
            A5.MdiParent = this;
            A5.Show();
        }
    }
}
