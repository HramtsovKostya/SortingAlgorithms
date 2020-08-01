using Algorithm.Model;
using System;
using System.Collections.Generic;

namespace Algorithm.Sorts
{
    /// <summary>
    /// Сортировка Шелла.
    /// </summary>
    /// <typeparam name="T"> Тип принимаемых данных. </typeparam>
    public class ShellSort<T> : SortBase<T>
        where T : IComparable
    {
        public ShellSort() { }

        public ShellSort(ICollection<T> items) : base(items) { }

        protected override void MakeSort()
        {
            int step = Items.Count / 2;

            while (step > 0)
            {
                for (int i = step, j = step; i < Items.Count; i++, j = i)
                {
                    while (j >= step && Compare(Items[j - step], Items[j]) == 1)
                    {
                        Swap(indexA: j - step, indexB: j);
                        j -= step;
                    }
                }
                step /= 2;
            }
        }

        public override string ToString()
        {
            return "Сортировка Шелла";
        }
    }
}