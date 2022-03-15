using System;

namespace tapsiriq_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 9, 4, 1, 6, };
            int counter = 0;
            int sum = 0;
            Console.WriteLine("Hello World!");
            Array.Sort(arr);
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (sum<10)
                {
                    sum = sum + arr[i];
                    counter++;
                }
                else if (sum>10)
                {
                    break;
                }
            }

            Console.WriteLine("say: "+counter-1);

        }
    }
}
