using Algorithm.Model;
using System;
using System.Collections.Generic;

namespace Algorithm.Sorts
{
    /// <summary>
    /// Сортировка вставками.
    /// </summary>
    /// <typeparam name="T"> Тип принимаемых данных. </typeparam>
    public class InsertSort<T> : SortBase<T>
        where T : IComparable
    {
        public InsertSort() { }

        public InsertSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            for (int i = 1, j = 1; i < Items.Count; i++, j = i)
            {
                while (j > 0 && Compare(Items[j - 1], Items[j]) == 1)
                    Swap(indexA: j - 1, indexB: j--);
            }
        }

        public override string ToString()
        {
            return "Сортировка вставками";
        }
    }
}