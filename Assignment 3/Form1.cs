using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading;
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

        #region ButtonClicks

        /// <summary>
        /// Handles the submit counts button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitCountsBtn_Click(object sender, EventArgs e)
        {
            var studentCount = studentCountTB.Text;
            var assignmentCount = assignmentCountTB.Text;
            if (CountsAreValid(studentCount, assignmentCount))
            {
                Tracker = new ScoreTracker(StudentCount, AssignmentCount);
                InitializeForm();
            }
        }

        /// <summary>
        /// Resets form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
            ToggleForm();
        }

        /// <summary>
        /// Handles the first student button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstStudentBtn_Click(object sender, EventArgs e)
        {
            Tracker.GoToFirstStudent();
            ChangeStudent();
        }

        /// <summary>
        /// Handles the prev student button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prevStudentBtn_Click(object sender, EventArgs e)
        {
            Tracker.GoToPreviousStudent();
            ChangeStudent();
        }

        /// <summary>
        /// Handles the next student button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextStudentBtn_Click(object sender, EventArgs e)
        {
            Tracker.GoToNextStudent();
            ChangeStudent();
        }

        /// <summary>
        /// Handles the last student button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastStudentBtn_Click(object sender, EventArgs e)
        {
            Tracker.GoToLastStudent();
            ChangeStudent();
        }

        /// <summary>
        /// Handles the save name button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveNameBtn_Click(object sender, EventArgs e)
        {
            Tracker.SaveStudentName(studentNameTb.Text);
            ChangeStudent();
        }

        /// <summary>
        /// Handles the save score button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveScoreBtn_Click(object sender, EventArgs e)
        {
            ProcessAssignmentInputs();
        }

        /// <summary>
        /// Handles the display scores button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dispScoresBtn_Click(object sender, EventArgs e)
        {
            resultsTextBox.Text += Tracker.ToString();
        }

        /// <summary>
        /// Handles the upload file click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uploadFileBtn_Click(object sender, EventArgs e)
        {
            fileMessageLabel.Text = "";
            var filePath = GetFile();
            var backgroundWorker = GetFileReaderBackgroundWorker();
            backgroundWorker.RunWorkerAsync(filePath);
            uploadFileBtn.Enabled = false;
            uploadFileBtn.Text = "Reading File";
        }

        /// <summary>
        /// Handles Write To Button Clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void writeToFileBtn_Click(object sender, EventArgs e)
        {
            fileMessageLabel.Text = "";
            var backgroundWorker = GetFileWriterBackgroundWorker();
            var fileContent = GetTableHeader() + Tracker.ToString();
            var fileName = fileNameTb.Text;
            var fileWriterArgument = new OutputFile(fileName, fileContent);
            backgroundWorker.RunWorkerAsync(fileWriterArgument);
            writeToFileBtn.Enabled = false;
            writeToFileBtn.Text = "Writing to file";
        }

        #endregion

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

        /// <summary>
        /// Sets assignment count label and enables fields
        /// </summary>
        private void InitializeForm()
        {
            assignmentNumLabel.Text += $" (1-{AssignmentCount})";
            resultsTextBox.ScrollBars = ScrollBars.Both;
            ToggleForm();
            resultsTextBox.AppendText(GetTableHeader());
        }

        /// <summary>
        /// Creates the table of the header
        /// </summary>
        private string GetTableHeader()
        {
            var sb = new StringBuilder();
            sb.Append("Student\t\t\t");
            for (var i = 1; i <= AssignmentCount; i++)
            {
                sb.Append($"#{i}\t");
            }
            sb.Append("AVG\tGRADE\n");
            return sb.ToString();
        }

        /// <summary>
        /// Resets the form
        /// </summary>
        private void ResetForm()
        {
            assignmentNumLabel.Text = "Enter Assignment Number";
            studentLabel.Text = "Student #1";
            ClearTextBoxes();
        }

        /// <summary>
        /// Changes the student being displayed
        /// </summary>
        private void ChangeStudent()
        {
            studentInfoGb.Text = $"Student Info: Current Student is {Tracker.CurrentStudentName}";
        }

        /// <summary>
        /// Toggles the enabled/readonly state of various text boxes and buttons
        /// </summary>
        private void ToggleForm()
        {
            firstStudentBtn.Enabled = !firstStudentBtn.Enabled;
            prevStudentBtn.Enabled = !prevStudentBtn.Enabled;
            nextStudentBtn.Enabled = !nextStudentBtn.Enabled;
            lastStudentBtn.Enabled = !lastStudentBtn.Enabled;
            studentNameTb.ReadOnly = !studentNameTb.ReadOnly;
            saveNameBtn.Enabled = !saveNameBtn.Enabled;
            assignmentNumTb.ReadOnly = !assignmentNumTb.ReadOnly;
            assignmentScoreTb.ReadOnly = !assignmentScoreTb.ReadOnly;
            saveScoreBtn.Enabled = !saveScoreBtn.Enabled;
            dispScoresBtn.Enabled = !dispScoresBtn.Enabled;
            fileNameTb.ReadOnly = !fileNameTb.ReadOnly;
            writeToFileBtn.Enabled = !writeToFileBtn.Enabled;
        }

        /// <summary>
        /// Clears text boxes
        /// </summary>
        private void ClearTextBoxes()
        {
            studentCountTB.Text = "";
            assignmentCountTB.Text = "";
            studentNameTb.Text = "";
            assignmentNumTb.Text = "";
            assignmentScoreTb.Text = "";
            resultsTextBox.Text = "";
        }

        /// <summary>
        /// Processess assignment inputs
        /// </summary>
        private void ProcessAssignmentInputs()
        {
            assignmentErrorLabel.Text = "";
            var assignNumString = assignmentNumTb.Text;
            var assignScoreString = assignmentScoreTb.Text;

            int assignmentNumber, assignmentScore;
            if (!int.TryParse(assignNumString, out assignmentNumber) || assignmentNumber < 1 || assignmentNumber > Tracker.AssignmentCount)
                assignmentErrorLabel.Text += $"Assignment number must be a number between 1 and {Tracker.AssignmentCount}.\n";
            if (!int.TryParse(assignScoreString, out assignmentScore) || assignmentNumber < 1 || assignmentNumber > 100)
                assignmentErrorLabel.Text += "Assignment score must be a number between 1 and 100";
            if (assignmentErrorLabel.Text == "")
                Tracker.SetScore(assignmentNumber, assignmentScore);
        }

        /// <summary>
        /// Abstraction to initialize the backgroundworker
        /// </summary>
        /// <returns></returns>
        private BackgroundWorker GetFileWriterBackgroundWorker()
        {
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += FileWriterBackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += FileWriterBackgroundWorker_RunWorkerCompleted;
            return backgroundWorker;
        }

        /// <summary>
        /// Completed method for file writer thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileWriterBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var fileMessage = e.Error == null ? "Finshed writing to file" : e.Error.Message;
            fileMessageLabel.Text = fileMessage;
            writeToFileBtn.Enabled = true;
        }

        /// <summary>
        /// Work method for file writer thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileWriterBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var outputFile = e.Argument as OutputFile;
            Thread.Sleep(2000);
            FileWriter.WriteToFile(outputFile);
        }


        /// <summary>
        /// Initializes a file reader background worker
        /// </summary>
        /// <returns></returns>
        private BackgroundWorker GetFileReaderBackgroundWorker()
        {
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += FileReaderBackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += FileReaderBackgroundWorker_RunWorkerCompleted;
            return backgroundWorker;
        }

        /// <summary>
        /// Completed method for file reader thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileReaderBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var fileMessage = e.Error == null ? "Finshed reading from file" : e.Error.Message;
            fileMessageLabel.Text = fileMessage;
            uploadFileBtn.Enabled = true;
            resultsTextBox.Text = Tracker.GetTableHeader();
            resultsTextBox.Text += Tracker.ToString();

        }

        /// <summary>
        /// Work method for file reader thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileReaderBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(2000);
            var filePath = e.Argument as string;
            Tracker = new ScoreTracker();
            Tracker.IngestFileContent(filePath);
        }

        /// <summary>
        /// Handles the acquisition of a file for upload file
        /// </summary>
        /// <returns></returns>
        private string GetFile()
        {
            var openFileDialog1 = new OpenFileDialog();
            var dialog = openFileDialog1.ShowDialog();
            var filePath = "";
            if (dialog == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
            }
            return filePath;
        }
    }
}
