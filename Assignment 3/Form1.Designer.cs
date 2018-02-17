namespace Assignment_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countErrorLabel = new System.Windows.Forms.Label();
            this.submitCountsBtn = new System.Windows.Forms.Button();
            this.assignmentCountTB = new System.Windows.Forms.TextBox();
            this.studentCountTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lastStudentBtn = new System.Windows.Forms.Button();
            this.nextStudentBtn = new System.Windows.Forms.Button();
            this.prevStudentBtn = new System.Windows.Forms.Button();
            this.firstStudentBtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.studentLabel = new System.Windows.Forms.Label();
            this.studentInfoGb = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.assignmentNumLabel = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.studentInfoGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countErrorLabel);
            this.groupBox1.Controls.Add(this.submitCountsBtn);
            this.groupBox1.Controls.Add(this.assignmentCountTB);
            this.groupBox1.Controls.Add(this.studentCountTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(494, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counts";
            // 
            // countErrorLabel
            // 
            this.countErrorLabel.AutoSize = true;
            this.countErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.countErrorLabel.Location = new System.Drawing.Point(28, 121);
            this.countErrorLabel.Name = "countErrorLabel";
            this.countErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.countErrorLabel.TabIndex = 5;
            // 
            // submitCountsBtn
            // 
            this.submitCountsBtn.Location = new System.Drawing.Point(352, 68);
            this.submitCountsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submitCountsBtn.Name = "submitCountsBtn";
            this.submitCountsBtn.Size = new System.Drawing.Size(125, 29);
            this.submitCountsBtn.TabIndex = 4;
            this.submitCountsBtn.Text = "Submit Counts";
            this.submitCountsBtn.UseVisualStyleBackColor = true;
            this.submitCountsBtn.Click += new System.EventHandler(this.submitCountsBtn_Click);
            // 
            // assignmentCountTB
            // 
            this.assignmentCountTB.Location = new System.Drawing.Point(216, 85);
            this.assignmentCountTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.assignmentCountTB.Name = "assignmentCountTB";
            this.assignmentCountTB.Size = new System.Drawing.Size(112, 26);
            this.assignmentCountTB.TabIndex = 3;
            // 
            // studentCountTB
            // 
            this.studentCountTB.Location = new System.Drawing.Point(217, 46);
            this.studentCountTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentCountTB.Name = "studentCountTB";
            this.studentCountTB.Size = new System.Drawing.Size(112, 26);
            this.studentCountTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of assignments:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of students:";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(631, 94);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(84, 62);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset Scores";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lastStudentBtn);
            this.groupBox2.Controls.Add(this.nextStudentBtn);
            this.groupBox2.Controls.Add(this.prevStudentBtn);
            this.groupBox2.Controls.Add(this.firstStudentBtn);
            this.groupBox2.Location = new System.Drawing.Point(38, 242);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(677, 174);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navigate";
            // 
            // lastStudentBtn
            // 
            this.lastStudentBtn.Location = new System.Drawing.Point(511, 84);
            this.lastStudentBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastStudentBtn.Name = "lastStudentBtn";
            this.lastStudentBtn.Size = new System.Drawing.Size(141, 29);
            this.lastStudentBtn.TabIndex = 3;
            this.lastStudentBtn.Text = ">>Last Student";
            this.lastStudentBtn.UseVisualStyleBackColor = true;
            // 
            // nextStudentBtn
            // 
            this.nextStudentBtn.Location = new System.Drawing.Point(352, 84);
            this.nextStudentBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nextStudentBtn.Name = "nextStudentBtn";
            this.nextStudentBtn.Size = new System.Drawing.Size(141, 29);
            this.nextStudentBtn.TabIndex = 2;
            this.nextStudentBtn.Text = ">Next Student";
            this.nextStudentBtn.UseVisualStyleBackColor = true;
            // 
            // prevStudentBtn
            // 
            this.prevStudentBtn.Location = new System.Drawing.Point(189, 84);
            this.prevStudentBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prevStudentBtn.Name = "prevStudentBtn";
            this.prevStudentBtn.Size = new System.Drawing.Size(141, 29);
            this.prevStudentBtn.TabIndex = 1;
            this.prevStudentBtn.Text = "<Prev Student";
            this.prevStudentBtn.UseVisualStyleBackColor = true;
            // 
            // firstStudentBtn
            // 
            this.firstStudentBtn.Location = new System.Drawing.Point(32, 84);
            this.firstStudentBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstStudentBtn.Name = "firstStudentBtn";
            this.firstStudentBtn.Size = new System.Drawing.Size(141, 29);
            this.firstStudentBtn.TabIndex = 0;
            this.firstStudentBtn.Text = "<<First Student";
            this.firstStudentBtn.UseVisualStyleBackColor = true;
            this.firstStudentBtn.Click += new System.EventHandler(this.firstStudentBtn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(511, 44);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 29);
            this.button7.TabIndex = 4;
            this.button7.Text = "Save Name";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.studentLabel);
            this.groupBox3.Location = new System.Drawing.Point(38, 456);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(677, 102);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Info";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 44);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(332, 26);
            this.textBox3.TabIndex = 1;
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(7, 44);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(88, 20);
            this.studentLabel.TabIndex = 0;
            this.studentLabel.Text = "Student #1";
            // 
            // studentInfoGb
            // 
            this.studentInfoGb.Controls.Add(this.button8);
            this.studentInfoGb.Controls.Add(this.textBox5);
            this.studentInfoGb.Controls.Add(this.textBox4);
            this.studentInfoGb.Controls.Add(this.label5);
            this.studentInfoGb.Controls.Add(this.assignmentNumLabel);
            this.studentInfoGb.Location = new System.Drawing.Point(38, 606);
            this.studentInfoGb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentInfoGb.Name = "studentInfoGb";
            this.studentInfoGb.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentInfoGb.Size = new System.Drawing.Size(677, 145);
            this.studentInfoGb.TabIndex = 6;
            this.studentInfoGb.TabStop = false;
            this.studentInfoGb.Text = "Student Info";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(395, 62);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(141, 29);
            this.button8.TabIndex = 5;
            this.button8.Text = "Save Score";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(254, 88);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 26);
            this.textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(254, 40);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 26);
            this.textBox4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Assignment Score";
            // 
            // assignmentNumLabel
            // 
            this.assignmentNumLabel.AutoSize = true;
            this.assignmentNumLabel.Location = new System.Drawing.Point(10, 40);
            this.assignmentNumLabel.Name = "assignmentNumLabel";
            this.assignmentNumLabel.Size = new System.Drawing.Size(196, 20);
            this.assignmentNumLabel.TabIndex = 0;
            this.assignmentNumLabel.Text = "Enter Assignment Number";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(321, 772);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(141, 34);
            this.button9.TabIndex = 7;
            this.button9.Text = "Display Scores";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(38, 850);
            this.resultsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(677, 26);
            this.resultsTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 1050);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.studentInfoGb);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.studentInfoGb.ResumeLayout(false);
            this.studentInfoGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button submitCountsBtn;
        private System.Windows.Forms.TextBox assignmentCountTB;
        private System.Windows.Forms.TextBox studentCountTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button lastStudentBtn;
        private System.Windows.Forms.Button nextStudentBtn;
        private System.Windows.Forms.Button prevStudentBtn;
        private System.Windows.Forms.Button firstStudentBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.GroupBox studentInfoGb;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label assignmentNumLabel;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Label countErrorLabel;
    }
}

