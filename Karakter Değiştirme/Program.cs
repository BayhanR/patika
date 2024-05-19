using System;

namespace Karakter_Değiştirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input: ");
            string input=Console.ReadLine();
            string[] newStr = input.Split(" ");
            input = "";
            for (int i = 0; i < newStr.Length; i++)
            {
                if (newStr[i].Length == 1)
                {
                    input += newStr[i] + " ";
                    continue;
                }
                else
                {
                    char tempCharFirst = newStr[i][0];
                    char tempCharLast = newStr[i][newStr[i].Length - 1];
                    string tempStr = "";
                    for (int j = 0; j < newStr[i].Length - 2; j++)
                    {
                        if (j == 0)
                        {
                            tempStr += tempCharLast;
                            continue;
                        }
                        tempStr += newStr[i][j];
                    }
                    tempStr += tempCharFirst;
                    input += tempStr + " ";
                }
                
            }

            Console.WriteLine(input);
        }
    }
}
