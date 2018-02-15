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
        public Form1()
        {
            InitializeComponent();
        }

        private void submitCountsBtn_Click(object sender, EventArgs e)
        {
            var studentCount = studentCountTB.Text;
            var assignmentCount = assignmentCountTB.Text;

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
                countErrorLabel.Text += "Number of students must be a number between 1 & 10.\n";
            if (!int.TryParse(assignmentCountString, out assignmentCount) || assignmentCount < 1 || assignmentCount > 99)
                countErrorLabel.Text += "Number of assignments must be a number between 1 & 99.";
            return countErrorLabel.Text == "";
        }
    }
}
