using Algorithm.Controls;
using Algorithm.Model;
using Algorithm.Sorts;
using Algorithm.Structures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Algorithm.UI
{
    public partial class MainForm : Form
    {
        private readonly List<SortedItem> items = new List<SortedItem>();

        public MainForm() => InitializeComponent();

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value)
                && value >= 0 && value <= 100 && items.Count < 20)
            {
                items.Add(new SortedItem(value, items.Count));
                RefreshItems();
            }

            AddTextBox.Clear();
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FillTextBox.Text, out int size)
                && size >= 0 && size <= 20)
            {
                var rnd = new Random();
                items.Clear();

                for (int i = 0; i < size; i++)
                    items.Add(new SortedItem(rnd.Next(101), items.Count));

                RefreshItems();
            }

            FillTextBox.Clear();
        }

        private void RefreshItems()
        {
            ViewPanel.Controls.Clear();

            foreach (var item in items)
            {
                item.RefreshItem();
                ViewPanel.Controls.Add(item.ProgressBar);
                ViewPanel.Controls.Add(item.Label);
            }
            ViewPanel.Refresh();
        }

        private void ButtonClick(SortBase<SortedItem> algorithm)
        {
            SortNameLabel.Text = "Идет сортировка ...";
            SortTimeLabel.Text = ComparisonsLabel.Text = SwapsLabel.Text = "";
            InfoPanel.Refresh();

            RefreshItems();

            for (int i = 0; i < algorithm.Items.Count; i++)
                algorithm.Items[i].SetPosition(i);
            ViewPanel.Refresh();
            
            algorithm.Comparing += Algorithm_Comparing;
            algorithm.Swapping += Algorithm_Swapping;
            algorithm.Setting += Algorithm_Setting;

            algorithm.Sort();

            SortNameLabel.Text = algorithm.ToString();
            SortTimeLabel.Text = (decimal)algorithm.SortTime / 1000 + " сек";
            ComparisonsLabel.Text = algorithm.CompareCount + " раз";
            SwapsLabel.Text = algorithm.SwapCount + " раз";
        }

        private void Algorithm_Setting(object sender, Tuple<SortedItem, int> e)
        {
            e.Item1.SetColor(Color.Red);
            ViewPanel.Refresh();

            Thread.Sleep(SleepTrackBar.Value);

            e.Item1.SetPosition(e.Item2);
            e.Item1.SetColor(Color.Blue);
            ViewPanel.Refresh();
        }

        private void Algorithm_Comparing(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            ViewPanel.Refresh();

            Thread.Sleep(SleepTrackBar.Value);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            ViewPanel.Refresh();
        }

        private void Algorithm_Swapping(object sender, Tuple<SortedItem, SortedItem> e)
        {
            int temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);

            ViewPanel.Refresh();
        }

        private void SleepTrackBar_Scroll(object sender, EventArgs e)
        {
            SleepTimeLabel.Text = (decimal)SleepTrackBar.Value / 1000 + " сек";
        }

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            ButtonClick(bubble);
        }

        private void CocktailSortButton_Click(object sender, EventArgs e)
        {
            var cocktail = new CocktailSort<SortedItem>(items);
            ButtonClick(cocktail);
        }

        private void InsertSortButton_Click(object sender, EventArgs e)
        {
            var insert = new InsertSort<SortedItem>(items);
            ButtonClick(insert);
        }
        
        private void ShellSortButton_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            ButtonClick(shell);
        }

        private void SelectSortButton_Click(object sender, EventArgs e)
        {
            var select = new SelectSort<SortedItem>(items);
            ButtonClick(select);
        }       
        

        private void GnomeSortButton_Click(object sender, EventArgs e)
        {
            var gnome = new GnomeSort<SortedItem>(items);
            ButtonClick(gnome);
        }

        private void HeapSortButton_Click(object sender, EventArgs e)
        {
            var heap = new BinaryHeap<SortedItem>(items);
            ButtonClick(heap);
        }

        private void TreeSortButton_Click(object sender, EventArgs e)
        {
            var tree = new BinaryTree<SortedItem>(items);
            ButtonClick(tree);
        }

        private void MsdRadixSortButton_Click(object sender, EventArgs e)
        {
            var msdRadix = new MsdRadixSort<SortedItem>(items);
            ButtonClick(msdRadix);
        }

        private void LsdRadixSortButton_Click(object sender, EventArgs e)
        {
            var lsdRadix = new LsdRadixSort<SortedItem>(items);
            ButtonClick(lsdRadix);
        }

        private void MergeSort_Click(object sender, EventArgs e)
        {
            var merge = new MergeSort<SortedItem>(items);
            ButtonClick(merge);
        }

        private void QuickSort_Click(object sender, EventArgs e)
        {
            var quick = new QuickSort<SortedItem>(items);
            ButtonClick(quick);
        }
    }
}