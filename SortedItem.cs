using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTrainer
{
    internal class SortedItem : IComparable
    {
        private int _value;

        public VerticalProgressBar VerticalProgress { get; set; }
        public int Value { get { return _value; } set { _value = value; OnValueChanged(); } }

        public SortedItem(int value, int max, int min, int step)
        {
            _value = value;
            VerticalProgress = new() { Value = value, MaxValue = max, MinValue = min, Step = step, Dock = DockStyle.Left };
        }

        private void OnValueChanged()
        {
            if(VerticalProgress != null)
                VerticalProgress.Value = Value;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) throw new NullReferenceException("Empty object");
            if (obj is not SortedItem)
                throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));

            return Value.CompareTo(((SortedItem)obj).Value);
        }
        public static bool operator <(SortedItem counter1, SortedItem counter2)
        {
            return counter1.Value < counter2.Value;
        }
        public static bool operator > (SortedItem counter1, SortedItem counter2)
        {
            return counter1.Value > counter2.Value;
        }
    }
}
