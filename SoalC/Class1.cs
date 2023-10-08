using System;
using System.Collections.Generic;
using System.Linq;
namespace SoalC;
class Class1
{
    static void Main(string[] args)
    {
         Console.Write("Masukkan kata: ");
        string? input = Console.ReadLine();
        Dictionary<char, int> charCount = new Dictionary<char, int>();
         if (input != null)
        {
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }
            }
            foreach (var kvp in charCount)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
