using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTrainer.Sort
{
    internal class SortApi
    {
        public int ComparisionCount { get; set; } = 0;
        public int SwapCount { get; set; } = 0;

        public virtual async Task<SortedItem[]> SortArray(SortedItem[] array)
        { return array; }

        public void Swap(int pos1, int pos2, ref SortedItem[] array)
        {
            int temp = array[pos2].Value;
            array[pos2].Value = array[pos1].Value;
            array[pos1].Value = temp;
            SwapCount++;
        }
    }
}
