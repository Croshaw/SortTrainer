using SortTrainer.Sort;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SortTrainer
{
    public partial class Form1 : Form
    {
        SortedItem[]? array;
        SortApi sort;

        public Form1()
        {
            InitializeComponent();
        }


        private void PrintArray(RichTextBox tb, SortedItem[] values)
        {
            panel1.Controls.Clear();
            for (int i = 0; i < values.Length; i++)
                panel1.Invoke(() => panel1.Controls.Add(values[values.Length - i - 1].VerticalProgress));
        }

        private async void PrintArrayAsync(RichTextBox tb, SortedItem[] values)
        {
            await Task.Run(() => PrintArray(tb, values));
        }

        private void GenBTN_Click(object sender, EventArgs e)
        {
            Task<SortedItem[]> task = Generate.GenerateArrayAsync(5);
            Task.Run(() => array = task.GetAwaiter().GetResult()).GetAwaiter().OnCompleted(() => {
                array = task.Result;
                PrintArrayAsync(RawArrayTB, array);
            });
        }

        private void SortBTN_Click(object sender, EventArgs e)
        {
            var timer = new Stopwatch();
            Task<SortedItem[]> task = null;
            timer.Start();
            switch (SortTypeCB.SelectedIndex)
            {
                case 0:
                    sort = new BubbleSort();
                    break;
                 default: return;
            }
            task = sort.SortArray(array);
            Task.Run(() => array = task.GetAwaiter().GetResult()).GetAwaiter().OnCompleted(() => 
            {
                timer.Stop(); 
                SpentTimeTB.Invoke(() => SpentTimeTB.Text = new TimeSpan(timer.Elapsed.Ticks - (long)(500 * sort.SwapCount)).ToString()); //Дорабоать
                ComparisionCountTB.Invoke(() => ComparisionCountTB.Text = sort.ComparisionCount.ToString());
                SwapCountTB.Invoke(() => SwapCountTB.Text = sort.SwapCount.ToString());
                }); 
        }
    }
}