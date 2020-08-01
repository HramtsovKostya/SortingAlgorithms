using System;
using System.Drawing;
using System.Windows.Forms;

namespace Algorithm.Controls
{
    public class SortedItem : IComparable
    {
        public VerticalProgressBar ProgressBar { get; private set; }
        public Label Label { get; private set; }
        public int Value { get; private set; }
        public int Number { get; private set; }
        public int StartNumber { get; private set; }

        public SortedItem(int value, int number)
        {
            var x = number * 24 + 5;
            Value = value;
            Number = number;
            StartNumber = number;

            CreateProgressBar(number, x);
            CreateLabel(number, x);
        }

        private void CreateLabel(int number, int x)
        {
            Label = new Label
            {
                AutoSize = true,
                Location = new Point(x, 100),
                Name = $"Label{number + 1}",
                Size = new Size(24, 17),
                TabIndex = number,
                Text = Value.ToString()
            };
        }

        private void CreateProgressBar(int number, int x)
        {
            ProgressBar = new VerticalProgressBar
            {
                Name = $"ProgressBar{number + 1}",
                Size = new Size(18, 96),
                Location = new Point(x, 4),
                Minimum = 0,
                Maximum = 100,
                TabIndex = number,
                Color = Color.Blue,
                Step = 1,
                Value = Value
            };
        }

        public void RefreshItem() => SetPosition(StartNumber);

        public void SetPosition(int number)
        {
            var x = number * 24 + 5;
            Number = number;

            ProgressBar.Location = new Point(x, 4);
            ProgressBar.Name = $"ProgressBar{number + 1}";

            Label.Location = new Point(x, 100);
            Label.Name = $"Label{number + 1}";
        }

        public void SetColor(Color color)
        {
        	ProgressBar.Color = color;
        }

        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
                return Value.CompareTo(item.Value);

            throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
        }        

        public override string ToString() => Value.ToString();

        public override int GetHashCode() => Value;
    }
}