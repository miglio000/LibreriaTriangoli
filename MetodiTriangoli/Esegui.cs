using System;

namespace MetodiTriangoli
{
    public class Esegui
    {
        public static double InserisciLato()
        {
            Console.WriteLine("Inserisci il lato: ");
            double n = Convert.ToDouble(Console.ReadLine());
            return n;
        }
        public static string TipoTriangolo(double n1, double n2, double n3)
        {
            string tipotriangolo;
            if (n1 == n2 && n1 == n3)
            {
                tipotriangolo = "Equilatero";
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                tipotriangolo = "Isoscele";
            }
            else
            {
                tipotriangolo = "Scaleno";
            }


            return tipotriangolo;
        }
        public static double? PerimetroTriangolo(double n1, double n2, double n3)
        {
            double? perimetro;
            if (n1 > 0 || n2 > 0 || n3 > 0)
            {
                perimetro = n1 + n2 + n3;
                return perimetro;
            }
            else
            {
                perimetro = null;
                Console.WriteLine("Errore");
            }
            return perimetro;
        }
    }
}
