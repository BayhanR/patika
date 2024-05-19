using System;

namespace Integer_Ikililerin_Toplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ikişer integer giriniz");
            string input=Console.ReadLine();
            string[] inputArr=input.Split(' ');    
            if (inputArr.Length % 2 == 0)
            {
                string newArray = "";
                for (int i = 0; i < inputArr.Length-1; i+=2)
                {
                    if (inputArr[i] == inputArr[i + 1])
                    {
                        newArray += Convert.ToString(Math.Pow(int.Parse(inputArr[i]) * int.Parse(inputArr[i + 1]), 2)) + " ";

                    }
                    else
                    {
                        newArray += Convert.ToString(int.Parse(inputArr[i]) + int.Parse(inputArr[i + 1])) + " ";
                    }
                }
                for (int i = 0; i < newArray.Length-1; i++)
                {
                    Console.Write(newArray[i]);
                }
            }
            else
            {
                Console.WriteLine("hatalı input tipi ");
            }
        }
    }
}
