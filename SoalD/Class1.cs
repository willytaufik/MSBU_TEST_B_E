using System;
namespace SoalC;
class Class1
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan nilai N: ");
        String? inputString = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(inputString))
    {
         int? N = int.Parse(inputString);
        for (int i = 1; i <= N; i++)
        {
            if (i % 5 == 0 && i != 5)
            {
                Console.Write("IDIC ");
            }
            else if (i % 6 == 0 && i != 6)
            {
                Console.Write("LPS ");
            }
            else
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
    }
}
