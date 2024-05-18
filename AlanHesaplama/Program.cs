using System;

abstract class GeometricShape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
    public abstract double CalculateVolume(); // Eğer hacim hesaplanmayacaksa 0 döner.
}

class Circle : GeometricShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
    
    public override double CalculateVolume()
    {
        return 0;
    }
}

class Square : GeometricShape
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public override double CalculateArea()
    {
        return Math.Pow(Side, 2);
    }

    public override double CalculatePerimeter()
    {
        return 4 * Side;
    }

    public override double CalculateVolume()
    {
        return 0;
    }
}

class ShapeCalculator
{
    public void Run()
    {
        Console.WriteLine("İşlem yapmak istediğiniz geometrik şekli seçin (Daire, Kare): ");
        string shapeType = Console.ReadLine().ToLower();

        GeometricShape shape = null;

        switch (shapeType)
        {
            case "daire":
                shape = CreateCircle();
                break;
            case "kare":
                shape = CreateSquare();
                break;
            default:
                Console.WriteLine("Geçersiz şekil tipi.");
                return;
        }

        Console.WriteLine("Hesaplamak istediğiniz boyutu seçin (Çevre, Alan, Hacim): ");
        string dimension = Console.ReadLine().ToLower();

        switch (dimension)
        {
            case "çevre":
                Console.WriteLine("Çevre: " + shape.CalculatePerimeter());
                break;
            case "alan":
                Console.WriteLine("Alan: " + shape.CalculateArea());
                break;
            case "hacim":
                Console.WriteLine("Hacim: " + shape.CalculateVolume());
                break;
            default:
                Console.WriteLine("Geçersiz boyut.");
                break;
        }
    }

    private Circle CreateCircle()
    {
        Console.Write("Yarıçapı girin: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        return new Circle(radius);
    }

    private Square CreateSquare()
    {
        Console.Write("Kenar uzunluğunu girin: ");
        double side = Convert.ToDouble(Console.ReadLine());
        return new Square(side);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ShapeCalculator calculator = new ShapeCalculator();
        calculator.Run();
    }
}
