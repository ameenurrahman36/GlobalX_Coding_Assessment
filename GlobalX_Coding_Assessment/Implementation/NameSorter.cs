using GlobalX_Coding_Assessment.Abstract;
using GlobalX_Coding_Assessment.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalX_Coding_Assessment.Implementation
{
    public class NameSorter : Sorter
    {
        public NameSorter(IFileOperation fo)
        {
            FullNames = new Dictionary<string, List<GivenName>>();
            Success = true;
            FileOperation = fo;
            Names = fo.ReadFile();
        }

        public override void SortFullNames()
        {
            ReadNames();
            SortNames();
        }

        public override void ReadNames()
        {
            if (!FileOperation.Success)
            {
                return;
            }

            base.CheckLength();

            if (!Success)
            {
                return;
            }

            foreach (var name in Names)
            {
                string[] split = name.Split(' ');
                int length = split.Length;

                base.CheckAtleastOneGivenName(length);

                if (!Success)
                {
                    break;
                }

                string givenName = string.Empty;
                string lastName = string.Empty;

                //split the last name and give name and store it in a dictionary
                for (int i = 0; i < length; i++)
                {
                    if (i == length - 1)
                    {
                        lastName = split[i];
                    }
                    else
                    {
                        givenName += split[i] + " ";
                    }
                }

                if (FullNames.ContainsKey(lastName))
                {
                    //there cannot be more than three given names for the same last name
                    base.CheckMoreThanThreeGivenName(FullNames[lastName].Count);

                    if (!Success)
                    {
                        break;
                    }
                    FullNames[lastName].Add(new GivenName() { Name = givenName });
                }
                else
                {
                    FullNames.Add(lastName, new List<GivenName> { new GivenName() { Name = givenName } });
                }
            }
        }

        public override void SortNames()
        {
            if (!Success)
            {
                return;
            }

            List<string> lastNames = new List<string>();
            List<string> sortedFullNames = new List<string>();

            foreach (var item in FullNames.Keys)
            {
                lastNames.Add(item);
            }
            
            //sort the lastname and then the given names for that last name
            lastNames.Sort();

            foreach (var item in lastNames)
            {
                List<GivenName> givenNames = FullNames[item];

                givenNames.Sort();

                foreach (var name in givenNames)
                {
                    string fullName = name.Name + item;
                    sortedFullNames.Add(fullName);
                    Console.WriteLine(fullName);
                }
            }

            //write the sorted names to a file
            FileOperation.WriteFile(sortedFullNames.ToArray());
        }
    }
}
