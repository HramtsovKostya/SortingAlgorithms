using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithm.Model
{
    public abstract class SortBase<T> where T : IComparable
    {
        public int SwapCount { get; protected set; }
        public int CompareCount { get; protected set; }
        public long SortTime { get; protected set; }
        public List<T> Items { get; protected set; } = new List<T>();

        public event EventHandler<Tuple<T, T>> Comparing;
        public event EventHandler<Tuple<T, T>> Swapping;
        public event EventHandler<Tuple<T, int>> Setting;

        public SortBase() { }

        public SortBase(IEnumerable<T> items) => Items.AddRange(items);

        public void Sort()
        {
            var timer = new Stopwatch();

            timer.Start();
            MakeSort();
            timer.Stop();

            SortTime = timer.ElapsedMilliseconds;
        }

        protected void Set(T item, int position)
        {
            if (position < Items.Count)
            {
                Setting?.Invoke(this, new Tuple<T, int>(item, position));
                SwapCount++;
                
                Items[position] = item;
            }
        }

        protected void Swap(int indexA, int indexB)
        {
            if (indexA < Items.Count && indexB < Items.Count)
            {
                Swapping?.Invoke(this, new Tuple<T, T>(Items[indexA], Items[indexB]));
                SwapCount++;

                var temp = Items[indexA];
                Items[indexA] = Items[indexB];
                Items[indexB] = temp;                
            }
        }

        protected int Compare(T firstItem, T secondItem)
        {
            Comparing?.Invoke(this, new Tuple<T, T>(firstItem, secondItem));
            CompareCount++;          

            return firstItem.CompareTo(secondItem);
        }

        protected abstract void MakeSort();
    }
}