using Algorithm.Model;
using System;
using System.Collections.Generic;

namespace Algorithm.Sorts
{
    /// <summary>
    /// Гномья сортировка.
    /// </summary>
    /// <typeparam name="T"> Тип принимаемых данных. </typeparam>
    public class GnomeSort<T> : SortBase<T>
        where T : IComparable
    {
        public GnomeSort() { }

        public GnomeSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            int i = 1;

            while (i < Items.Count)
            {
                if (i == 0 || Compare(Items[i], Items[i - 1]) != -1) i++;
                else Swap(indexA: i - 1, indexB: i--);                    
            }
        }

        public override string ToString()
        {
            return "Гномья сортировка";
        }
    }
}