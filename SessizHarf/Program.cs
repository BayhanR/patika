using System;

namespace SessizHarf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                if (ContainsConsecutiveConsonants(word))
                {
                    Console.Write("True ");
                }
                else
                {
                    Console.Write("False ");
                }
            }
        }

        static bool ContainsConsecutiveConsonants(string word)
        {
            char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü',
                              'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü',',',';',',' };

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (!Array.Exists(vowels, element => element == word[i]) &&
                    !Array.Exists(vowels, element => element == word[i + 1]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

