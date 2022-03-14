using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int inputInt = int.Parse(intput);
            for (var i = 1; i <= inputInt; i++)
            {
                Console.WriteLine(inputInt + "*" + i);
            }
            for (var i = 1; i <= 9; i++) 
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine();
                } 
            }
        }
    }
}
