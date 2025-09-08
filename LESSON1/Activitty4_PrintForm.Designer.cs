namespace LESSON1
{
    partial class Activitty4_PrintForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.printlistBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(199, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "VANY Collectibles Ordering Application";
            // 
            // printlistBox1
            // 
            this.printlistBox1.FormattingEnabled = true;
            this.printlistBox1.ItemHeight = 16;
            this.printlistBox1.Location = new System.Drawing.Point(166, 103);
            this.printlistBox1.Name = "printlistBox1";
            this.printlistBox1.Size = new System.Drawing.Size(830, 596);
            this.printlistBox1.TabIndex = 2;
            // 
            // Activitty4_PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 853);
            this.Controls.Add(this.printlistBox1);
            this.Controls.Add(this.label1);
            this.Name = "Activitty4_PrintForm";
            this.Text = "Activitty4_PrintForm";
            this.Load += new System.EventHandler(this.Activitty4_PrintForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox printlistBox1;
    }
}