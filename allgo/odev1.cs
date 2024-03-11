using System.Diagnostics.Metrics;
using System.Globalization;
class Program{
    static void Main(){
Console.WriteLine("Enter the positive numbers");
Console.Clear();

int positivenumber = 0;

while (positivenumber < 5)
{
    Console.WriteLine("Enter 5 positive numbers");
    int posnumber = Convert.ToInt32(Console.ReadLine());
    positivenumber++;

    Console.WriteLine(posnumber % 2 == 0 ? "Number is Even " + posnumber : "Number is Odd");
}
    }
}