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
            Activity2 activity2 = new Activity2();
            activity2.MdiParent = this;
            activity2.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

        }

        private void pOSVanyOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity4 activity4 = new Activity4();
            activity4.MdiParent = this;
            activity4.Show();
        }

        private void payrollApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson5_Activity activity5 = new Lesson5_Activity();
            activity5.MdiParent = this;
            activity5.Show();
        }

        private void simplePOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acitivity1 activity1 = new Acitivity1();
            activity1.MdiParent = this;
            activity1.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vanyPOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity2 activity2 = new Activity2();
            activity2.MdiParent = this;
            activity2.Show();
        }

        private void vanyPOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity4 activity4 = new Activity4();
            activity4.MdiParent = this;
            activity4.Show();
        }
    }
}
