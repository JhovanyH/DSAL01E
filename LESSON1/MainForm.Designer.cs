namespace LESSON1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pOSCashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSVanyColleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSVanyOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrolReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSCashierToolStripMenuItem,
            this.pOSAdministratorToolStripMenuItem,
            this.userAccountToolStripMenuItem,
            this.payrolToolStripMenuItem,
            this.employeeInformationToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1275, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pOSCashierToolStripMenuItem
            // 
            this.pOSCashierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSVanyColleToolStripMenuItem,
            this.pOSVanyOrderToolStripMenuItem});
            this.pOSCashierToolStripMenuItem.Name = "pOSCashierToolStripMenuItem";
            this.pOSCashierToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.pOSCashierToolStripMenuItem.Text = "POS Cashier";
            // 
            // pOSAdministratorToolStripMenuItem
            // 
            this.pOSAdministratorToolStripMenuItem.Name = "pOSAdministratorToolStripMenuItem";
            this.pOSAdministratorToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.pOSAdministratorToolStripMenuItem.Text = "POS Administrator";
            // 
            // userAccountToolStripMenuItem
            // 
            this.userAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAccountPageToolStripMenuItem});
            this.userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            this.userAccountToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.userAccountToolStripMenuItem.Text = "User Account";
            // 
            // payrolToolStripMenuItem
            // 
            this.payrolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payrollApplicationToolStripMenuItem});
            this.payrolToolStripMenuItem.Name = "payrolToolStripMenuItem";
            this.payrolToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.payrolToolStripMenuItem.Text = "Payrol";
            // 
            // employeeInformationToolStripMenuItem
            // 
            this.employeeInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem});
            this.employeeInformationToolStripMenuItem.Name = "employeeInformationToolStripMenuItem";
            this.employeeInformationToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.employeeInformationToolStripMenuItem.Text = "Employee Information";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payrolReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // pOSVanyColleToolStripMenuItem
            // 
            this.pOSVanyColleToolStripMenuItem.Name = "pOSVanyColleToolStripMenuItem";
            this.pOSVanyColleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.pOSVanyColleToolStripMenuItem.Text = "POS vany collectibles";
            this.pOSVanyColleToolStripMenuItem.Click += new System.EventHandler(this.pOSVanyColleToolStripMenuItem_Click);
            // 
            // pOSVanyOrderToolStripMenuItem
            // 
            this.pOSVanyOrderToolStripMenuItem.Name = "pOSVanyOrderToolStripMenuItem";
            this.pOSVanyOrderToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.pOSVanyOrderToolStripMenuItem.Text = "POS vany order";
            this.pOSVanyOrderToolStripMenuItem.Click += new System.EventHandler(this.pOSVanyOrderToolStripMenuItem_Click);
            // 
            // userAccountPageToolStripMenuItem
            // 
            this.userAccountPageToolStripMenuItem.Name = "userAccountPageToolStripMenuItem";
            this.userAccountPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userAccountPageToolStripMenuItem.Text = "User Account Page";
            // 
            // payrollApplicationToolStripMenuItem
            // 
            this.payrollApplicationToolStripMenuItem.Name = "payrollApplicationToolStripMenuItem";
            this.payrollApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.payrollApplicationToolStripMenuItem.Text = "Payroll Application";
            this.payrollApplicationToolStripMenuItem.Click += new System.EventHandler(this.payrollApplicationToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.employeeToolStripMenuItem.Text = "Employee Registration Page";
            // 
            // payrolReportsToolStripMenuItem
            // 
            this.payrolReportsToolStripMenuItem.Name = "payrolReportsToolStripMenuItem";
            this.payrolReportsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.payrolReportsToolStripMenuItem.Text = "Payrol Reports";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 777);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pOSCashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pOSVanyColleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSVanyOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrolReportsToolStripMenuItem;
    }
}