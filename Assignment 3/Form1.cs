using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public int StudentCount { get; set; }
        public int AssignmentCount { get; set; }
        public ScoreTracker Tracker { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void submitCountsBtn_Click(object sender, EventArgs e)
        {
            var studentCount = studentCountTB.Text;
            var assignmentCount = assignmentCountTB.Text;
            if(CountsAreValid(studentCount,assignmentCount))
            {
                Tracker = new ScoreTracker(StudentCount, AssignmentCount);
                InitializeForm();
            }
        }

        /// <summary>
        /// Checks whether count inputs are valid numbers
        /// </summary>
        /// <param name="studentCountString">student count</param>
        /// <param name="assignmentCountString">assignment count</param>
        /// <returns>Whether the two inputs are valid numbers</returns>
        private bool CountsAreValid(string studentCountString, string assignmentCountString)
        {
            countErrorLabel.Text = "";
            int studentCount, assignmentCount;
            if (!int.TryParse(studentCountString, out studentCount) || studentCount < 1 || studentCount > 10)
                countErrorLabel.Text += "Number of students must be a number between 1 and 10.\n";
            else
                StudentCount = studentCount;
            if (!int.TryParse(assignmentCountString, out assignmentCount) || assignmentCount < 1 || assignmentCount > 99)
                countErrorLabel.Text += "Number of assignments must be a number between 1 and 99.";
            else
                AssignmentCount = assignmentCount;
            return countErrorLabel.Text == "";
        }

        private void InitializeForm()
        {
            assignmentNumLabel.Text += $" (1-{AssignmentCount})";
            SetTableHeader();
        }

        private void SetTableHeader()
        {
            var sb = new StringBuilder();
            sb.Append("Student\t\t");
            for(var i = 1; i <= AssignmentCount; i++)
            {
                sb.Append($"#{i}\t");
            }
            sb.Append("AVG\tGRADE\n");
            resultsTextBox.AppendText(sb.ToString());
        }

        private void ResetScores()
        {
            studentCountTB.Text = "";
            assignmentCountTB.Text = "";
            assignmentNumLabel.Text = "Enter Assignment Number";
            studentLabel.Text = "Student #1";
            resultsTextBox.Text = "";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetScores();
        }

        private void firstStudentBtn_Click(object sender, EventArgs e)
        {
            Tracker.CurrentStudent = 0;
        }

        private void ChangeStudent()
        {
            studentInfoGb.Text += $"Current Student is "
        }
    }
}
