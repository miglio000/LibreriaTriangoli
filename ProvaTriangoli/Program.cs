using System;
using MetodiTriangoli;

namespace ProvaTriangoli
{
    class Program
    {
        static void Main(string[] args)
        {
            double lato1 = Esegui.InserisciLato();
            double lato2 = Esegui.InserisciLato();
            double lato3 = Esegui.InserisciLato();
            double? perimetro = Esegui.PerimetroTriangolo(lato1, lato2, lato3);
            string tipo_triangolo = Esegui.TipoTriangolo(lato1, lato2, lato3);
            Console.WriteLine($"Il perimetro è {perimetro}, ed è {tipo_triangolo}");
        }
    }
}
