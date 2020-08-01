using Algorithm.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Sorts
{
    /// <summary>
    /// Сортировка слиянием.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MergeSort<T> : SortBase<T>
        where T : IComparable
    {
        public MergeSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            var result = Sort(Items);

            for (int i = 0; i < result.Count; i++)
                Set(result[i], i);
        }

        private List<T> Sort(List<T> items)
        {
            if (items.Count == 1) return items;

            int middle = items.Count / 2;
            var left = items.Take(middle).ToList();
            var right = items.Skip(middle).ToList();

            return Merge(Sort(left), Sort(right));
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            int length = left.Count + right.Count;
            int leftPointer = 0, rightPointer = 0;

            var result = new List<T>(length);

            for (int i = 0; i < length; i++)
            {
                if (leftPointer < left.Count && rightPointer < right.Count)
                {
                    if (Compare(left[leftPointer], right[rightPointer]) == -1)
                        result.Add(left[leftPointer++]);
                    else result.Add(right[rightPointer++]);
                }
                else
                {
                    var items = rightPointer < right.Count
                        ? right.Skip(rightPointer) : left.Skip(leftPointer);

                    result.AddRange(items); break;
                }
            }
            return result;
        }

        public override string ToString()
        {
            return "Сортировка слиянием";
        }
    }
}