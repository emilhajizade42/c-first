using System;

namespace tapsiriq_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string num = Console.ReadLine();
            int n = int.Parse(num);
            int i = 0;
                while(i*i <= n)
            {
                i++;
                

            }
            Console.WriteLine(i-1);
        }
    }
}
