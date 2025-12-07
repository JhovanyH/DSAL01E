namespace LESSON1
{
    partial class sales_reports
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
            this.optionCombo = new System.Windows.Forms.ComboBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_button = new System.Windows.Forms.Button();
            this.optionInputTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // optionCombo
            // 
            this.optionCombo.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionCombo.FormattingEnabled = true;
            this.optionCombo.Items.AddRange(new object[] {
            "transaction_id",
            "terminal_number",
            "date and time",
            "product name",
            "employee_number"});
            this.optionCombo.Location = new System.Drawing.Point(268, 16);
            this.optionCombo.Name = "optionCombo";
            this.optionCombo.Size = new System.Drawing.Size(321, 35);
            this.optionCombo.TabIndex = 11;
            // 
            // Back_button
            // 
            this.Back_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Back_button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(1098, 13);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(144, 41);
            this.Back_button.TabIndex = 10;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1471, 772);
            this.dataGridView1.TabIndex = 9;
            // 
            // Search_button
            // 
            this.Search_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Search_button.BackColor = System.Drawing.Color.RosyBrown;
            this.Search_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search_button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(939, 13);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(144, 41);
            this.Search_button.TabIndex = 8;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // optionInputTxtbox
            // 
            this.optionInputTxtbox.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionInputTxtbox.Location = new System.Drawing.Point(605, 13);
            this.optionInputTxtbox.Multiline = true;
            this.optionInputTxtbox.Name = "optionInputTxtbox";
            this.optionInputTxtbox.Size = new System.Drawing.Size(310, 41);
            this.optionInputTxtbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select an option:";
            // 
            // sales_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 855);
            this.Controls.Add(this.optionCombo);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.optionInputTxtbox);
            this.Controls.Add(this.label1);
            this.Name = "sales_reports";
            this.Text = "sales_reports";
            this.Load += new System.EventHandler(this.sales_reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox optionCombo;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox optionInputTxtbox;
        private System.Windows.Forms.Label label1;
    }
}