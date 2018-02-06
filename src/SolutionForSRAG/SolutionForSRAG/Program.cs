using SmartRandomAlphanumericGenerator;
using System;

namespace SolutionForSRAG
{
    class Program
    {
        static void Main(string[] args)
        {
            SRAGenerator rang = new SRAGenerator();
            rang.UseNumbers = false;
            rang.UseLowercaseLetters = false;
            rang.UseUppercaseLetters = true;
            rang.UseSymbols = false;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rang.Generate(10));
            }

            Console.ReadKey();
        }
    }
}
