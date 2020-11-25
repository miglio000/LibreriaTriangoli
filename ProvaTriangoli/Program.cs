using System;
using MetodiTriangoli;

namespace ProvaTriangoli
{
    class Program
    {
        static void Main(string[] args)
        {
            double lato1 = Class1.InserisciLato();
            double lato2 = Class1.InserisciLato();
            double lato3 = Class1.InserisciLato();
            double? perimetro = Class1.PerimetroTriangolo(lato1, lato2, lato3);
            string tipo_triangolo = Class1.TipoTriangolo(lato1, lato2, lato3);
            Console.WriteLine($"Il perimetro è {perimetro}, ed è {tipo_triangolo}");
        }
    }
}
