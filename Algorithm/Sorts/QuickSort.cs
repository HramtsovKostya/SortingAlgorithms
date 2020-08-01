using Algorithm.Model;
using System;
using System.Collections.Generic;

namespace Algorithm.Sorts
{
    /// <summary>
    /// Быстрая сортировка Хоара.
    /// </summary>
    /// <typeparam name="T"> Тип принимаемых данных. </typeparam>
    public class QuickSort<T> : SortBase<T>
        where T : IComparable
    {
        public QuickSort() { }

        public QuickSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            Sort(0, Items.Count - 1);
        }

        private void Sort(int left, int right)
        {
            if (left >= right) return;

            int pivot = Sorting(left, right);

            Sort(left, pivot - 1);
            Sort(pivot + 1, right);
        }

        private int Sorting(int left, int right)
        {
            int pointer = left;

            // Опорный элемент находится по right-индексом.
            for (int i = left; i <= right; i++)
            {
                if (Compare(Items[i], Items[right]) == -1)
                    Swap(indexA: i, indexB: pointer++);                   
            }

            Swap(indexA: pointer, indexB: right);
            return pointer;
        }
        
        public override string ToString()
        {
            return "Быстрая сортировка";
        }
    }
}