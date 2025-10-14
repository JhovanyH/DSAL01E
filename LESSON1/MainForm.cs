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
            pos1function activity3 = new pos1function();
            activity3.MdiParent = this;
            activity3.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

        }

        private void pOSVanyOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos2function activity4 = new pos2function();
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
            Activity2 activity2 = new Activity2();
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
            UserAccount useracc = new UserAccount();
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
    }
}
