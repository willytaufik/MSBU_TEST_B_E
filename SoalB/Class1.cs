using System;
using System.Collections.Generic;
using System.Linq;

namespace SoalB;

public class Class1
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan angka: ");
        string? input = Console.ReadLine();
        if (input != null)
        {
            input = input.Replace(".", "");
            int length = input.Length;
            for (int i = 0; i < length; i++)
            {
                int digit = int.Parse(input[i].ToString());
                int value = digit * (int)Math.Pow(10, length - i - 1);
                if (value > 0)
                {
                    Console.WriteLine(value);
                }
            }
        }
}



}
