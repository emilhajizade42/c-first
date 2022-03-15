using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n daxil et");
            string ns = Console.ReadLine();
            Console.WriteLine("m daxil et");
            string ms = Console.ReadLine();
            int n = int.Parse(ns);
            int m = int.Parse(ms);
            int count = 0;



            for (int i = n; i < m; i++)
            {

                if (i % 15 == 0)
                {
                    count++;
                }

            }
            Console.WriteLine("bu araliqda asagidaki qeder 15 e bolunen eded var ");
            Console.WriteLine(count);




        }
    }
}
