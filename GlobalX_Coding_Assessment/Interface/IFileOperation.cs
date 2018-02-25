using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalX_Coding_Assessment.Interface
{
    public interface IFileOperation
    {
        bool Success { get; set; }

        void CheckPath();

        string[] ReadFile();

        void WriteFile(string[] names);
    }
}
