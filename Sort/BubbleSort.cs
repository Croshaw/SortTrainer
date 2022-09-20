using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTrainer.Sort
{
    internal class BubbleSort : SortApi
    {
        public override async Task<SortedItem[]> SortArray(SortedItem[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length-i-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        array[j].VerticalProgress.Color = array[j + 1].VerticalProgress.Color = Color.Green;
                        await Task.Delay(500);
                        Swap(j, j + 1, ref array);
                        array[j].VerticalProgress.Color = array[j + 1].VerticalProgress.Color = Color.Blue;
                    }
                    ComparisionCount++;
                }
                array[array.Length - i - 1].VerticalProgress.Color = Color.Red;
            }
            return array;
        }

        //public async Task<SortedItem[]> SortArrayAsync(SortedItem[] array)
        //{
        //    return await Task.Run(() => SortArray(array));
        //}
    }
}
