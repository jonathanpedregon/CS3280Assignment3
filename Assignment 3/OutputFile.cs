using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class OutputFile
    {
        public string FileName { get; set; }
        public string FileContent { get; set; }

        public OutputFile(string fileName, string fileContent)
        {
            FileName = fileName;
            FileContent = fileContent;
        }
    }
}
