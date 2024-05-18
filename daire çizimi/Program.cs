using System;

namespace DaireCiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dairenin yarıçapını belirtin:");
            double yaricap = Convert.ToDouble(Console.ReadLine());

            Daire daire = new Daire();
            daire.Ciz(yaricap);
        }
    }

    public class Daire
    {
        public void Ciz(double yaricap)
        {
            double r = yaricap;
            double centerX = r;
            double centerY = r;

            for (int y = 0; y <= 2 * r; ++y)
            {
                for (int x = 0; x <= 2 * r; ++x)
                {
                    double distance = Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2));
                    if (distance > r - 0.5 && distance < r + 0.5)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}
