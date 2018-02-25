using System;
using System.IO;
using System.Collections.Generic;
using GlobalX_Coding_Assessment.Implementation;
using GlobalX_Coding_Assessment.Interface;
using GlobalX_Coding_Assessment.Abstract;

namespace GlobalX_Coding_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("Give the file path in argument. for ex. GlobalX_Coding_Assessment ./unsorted-names-list.txt");
                }
                else
                {
                    SortNames(args[0]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }

        static void SortNames(string path)
        {
            Sorter s = new NameSorter(new FileOperation(path));
            s.SortFullNames();
        }
    }
}
