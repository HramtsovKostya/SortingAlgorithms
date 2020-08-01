using Algorithm.Model;
using Algorithm.Sorts;
using Algorithm.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        private readonly Random rnd = new Random();
        private readonly List<int> items = new List<int>();
        private readonly List<int> sorted = new List<int>();

        [TestInitialize]
        public void Initialize()
        {
            items.Clear();
            for (int i = 0; i < 1000; i++)
                items.Add(rnd.Next(0, 100));

            sorted.Clear();
            sorted.AddRange(items.OrderBy(x => x));
        }

        private void BasicSortTest(SortBase<int> algorithm)
        {
            algorithm.Sort();

            for (int i = 0; i < items.Count; i++)
                Assert.AreEqual(sorted[i], algorithm.Items[i]);
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            var bubble = new BubbleSort<int>(items);
            BasicSortTest(bubble);
        }

        [TestMethod()]
        public void CocktailSortTest()
        {
            var cocktail = new CocktailSort<int>(items);
            BasicSortTest(cocktail);
        }

        [TestMethod()]
        public void GnomeSortTest()
        {
            var gnome = new GnomeSort<int>(items);
            BasicSortTest(gnome);
        }

        [TestMethod()]
        public void InsertSortTest()
        {
            var insert = new InsertSort<int>(items);
            BasicSortTest(insert);
        }

        [TestMethod()]
        public void SelectSortTest()
        {
            var select = new SelectSort<int>(items);
            BasicSortTest(select);
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            var shell = new ShellSort<int>(items);
            BasicSortTest(shell);
        }  

        [TestMethod()]
        public void HeapSortTest()
        {
            var heap = new BinaryHeap<int>(items);
            BasicSortTest(heap);
        }

        [TestMethod()]
        public void TreeSortTest()
        {
            var tree = new BinaryTree<int>(items);
            BasicSortTest(tree);
        }

        [TestMethod()]
        public void LsdRadixSortTest()
        {
            var lsdRadix = new LsdRadixSort<int>(items);
            BasicSortTest(lsdRadix);
        }

        [TestMethod()]
        public void MsdRadixSortTest()
        {
            var msdRadix = new MsdRadixSort<int>(items);
            BasicSortTest(msdRadix);
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            var merge = new MergeSort<int>(items);
            BasicSortTest(merge);
        }

        [TestMethod()]
        public void QuickSortTest()
        {
            var quick = new MergeSort<int>(items);
            BasicSortTest(quick);
        }
    }
}