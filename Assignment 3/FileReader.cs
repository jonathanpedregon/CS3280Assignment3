using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public static class FileReader
    {
        /// <summary>
        /// Gets file content from a path
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string[] GetFileContent(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }
}
