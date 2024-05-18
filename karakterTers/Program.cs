using System;

namespace karakterTers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulamasını yazınız.
            Örnek: Input: Merhaba Hello Question
            Output: erhabaM elloH uestionQ*/
            string input;
            string newStr="";
            Console.WriteLine("String ifadenizi giriniz");
            input=Console.ReadLine();
            string[] parts=input.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                char temp=parts[i][0];
                parts[i]=parts[i].Remove(0, 1);    
                newStr +=parts[i]+temp+" "; 
            }
            Console.WriteLine(newStr);
        }
    }
}
