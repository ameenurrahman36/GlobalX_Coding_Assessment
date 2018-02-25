using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using GlobalX_Coding_Assessment.Interface;
using utility = GlobalX_Coding_Assessment.Utility.Utility;

namespace GlobalX_Coding_Assessment.Implementation
{
    public class FileOperation : IFileOperation
    {
        private string FilePath { get; set; }

        public bool Success { get; set; }

        public FileOperation(string path)
        {
            FilePath = path;
            Success = false;
        }

        public void CheckPath()
        {
            if (File.Exists(Path.GetFullPath(FilePath)))
            {
                Console.WriteLine(Path.GetFullPath(FilePath));
                Success = true;
            }
            else
            {
                utility.ConsoleWriteLine("Invalid File Path.");
            }
        }

        public string[] ReadFile()
        {
            CheckPath();

            if (Success)
            {
                return File.ReadAllLines(FilePath);
            }
            else
            {
                return new string[0];
            }
        }

        public void WriteFile(string[] names)
        {
            File.WriteAllLines(Path.Combine(Environment.CurrentDirectory, "sorted-names-list.txt"), names);
        }
    }
}
