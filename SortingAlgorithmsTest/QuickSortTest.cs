using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;
using System;
using System.Linq;

namespace SortingAlgorithmsTest
{
    [TestClass]
    public class QuickSortTest
    {
        private QuickSort selection = new QuickSort();
       
        [TestMethod]
        public void ShouldSortArray_ThreeElements()
        {
            //arraneg
            int[] expected = KLD.Generate(3);
            int[] toSort = KLD.ShuffleAndClone(expected); 

            //act
            int[] actual = (int[]) toSort.Clone();
            selection.Sort(actual);

            //assert
            Assert.IsTrue(KLD.AreEqualArrays(expected, actual),
                $"\nFailed to sort: {KLD.ats(toSort)}." +
                $"\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_OneElements()
        {
            int[] expected = KLD.Generate(3);
            int[] toSort = KLD.ShuffleAndClone(expected);


            int[] actual = (int[])toSort.Clone();
            selection.Sort(actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_TwoElements()
        {
            int[] toSort = { 5, 1 };
            int[] expected = { 1, 5 };


            int[] actual = (int[])toSort.Clone();
            selection.Sort(actual);


            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_TenElements()
        {
            int[] toSort = { 6, 12, 30, 5, 1, 32, 9, 100, 3, 31};
            int[] expected = {1, 3, 5, 6, 9, 12, 30, 31, 32, 100 };


            int[] actual = (int[])toSort.Clone();
            selection.Sort(actual);


            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_NegativeOneElements()
        {
            int[] toSort = { -1 };
            int[] expected = { -1 };


            int[] actual = (int[])toSort.Clone();
            selection.Sort(actual);


            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_NegativeTwoElements()
        {
            int[] toSort = { -1, -2 };
            int[] expected = { -2, -1,  };


            int[] actual = (int[])toSort.Clone();
            selection.Sort(actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

        [TestMethod]
        public void ShouldSortArray_NegativeThreeElements()
        {
            int[] toSort = { -2, -1, -3 };
            int[] expected = { -3,-2, -1 };

            int[] actual = (int[])toSort.Clone();
            selection.Sort(actual);

            Assert.IsTrue(KLD.AreEqualArrays(expected, actual), $"\nFailed to sort: {KLD.ats(toSort)}.\nExpected: {KLD.ats(expected)} got: {KLD.ats(actual)}");
        }

    }
}
