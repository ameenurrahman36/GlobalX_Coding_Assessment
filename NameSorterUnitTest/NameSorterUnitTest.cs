using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using GlobalX_Coding_Assessment.Implementation;
using GlobalX_Coding_Assessment.Abstract;
using GlobalX_Coding_Assessment.Interface;

namespace NameSorterUnitTest
{
    [TestClass]
    public class NameSorterUnitTest
    {
        [TestMethod]
        public void TestUnSortedPath()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "unsorted-names-list.txt");
            IFileOperation fo = new FileOperation(path);
            fo.CheckPath();
            Assert.AreEqual(true, fo.Success);
        }

        [TestMethod]
        public void TestCheckNames()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "unsorted-names-list.txt");
            Sorter s = new NameSorter(new FileOperation(path));
            s.CheckLength();
            Assert.AreEqual(true, s.Success);
        }

        [TestMethod]
        public void TestCheckAtleastOneGivenName()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "unsorted-names-list.txt");
            Sorter s = new NameSorter(new FileOperation(path));
            s.SortFullNames();
            Assert.AreEqual(true, s.Success);
        }

        [TestMethod]
        public void TestCheckMoreThanThreeGivenName()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "unsorted-names-list.txt");
            Sorter s = new NameSorter(new FileOperation(path));
            s.SortFullNames();
            Assert.AreEqual(true, s.Success);
        }

        [TestMethod]
        public void TestSortedPath()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "sorted-names-list.txt");
            IFileOperation fo = new FileOperation(path);
            fo.CheckPath();
            Assert.AreEqual(true, fo.Success);
        }
    }
}
