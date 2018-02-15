using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int CurrentStudent { get; set; }

        public ScoreTracker(int studentCount, int assignmentCount)
        {
            StudentCount = studentCount;
            AssignmentCount = assignmentCount;
            StudentNames = new string[StudentCount];
            StudentScores = new int[AssignmentCount, StudentCount];
        }
        /// <summary>
        /// Sets StudentNames to Student #1, #2, etc. This is the specified default value
        /// </summary>
        public void SetDefaultStudents()
        {
            for(var i = 0; i < StudentCount; i++)
            {
                StudentNames[i] = $"Student #{i + 1}";
            }
        }


    }
}
