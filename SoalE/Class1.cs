namespace SoalE;
using System;
class Class1
{
    static void Main(string[] args)
    {
        Console.Write("Masukan Kalimat: ");
        string? input = Console.ReadLine();

        string[] words = input?.Split(' ') ?? new string[0];
        string titleCase = "";
        string normalCase = "";

        foreach (string word in words)
        {
            if (word.Length > 0)
            {
                
                string titleWord = char.ToUpper(word[0]) + word.Substring(1).ToLower();

                titleCase += titleWord + " ";
                normalCase += word.ToLower() + " ";
            }
        }

        titleCase = titleCase.Trim();
        normalCase = normalCase.Trim();

        Console.WriteLine("Format Judul: " + titleCase);
        Console.WriteLine("Format Biasa: " + normalCase);
    }
}
