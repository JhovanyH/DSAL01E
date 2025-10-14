namespace LESSON1
{
    partial class pos2_Class_printform
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
            this.printlistBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printlistBox1
            // 
            this.printlistBox1.FormattingEnabled = true;
            this.printlistBox1.ItemHeight = 16;
            this.printlistBox1.Location = new System.Drawing.Point(95, 113);
            this.printlistBox1.Name = "printlistBox1";
            this.printlistBox1.Size = new System.Drawing.Size(830, 596);
            this.printlistBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(128, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "VANY Collectibles Ordering Application";
            // 
            // pos2_printform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 828);
            this.Controls.Add(this.printlistBox1);
            this.Controls.Add(this.label1);
            this.Name = "pos2_printform";
            this.Text = "pos2_printform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox printlistBox1;
        private System.Windows.Forms.Label label1;
    }
}