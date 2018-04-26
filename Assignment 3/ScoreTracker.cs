using System;
using System.Text;

namespace Assignment_3
{
    public class ScoreTracker
    {
        /// <summary>
        /// Count of students
        /// </summary>
        public int StudentCount { get; set; }
        /// <summary>
        /// Count of Assignment
        /// </summary>
        public int AssignmentCount { get; set; }
        /// <summary>
        /// Array that holds student names
        /// </summary>
        public string[] StudentNames { get; set; }
        /// <summary>
        /// 2D array that holds student scores
        /// </summary>
        public int[,] StudentScores { get; set; }
        /// <summary>
        /// An int to track the selected stuedent
        /// </summary>
        public int CurrentStudentIndex { get; set; }

        /// <summary>
        /// The students average scores
        /// </summary>
        public int[] Averages { get; set; }

        /// <summary>
        /// The student's letter grades
        /// </summary>
        public string[] Grades { get; set; }

        /// <summary>
        /// Name of the current student
        /// </summary>
        public string CurrentStudentName => StudentNames[CurrentStudentIndex];

        public ScoreTracker(int studentCount, int assignmentCount)
        {
            StudentCount = studentCount;
            AssignmentCount = assignmentCount;
            StudentNames = new string[StudentCount];
            SetDefaultStudents();
            StudentScores = new int[StudentCount, AssignmentCount];
            Averages = new int[StudentCount];
            Grades = new string[StudentCount];
        }

        public ScoreTracker()
        {

        }
        /// <summary>
        /// Sets StudentNames to Student #1, #2, etc. This is the specified default value
        /// </summary>
        public void SetDefaultStudents()
        {
            for (var i = 0; i < StudentCount; i++)
            {
                StudentNames[i] = $"Student #{i + 1}";
            }
        }

        /// <summary>
        /// Sets the CurrentStudentIndex to the first student
        /// </summary>
        public void GoToFirstStudent()
        {
            CurrentStudentIndex = 0;
        }

        /// <summary>
        /// Sets the CurrentStudentIndex to the previous student
        /// </summary>
        public void GoToPreviousStudent()
        {
            if (CurrentStudentIndex >= 1)
                CurrentStudentIndex--;
        }

        /// <summary>
        /// Sets the CurrentStudentIndex to the next student
        /// </summary>
        public void GoToNextStudent()
        {
            if (CurrentStudentIndex < StudentCount - 1)
                CurrentStudentIndex++;
        }

        /// <summary>
        /// Sets the CurrentStudentIndex to the last student
        /// </summary>
        public void GoToLastStudent()
        {
            CurrentStudentIndex = StudentCount - 1;
        }

        /// <summary>
        /// Saves a student name based on the value received
        /// </summary>
        /// <param name="name"></param>
        public void SaveStudentName(string name)
        {
            StudentNames[CurrentStudentIndex] = name;
        }

        /// <summary>
        /// Sets the score for a given assignment
        /// </summary>
        /// <param name="assignmentNumber">Assignment number</param>
        /// <param name="assignmentScore">Assignment score</param>
        public void SetScore(int assignmentNumber, int assignmentScore)
        {
            StudentScores[CurrentStudentIndex, assignmentNumber - 1] = assignmentScore;
        }

        /// <summary>
        /// Calculates the student's average grades
        /// </summary>
        private void CalculateAverages()
        {

            for (var i = 0; i < StudentCount; i++)
            {
                var sum = 0;
                for (var j = 0; j < AssignmentCount; j++)
                {
                    sum += StudentScores[i, j];
                }
                Averages[i] = sum / AssignmentCount;
            }
        }

        /// <summary>
        /// Calculate the student's letter grade
        /// </summary>
        private void CalculateGrades()
        {
            for (var i = 0; i < Averages.Length; i++)
            {
                var Grade = Averages[i];
                if (Grade >= 93)
                    Grades[i] = "A";
                else if (Grade >= 90)
                    Grades[i] = "A-";
                else if (Grade >= 87)
                    Grades[i] = "B+";
                else if (Grade >= 83)
                    Grades[i] = "B";
                else if (Grade >= 80)
                    Grades[i] = "B-";
                else if (Grade >= 77)
                    Grades[i] = "C+";
                else if (Grade >= 73)
                    Grades[i] = "C";
                else if (Grade >= 70)
                    Grades[i] = "C-";
                else if (Grade >= 67)
                    Grades[i] = "D+";
                else if (Grade >= 63)
                    Grades[i] = "D";
                else if (Grade >= 60)
                    Grades[i] = "D-";
                else
                    Grades[i] = "E";
            }
        }

        /// <summary>
        /// Ingests file from UI and populates arrays
        /// </summary>
        /// <param name="filePath"></param>
        public void IngestFileContent(string filePath)
        {
            try
            {
                var content = FileReader.GetFileContent(filePath);
                ParseContent(content);
            }
            catch(Exception ex)
            {
                throw new UnableToParseFileException($"Unable to parse file {filePath}");
            }
        }

        /// <summary>
        /// Parses content of pipe delimited text file
        /// </summary>
        /// <param name="content"></param>
        private void ParseContent(string[] content)
        {
            StudentCount = content.Length - 1;
            AssignmentCount = content[0].Split('|').Length -1 ;
            IntializeArrays();
            var rowIndex = 0;
            foreach(var row in content)
            {
                if (rowIndex > 0)
                {
                    var splitRow = row.Split('|');
                    StudentNames[rowIndex - 1] = splitRow[0];
                    for(var i = 1; i < splitRow.Length; i++)
                    {
                        StudentScores[rowIndex - 1, i - 1] = int.Parse(splitRow[i]);
                    }
                }
                rowIndex++;
            }
        }

        /// <summary>
        /// Intializes arrays so they can be used by Parse content
        /// </summary>
        private void IntializeArrays()
        {
            StudentNames = new string[StudentCount];
            StudentScores = new int[StudentCount, AssignmentCount];
            Averages = new int[StudentCount];
            Grades = new string[StudentCount];
        }

        /// <summary>
        /// Returns a string format to go in the form's results table
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            CalculateAverages();
            CalculateGrades();
            var sb = new StringBuilder();
            for (var i = 0; i < StudentCount; i++)
            {
                sb.Append($"{Environment.NewLine}{StudentNames[i]}\t\t");
                for (var j = 0; j < AssignmentCount; j++)
                {
                    sb.Append($"{StudentScores[i, j]}\t");
                }
                sb.Append($"{Averages[i]}\t{Grades[i]}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Creates a table header
        /// </summary>
        /// <returns></returns>
        public string GetTableHeader()
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
    }
}
