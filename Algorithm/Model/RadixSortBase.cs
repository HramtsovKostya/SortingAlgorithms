using System;
using System.Collections.Generic;

namespace Algorithm.Model
{
    public abstract class RadixSortBase<T> : SortBase<T>
        where T : IComparable
    {
        protected List<List<T>> groups;

        public RadixSortBase() { }

        public RadixSortBase(IEnumerable<T> items) : base(items) { }

        protected void CreateNewGroups()
        {
            groups = new List<List<T>>();

            for (int i = 0; i < 10; i++)
                groups.Add(new List<T>());
        }

        protected void AddToGroups(List<T> items, int step)
        {
            foreach (var item in items)
            {
                int value = item.GetHashCode()
                    % (int)Math.Pow(10, step + 1)
                    / (int)Math.Pow(10, step);

                groups[value].Add(item);
            }
        }

        protected int GetMaxLength()
        {
            int maxLength = 0;

            foreach (var item in Items)
            {
                int length = item.GetHashCode().ToString().Length;
                if (length > maxLength) maxLength = length;
            }

            return maxLength;
        }
    }
}
