using Algorithm.Model;
using System;
using System.Collections.Generic;

namespace Algorithm.Structures
{
    /// <summary>
    /// Пирамидальная сортировка (сортировка двоичной кучей).
    /// </summary>
    /// <typeparam name="T"> Тип принимаемых данных. </typeparam>
    public class BinaryHeap<T> : SortBase<T>
        where T : IComparable
    {
        public BinaryHeap() { }

        public BinaryHeap(IEnumerable<T> items) : base(items)
        {
            for (int i = Items.Count - 1; i >= 0; i--)
                SortItems(i, Items.Count);
        }

        protected override void MakeSort()
        {
            for (int i = Items.Count - 1; i >= 0; i--)
            {
                Swap(indexA: 0, indexB: i);
                SortItems(0, i);
            }
        }

        private void SortItems(int currentIndex, int maxLength)
        {
            int maxIndex = currentIndex;
            int leftIndex, rightIndex;          

            while (currentIndex < maxLength)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (leftIndex < maxLength && Compare(Items[leftIndex], Items[maxIndex]) > 0)
                    maxIndex = leftIndex;

                if (rightIndex < maxLength && Compare(Items[rightIndex], Items[maxIndex]) > 0)
                    maxIndex = rightIndex;

                if (maxIndex == currentIndex) break;

                Swap(currentIndex, maxIndex);
                currentIndex = maxIndex;
            }
        }      

        public override string ToString()
        {
            return "Пирамидальная сортировка";
        }
    }
}