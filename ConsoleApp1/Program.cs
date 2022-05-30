using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            new RhimConverter(str).ShowArabType();
        }
    }
}
