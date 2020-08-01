using Algorithm.Model;
using System;
using System.Collections.Generic;

namespace Algorithm.Sorts
{
    /// <summary>
    /// Шейкерная сортировка.
    /// </summary>
    /// <typeparam name="T"> Тип принимаемых данных. </typeparam>
    public class CocktailSort<T> : SortBase<T>
        where T : IComparable
    {
        public CocktailSort() { }

        public CocktailSort(IEnumerable<T> items) : base(items) { }        

        protected override void MakeSort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while (left < right)
            {
                int swapCount = SwapCount;

                for (int i = left; i < right; i++)
                {
                    if (Compare(Items[i], Items[i + 1]) == 1)
                        Swap(indexA: i, indexB: i + 1);
                }
                right--;

                if (swapCount == SwapCount) break;

                for (int i = right; i > left; i--)
                {
                    if (Compare(Items[i], Items[i - 1]) == -1)
                        Swap(indexA: i, indexB: i - 1);
                }
                left++;

                if (swapCount == SwapCount) break;
            }
        }

        public override string ToString()
        {
            return "Шейкерная сортировка";
        }
    }
}