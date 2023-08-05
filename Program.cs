using System;

namespace ExecutableCICD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("Hello World => " + i);
            }

            Environment.Exit(0);
        }
    }
}
