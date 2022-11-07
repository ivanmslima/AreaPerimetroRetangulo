using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double b, a, area, perimetro, diagonal;

        Console.WriteLine("Entre com a base:");
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com a altura:");
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        area = b * a;
        perimetro = 2 *(a + b);
        diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

        Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

        Console.ReadLine();


    }

}