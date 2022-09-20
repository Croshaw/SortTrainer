using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTrainer
{

    internal class Generate
    {
        static readonly Random rand = new();

        public static SortedItem[] GenerateArray(int len)
        {
            SortedItem[] array = new SortedItem[len];
            for (int i = 0; i < len; i++)
                array[i] = new(rand.Next(0, 100), 100, 0, 1);
            return array;
        }

        public static async Task<SortedItem[]> GenerateArrayAsync(int len)
        {
            return Task.Run(() => GenerateArray(len)).GetAwaiter().GetResult();
        }
    }
}
