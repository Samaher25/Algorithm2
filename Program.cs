using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge.Sort
{
    internal class Program
    {

        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] arr = new int[25];
            int i, m, num, n;
            m = (mid - 1);
            n = left;
            num = (right - left + 1);

            while ((left <= m) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    arr[n++] = numbers[left++];
                else
                    arr[n++] = numbers[mid++];
            }
            while (left <= m)
                arr[n++] = numbers[left++];
            while (mid <= right)
                arr[n++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = arr[right];
                right--;
            }
        }

        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[max];
            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\n");
            Console.WriteLine("Input int array : ");
            for (int k = 0; k < max; k++)
            {
                Console.Write(numbers[k] + "  " );
            }
            Console.WriteLine("\n");
            Console.WriteLine("MergeSort : ");
            SortMerge(numbers, 0, max - 1);
            for (int i = 0; i < max; i++)
                Console.Write(numbers[i] + "  ");
            Console.ReadLine();

        }
    }
}
