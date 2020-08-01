using Algorithm.Model;
using System;
using System.Collections.Generic;

namespace Algorithm.Sorts
{
    /// <summary>
    /// Сортировка выбором.
    /// </summary>
    /// <typeparam name="T"> Тип принимаемых данных. </typeparam>
    public class SelectSort<T> : SortBase<T>
        where T : IComparable
    {
        public SelectSort() { }

        public SelectSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            for (int i = 0; i < Items.Count - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < Items.Count; j++)
                {
                    if (Compare(Items[j], Items[minIndex]) == -1)
                        minIndex = j;
                }

                if (i != minIndex)
                    Swap(indexA: i, indexB: minIndex);
            }
        }

        public override string ToString()
        {
            return "Сортировка выбором";
        }
    }
}