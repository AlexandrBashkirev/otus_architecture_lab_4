using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using otus_architecture_lab_4;


namespace lab4Tests
{
    [TestClass]
    public class UnitTest1
    {
        List<int> data = new List<int> { 8, 3, 9, 3, 5, 1, 90 };
        List<int> result = new List<int> { 1, 3, 3, 5, 8, 9, 90 };

        [TestMethod]
        public void IsertionSortTest()
        {
            ISorter sorter = new InsertionSorter();

            sorter.Sort(data);

            for (int i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(result[i] == data[i]);
            }
        }


        [TestMethod]
        public void MergeSortTest()
        {
            ISorter sorter = new MergeSorter();

            sorter.Sort(data);

            for (int i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(result[i] == data[i]);
            }
        }


        [TestMethod]
        public void SelectionSortTest()
        {
            ISorter sorter = new SelectionSorter();

            sorter.Sort(data);

            for (int i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(result[i] == data[i]);
            }
        }
    }
}
