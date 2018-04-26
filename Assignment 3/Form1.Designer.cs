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
            this.saveNameBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.studentNameTb = new System.Windows.Forms.TextBox();
            this.studentLabel = new System.Windows.Forms.Label();
            this.studentInfoGb = new System.Windows.Forms.GroupBox();
            this.assignmentErrorLabel = new System.Windows.Forms.Label();
            this.saveScoreBtn = new System.Windows.Forms.Button();
            this.assignmentScoreTb = new System.Windows.Forms.TextBox();
            this.assignmentNumTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.assignmentNumLabel = new System.Windows.Forms.Label();
            this.dispScoresBtn = new System.Windows.Forms.Button();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileNameTb = new System.Windows.Forms.TextBox();
            this.writeToFileBtn = new System.Windows.Forms.Button();
            this.fileMessageLabel = new System.Windows.Forms.Label();
            this.uploadFileBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.studentInfoGb.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(34, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counts";
            // 
            // countErrorLabel
            // 
            this.countErrorLabel.AutoSize = true;
            this.countErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.countErrorLabel.Location = new System.Drawing.Point(25, 97);
            this.countErrorLabel.Name = "countErrorLabel";
            this.countErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.countErrorLabel.TabIndex = 5;
            // 
            // submitCountsBtn
            // 
            this.submitCountsBtn.Location = new System.Drawing.Point(313, 54);
            this.submitCountsBtn.Name = "submitCountsBtn";
            this.submitCountsBtn.Size = new System.Drawing.Size(111, 23);
            this.submitCountsBtn.TabIndex = 4;
            this.submitCountsBtn.Text = "Submit Counts";
            this.submitCountsBtn.UseVisualStyleBackColor = true;
            this.submitCountsBtn.Click += new System.EventHandler(this.submitCountsBtn_Click);
            // 
            // assignmentCountTB
            // 
            this.assignmentCountTB.Location = new System.Drawing.Point(192, 68);
            this.assignmentCountTB.Name = "assignmentCountTB";
            this.assignmentCountTB.Size = new System.Drawing.Size(100, 22);
            this.assignmentCountTB.TabIndex = 3;
            // 
            // studentCountTB
            // 
            this.studentCountTB.Location = new System.Drawing.Point(193, 37);
            this.studentCountTB.Name = "studentCountTB";
            this.studentCountTB.Size = new System.Drawing.Size(100, 22);
            this.studentCountTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of assignments:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of students:";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(561, 75);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 50);
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
            this.groupBox2.Location = new System.Drawing.Point(34, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 139);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navigate";
            // 
            // lastStudentBtn
            // 
            this.lastStudentBtn.Enabled = false;
            this.lastStudentBtn.Location = new System.Drawing.Point(454, 67);
            this.lastStudentBtn.Name = "lastStudentBtn";
            this.lastStudentBtn.Size = new System.Drawing.Size(125, 23);
            this.lastStudentBtn.TabIndex = 3;
            this.lastStudentBtn.Text = ">>Last Student";
            this.lastStudentBtn.UseVisualStyleBackColor = true;
            this.lastStudentBtn.Click += new System.EventHandler(this.lastStudentBtn_Click);
            // 
            // nextStudentBtn
            // 
            this.nextStudentBtn.Enabled = false;
            this.nextStudentBtn.Location = new System.Drawing.Point(313, 67);
            this.nextStudentBtn.Name = "nextStudentBtn";
            this.nextStudentBtn.Size = new System.Drawing.Size(125, 23);
            this.nextStudentBtn.TabIndex = 2;
            this.nextStudentBtn.Text = ">Next Student";
            this.nextStudentBtn.UseVisualStyleBackColor = true;
            this.nextStudentBtn.Click += new System.EventHandler(this.nextStudentBtn_Click);
            // 
            // prevStudentBtn
            // 
            this.prevStudentBtn.Enabled = false;
            this.prevStudentBtn.Location = new System.Drawing.Point(168, 67);
            this.prevStudentBtn.Name = "prevStudentBtn";
            this.prevStudentBtn.Size = new System.Drawing.Size(125, 23);
            this.prevStudentBtn.TabIndex = 1;
            this.prevStudentBtn.Text = "<Prev Student";
            this.prevStudentBtn.UseVisualStyleBackColor = true;
            this.prevStudentBtn.Click += new System.EventHandler(this.prevStudentBtn_Click);
            // 
            // firstStudentBtn
            // 
            this.firstStudentBtn.Enabled = false;
            this.firstStudentBtn.Location = new System.Drawing.Point(28, 67);
            this.firstStudentBtn.Name = "firstStudentBtn";
            this.firstStudentBtn.Size = new System.Drawing.Size(125, 23);
            this.firstStudentBtn.TabIndex = 0;
            this.firstStudentBtn.Text = "<<First Student";
            this.firstStudentBtn.UseVisualStyleBackColor = true;
            this.firstStudentBtn.Click += new System.EventHandler(this.firstStudentBtn_Click);
            // 
            // saveNameBtn
            // 
            this.saveNameBtn.Enabled = false;
            this.saveNameBtn.Location = new System.Drawing.Point(454, 35);
            this.saveNameBtn.Name = "saveNameBtn";
            this.saveNameBtn.Size = new System.Drawing.Size(125, 23);
            this.saveNameBtn.TabIndex = 4;
            this.saveNameBtn.Text = "Save Name";
            this.saveNameBtn.UseVisualStyleBackColor = true;
            this.saveNameBtn.Click += new System.EventHandler(this.saveNameBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.studentNameTb);
            this.groupBox3.Controls.Add(this.saveNameBtn);
            this.groupBox3.Controls.Add(this.studentLabel);
            this.groupBox3.Location = new System.Drawing.Point(34, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 82);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Info";
            // 
            // studentNameTb
            // 
            this.studentNameTb.Location = new System.Drawing.Point(104, 35);
            this.studentNameTb.Name = "studentNameTb";
            this.studentNameTb.ReadOnly = true;
            this.studentNameTb.Size = new System.Drawing.Size(296, 22);
            this.studentNameTb.TabIndex = 1;
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(6, 35);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(77, 17);
            this.studentLabel.TabIndex = 0;
            this.studentLabel.Text = "Student #1";
            // 
            // studentInfoGb
            // 
            this.studentInfoGb.Controls.Add(this.assignmentErrorLabel);
            this.studentInfoGb.Controls.Add(this.saveScoreBtn);
            this.studentInfoGb.Controls.Add(this.assignmentScoreTb);
            this.studentInfoGb.Controls.Add(this.assignmentNumTb);
            this.studentInfoGb.Controls.Add(this.label5);
            this.studentInfoGb.Controls.Add(this.assignmentNumLabel);
            this.studentInfoGb.Location = new System.Drawing.Point(34, 416);
            this.studentInfoGb.Name = "studentInfoGb";
            this.studentInfoGb.Size = new System.Drawing.Size(602, 156);
            this.studentInfoGb.TabIndex = 6;
            this.studentInfoGb.TabStop = false;
            this.studentInfoGb.Text = "Student Info";
            // 
            // assignmentErrorLabel
            // 
            this.assignmentErrorLabel.AutoSize = true;
            this.assignmentErrorLabel.Location = new System.Drawing.Point(28, 107);
            this.assignmentErrorLabel.Name = "assignmentErrorLabel";
            this.assignmentErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.assignmentErrorLabel.TabIndex = 6;
            // 
            // saveScoreBtn
            // 
            this.saveScoreBtn.Enabled = false;
            this.saveScoreBtn.Location = new System.Drawing.Point(351, 50);
            this.saveScoreBtn.Name = "saveScoreBtn";
            this.saveScoreBtn.Size = new System.Drawing.Size(125, 23);
            this.saveScoreBtn.TabIndex = 5;
            this.saveScoreBtn.Text = "Save Score";
            this.saveScoreBtn.UseVisualStyleBackColor = true;
            this.saveScoreBtn.Click += new System.EventHandler(this.saveScoreBtn_Click);
            // 
            // assignmentScoreTb
            // 
            this.assignmentScoreTb.Location = new System.Drawing.Point(226, 70);
            this.assignmentScoreTb.Name = "assignmentScoreTb";
            this.assignmentScoreTb.ReadOnly = true;
            this.assignmentScoreTb.Size = new System.Drawing.Size(100, 22);
            this.assignmentScoreTb.TabIndex = 3;
            // 
            // assignmentNumTb
            // 
            this.assignmentNumTb.Location = new System.Drawing.Point(226, 32);
            this.assignmentNumTb.Name = "assignmentNumTb";
            this.assignmentNumTb.ReadOnly = true;
            this.assignmentNumTb.Size = new System.Drawing.Size(100, 22);
            this.assignmentNumTb.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Assignment Score";
            // 
            // assignmentNumLabel
            // 
            this.assignmentNumLabel.AutoSize = true;
            this.assignmentNumLabel.Location = new System.Drawing.Point(9, 32);
            this.assignmentNumLabel.Name = "assignmentNumLabel";
            this.assignmentNumLabel.Size = new System.Drawing.Size(173, 17);
            this.assignmentNumLabel.TabIndex = 0;
            this.assignmentNumLabel.Text = "Enter Assignment Number";
            // 
            // dispScoresBtn
            // 
            this.dispScoresBtn.Enabled = false;
            this.dispScoresBtn.Location = new System.Drawing.Point(275, 707);
            this.dispScoresBtn.Name = "dispScoresBtn";
            this.dispScoresBtn.Size = new System.Drawing.Size(125, 27);
            this.dispScoresBtn.TabIndex = 7;
            this.dispScoresBtn.Text = "Display Scores";
            this.dispScoresBtn.UseVisualStyleBackColor = true;
            this.dispScoresBtn.Click += new System.EventHandler(this.dispScoresBtn_Click);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(34, 740);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.Size = new System.Drawing.Size(602, 148);
            this.resultsTextBox.TabIndex = 8;
            this.resultsTextBox.WordWrap = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uploadFileBtn);
            this.groupBox4.Controls.Add(this.fileMessageLabel);
            this.groupBox4.Controls.Add(this.writeToFileBtn);
            this.groupBox4.Controls.Add(this.fileNameTb);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(34, 579);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(602, 122);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter a File Name";
            // 
            // fileNameTb
            // 
            this.fileNameTb.Location = new System.Drawing.Point(152, 23);
            this.fileNameTb.Name = "fileNameTb";
            this.fileNameTb.ReadOnly = true;
            this.fileNameTb.Size = new System.Drawing.Size(287, 22);
            this.fileNameTb.TabIndex = 1;
            // 
            // writeToFileBtn
            // 
            this.writeToFileBtn.Enabled = false;
            this.writeToFileBtn.Location = new System.Drawing.Point(454, 22);
            this.writeToFileBtn.Name = "writeToFileBtn";
            this.writeToFileBtn.Size = new System.Drawing.Size(115, 23);
            this.writeToFileBtn.TabIndex = 2;
            this.writeToFileBtn.Text = "Write To File";
            this.writeToFileBtn.UseVisualStyleBackColor = true;
            this.writeToFileBtn.Click += new System.EventHandler(this.writeToFileBtn_Click);
            // 
            // fileMessageLabel
            // 
            this.fileMessageLabel.AutoSize = true;
            this.fileMessageLabel.Location = new System.Drawing.Point(12, 99);
            this.fileMessageLabel.Name = "fileMessageLabel";
            this.fileMessageLabel.Size = new System.Drawing.Size(0, 17);
            this.fileMessageLabel.TabIndex = 3;
            // 
            // uploadFileBtn
            // 
            this.uploadFileBtn.Location = new System.Drawing.Point(251, 51);
            this.uploadFileBtn.Name = "uploadFileBtn";
            this.uploadFileBtn.Size = new System.Drawing.Size(115, 29);
            this.uploadFileBtn.TabIndex = 4;
            this.uploadFileBtn.Text = "Upload File";
            this.uploadFileBtn.UseVisualStyleBackColor = true;
            this.uploadFileBtn.Click += new System.EventHandler(this.uploadFileBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 900);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.dispScoresBtn);
            this.Controls.Add(this.studentInfoGb);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.studentInfoGb.ResumeLayout(false);
            this.studentInfoGb.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Button saveNameBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox studentNameTb;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.GroupBox studentInfoGb;
        private System.Windows.Forms.Button saveScoreBtn;
        private System.Windows.Forms.TextBox assignmentScoreTb;
        private System.Windows.Forms.TextBox assignmentNumTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label assignmentNumLabel;
        private System.Windows.Forms.Button dispScoresBtn;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Label countErrorLabel;
        private System.Windows.Forms.Label assignmentErrorLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button writeToFileBtn;
        private System.Windows.Forms.TextBox fileNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileMessageLabel;
        private System.Windows.Forms.Button uploadFileBtn;
    }
}

