using System.IO;

namespace Assignment_3
{
    public static class FileWriter
    {
        /// <summary>
        /// Directory where all files will be created
        /// </summary>
        static string RootDirectory = @"C:\Users\Public";

        /// <summary>
        /// Creates and writes to a text file
        /// </summary>
        /// <param name="outputFile"></param>
        public static void WriteToFile(OutputFile outputFile)
        {
            var file = CreateFileInfo(outputFile.FileName);
            using (var sw = file.CreateText())
            {
                sw.WriteLine(outputFile.FileContent);
            }
        }

        /// <summary>
        /// Gets the file info for a file path
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static FileInfo CreateFileInfo(string fileName)
        {
            var file = new FileInfo(Path.Combine(RootDirectory, fileName + ".txt"));
            if (file.Exists)
                throw new FileLoadException($"Unable to create file {file.FullName} because it already exists.");
            return file;
        }
    }
}
