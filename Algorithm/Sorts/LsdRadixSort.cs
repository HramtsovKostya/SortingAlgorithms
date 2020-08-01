using Algorithm.Model;
using System;
using System.Collections.Generic;

namespace Algorithm.Sorts
{
    /// <summary>
    /// Поразрядная сортировка по младшему разряду.
    /// </summary>
    /// <typeparam name="T"> Тип принимаемых данных. </typeparam>
    public class LsdRadixSort<T> : RadixSortBase<T>
        where T : IComparable
    {
        public LsdRadixSort() { }

        public LsdRadixSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            CreateNewGroups();

            for (int step = 0; step < GetMaxLength(); step++)
            {
                int counter = 0;
                AddToGroups(Items, step);                

                foreach (var group in groups)
                {
                    foreach (var item in group)
                        Set(item, counter++);

                    group.Clear();
                }
            }
        }

        public override string ToString()
        {
            return "LSD - сортировка";
        }
    }
}