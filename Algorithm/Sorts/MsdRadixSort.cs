using Algorithm.Model;
using System;
using System.Collections.Generic;

namespace Algorithm.Sorts
{
    /// <summary>
    /// Поразрядная сортировка по старшему разряду.
    /// </summary>
    /// <typeparam name="T"> Тип принимаемых данных. </typeparam>
    public class MsdRadixSort<T> : RadixSortBase<T>
        where T : IComparable
    {
        public MsdRadixSort() { }

        public MsdRadixSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            int length = GetMaxLength();
            var result = SortCollection(Items, length - 1);

            for (int i = 0; i < result.Count; i++)
                Set(result[i], i);
        }

        private List<T> SortCollection(List<T> items, int step)
        {
            var result = new List<T>();

            CreateNewGroups();
            AddToGroups(items, step);

            foreach (var group in groups)
            {
                if (group.Count > 1 && step > 0)
                    result.AddRange(SortCollection(group, step - 1));
                else result.AddRange(group);
            }

            return result;
        }

        public override string ToString()
        {
            return "MSD - сортировка";
        }
    }
}