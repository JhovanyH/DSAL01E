namespace LESSON1
{
    partial class PAYROL_DATABASE_PRINTFORM

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
            this.Display_ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Display_ListBox
            // 
            this.Display_ListBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_ListBox.FormattingEnabled = true;
            this.Display_ListBox.ItemHeight = 23;
            this.Display_ListBox.Location = new System.Drawing.Point(22, 22);
            this.Display_ListBox.Name = "Display_ListBox";
            this.Display_ListBox.Size = new System.Drawing.Size(824, 763);
            this.Display_ListBox.TabIndex = 0;
            // 
            // UserAccount_PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 838);
            this.Controls.Add(this.Display_ListBox);
            this.Name = "UserAccount_PrintForm";
            this.Text = "UserAccount_PrintForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox Display_ListBox;
    }
}