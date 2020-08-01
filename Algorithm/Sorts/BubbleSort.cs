using Algorithm.Model;
using System;
using System.Collections.Generic;

namespace Algorithm.Sorts
{
    /// <summary>
    /// Сортировка пузырьком.
    /// </summary>
    /// <typeparam name="T"> Тип принимаемых данных. </typeparam>
    public class BubbleSort<T> : SortBase<T>
        where T : IComparable
    {
        public BubbleSort() { }

        public BubbleSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                int swapCount = SwapCount;

                for (int j = 0; j < Items.Count - i - 1; j++)
                {
                    if (Compare(Items[j], Items[j + 1]) == 1)
                        Swap(indexA: j, indexB: j + 1);  
                }

                if (swapCount == SwapCount) break;
            }            
        }

        public override string ToString()
        {
            return "Сортировка пузырьком";
        }
    }
}