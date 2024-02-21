namespace Monthly_Payment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LoanAmountTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberOfYearsComboBox = new System.Windows.Forms.ComboBox();
            this.FirstInterestRateComboBox = new System.Windows.Forms.ComboBox();
            this.LastInterestRateComboBox = new System.Windows.Forms.ComboBox();
            this.InterestRateStepSizeComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Amount";
            // 
            // LoanAmountTextbox
            // 
            this.LoanAmountTextbox.Location = new System.Drawing.Point(253, 55);
            this.LoanAmountTextbox.Name = "LoanAmountTextbox";
            this.LoanAmountTextbox.Size = new System.Drawing.Size(68, 20);
            this.LoanAmountTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Years";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Interest Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Interest Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Interest Rate Step Size";
            // 
            // NumberOfYearsComboBox
            // 
            this.NumberOfYearsComboBox.FormattingEnabled = true;
            this.NumberOfYearsComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.NumberOfYearsComboBox.Location = new System.Drawing.Point(253, 93);
            this.NumberOfYearsComboBox.Name = "NumberOfYearsComboBox";
            this.NumberOfYearsComboBox.Size = new System.Drawing.Size(68, 21);
            this.NumberOfYearsComboBox.TabIndex = 6;
            // 
            // FirstInterestRateComboBox
            // 
            this.FirstInterestRateComboBox.FormattingEnabled = true;
            this.FirstInterestRateComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.FirstInterestRateComboBox.Location = new System.Drawing.Point(253, 134);
            this.FirstInterestRateComboBox.Name = "FirstInterestRateComboBox";
            this.FirstInterestRateComboBox.Size = new System.Drawing.Size(68, 21);
            this.FirstInterestRateComboBox.TabIndex = 7;
            // 
            // LastInterestRateComboBox
            // 
            this.LastInterestRateComboBox.FormattingEnabled = true;
            this.LastInterestRateComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.LastInterestRateComboBox.Location = new System.Drawing.Point(253, 167);
            this.LastInterestRateComboBox.Name = "LastInterestRateComboBox";
            this.LastInterestRateComboBox.Size = new System.Drawing.Size(68, 21);
            this.LastInterestRateComboBox.TabIndex = 8;
            // 
            // InterestRateStepSizeComboBox
            // 
            this.InterestRateStepSizeComboBox.FormattingEnabled = true;
            this.InterestRateStepSizeComboBox.Items.AddRange(new object[] {
            "0.11",
            "0.5",
            "1.0",
            "2.0"});
            this.InterestRateStepSizeComboBox.Location = new System.Drawing.Point(253, 204);
            this.InterestRateStepSizeComboBox.Name = "InterestRateStepSizeComboBox";
            this.InterestRateStepSizeComboBox.Size = new System.Drawing.Size(68, 21);
            this.InterestRateStepSizeComboBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "&Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.Location = new System.Drawing.Point(412, 58);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(214, 173);
            this.OutputListBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Interest Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Monthly Payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(765, 406);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 319);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InterestRateStepSizeComboBox);
            this.Controls.Add(this.LastInterestRateComboBox);
            this.Controls.Add(this.FirstInterestRateComboBox);
            this.Controls.Add(this.NumberOfYearsComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoanAmountTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "c";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoanAmountTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox NumberOfYearsComboBox;
        private System.Windows.Forms.ComboBox FirstInterestRateComboBox;
        private System.Windows.Forms.ComboBox LastInterestRateComboBox;
        private System.Windows.Forms.ComboBox InterestRateStepSizeComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

