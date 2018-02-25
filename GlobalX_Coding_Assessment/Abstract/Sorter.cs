using GlobalX_Coding_Assessment.Implementation;
using GlobalX_Coding_Assessment.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalX_Coding_Assessment.Abstract
{
    public abstract class Sorter
    {
        public IFileOperation FileOperation;

        public Dictionary<string, List<GivenName>> FullNames { get; set; }

        public bool Success { get; set; }

        public string[] Names { get; set; }

        public abstract void SortFullNames();

        public abstract void ReadNames();

        public abstract void SortNames();

        public void CheckLength()
        {
            if (Names.Length == 0)
            {
                Success = false;
                Console.WriteLine("No names in file.");
            }
        }

        public void CheckAtleastOneGivenName(int length)
        {
            if (length == 1)
            {
                Console.WriteLine("A name must have at least 1 given name");
                Success = false;
            }
        }

        public void CheckMoreThanThreeGivenName(int length)
        {
            if (length == 3)
            {
                Console.WriteLine("Cannot have more than 3 given names");
                Success = false;
            }
        }
    }
}
