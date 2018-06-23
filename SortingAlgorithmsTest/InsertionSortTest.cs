using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;
using System.Linq;

namespace SortingAlgorithmsTest
{
    [TestClass]
    public class InsertionSortTest
    {
        private InsertionSort selection = new InsertionSort();

        [TestMethod]
        public void ShouldSortArray_ThreeElements()
        {
            int[] toSort = {6, 3, 5};
            int[] expected = {3, 5, 6 };


            int[] actual = (int[]) toSort.Clone();
            selection.Sort(ref actual);


            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_One_Elements()
        {
            int[] toSort = {6};
            int[] expected = {6};

            int[] actual = (int[])toSort.Clone();
            selection.Sort(ref actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_Two_Elements()
        {
            int[] toSort = { 5, 1 };
            int[] expected = { 1, 5 };

            int[] actual = (int[])toSort.Clone();
            selection.Sort(ref actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_Ten_Elements()
        {
            int[] toSort = { 6, 12, 30, 5, 1, 32, 9, 100, 3, 31};
            int[] expected = {1, 3, 5, 6, 9, 12, 30, 31, 32, 100 };

            int[] actual = (int[])toSort.Clone();
            selection.Sort(ref actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_One_Elements_Negative()
        {
            int[] toSort = { -1 };
            int[] expected = { -1 };


            int[] actual = (int[])toSort.Clone();
            selection.Sort(ref actual);


            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_Two_Elements__Negative()
        {
            int[] toSort = { -1, -2 };
            int[] expected = { -2, -1,  };


            int[] actual = (int[])toSort.Clone();
            selection.Sort(ref actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_Three_Elements_Negative()
        {
            int[] toSort = { -2, -1, -3 };
            int[] expected = { -3,-2, -1 };

            int[] actual = (int[])toSort.Clone();
            selection.Sort(ref actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_Two_Elements_Sorted()
        {
            int[] expected = KLD.Generate(2);
            int[] toSort = expected;

            int[] actual = (int[])toSort.Clone();
            selection.Sort(ref actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_Three_Elements_Sorted()
        {
            int[] expected = KLD.Generate(3);
            int[] toSort = expected;

            int[] actual = (int[])toSort.Clone();
            selection.Sort(ref actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_Ten_Elements_Sorted()
        {
            int[] expected = KLD.Generate(10);
            int[] toSort = expected;

            int[] actual = (int[])toSort.Clone();
            selection.Sort(ref actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_Two_Elements_Sorted_Reversed()
        {
            int[] expected = KLD.Generate(2);
            int[] toSort = expected.Reverse().ToArray();

            int[] actual = (int[])toSort.Clone();
            selection.Sort(ref actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_Three_Elements_Sorted_Reversed()
        {
            int[] expected = KLD.Generate(3);
            int[] toSort = expected.Reverse().ToArray();

            int[] actual = (int[])toSort.Clone();
            selection.Sort(ref actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_Ten_Elements_Sorted_Reversed()
        {
            int[] expected = KLD.Generate(10);
            int[] toSort = expected.Reverse().ToArray();

            int[] actual = (int[])toSort.Clone();
            selection.Sort(ref actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }


    }
}
