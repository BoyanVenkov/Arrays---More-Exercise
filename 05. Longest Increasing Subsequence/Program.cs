using System;
using System.Linq;

namespace TestApp
{
    public class Program
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = nums.Length;
            int[] len = new int[n];
            int[] prev = new int[n];

            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < n; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i] && len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }

                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }

            int[] lis = new int[maxLength];
            int index = maxLength - 1;
            while (lastIndex != -1)
            {
                lis[index] = nums[lastIndex];
                index--;
                lastIndex = prev[lastIndex];
            }

            Console.WriteLine(string.Join(" ", lis));
        }
    }
}