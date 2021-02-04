using System;
using System.Globalization;

namespace EtapaTecnicaGFT
{
    class Calcula
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }


        public void ImprimeValores()
        {
            if (A == 0 || (B * B - 4 * A * C < 0))
            {
                Console.WriteLine("Impossível Calcular");
            }
            else
            {
                X1 = (-B + Math.Sqrt(B * B - 4 * A * C)) / (2 * A);
                X2 = (-B - Math.Sqrt(B * B - 4 * A * C)) / (2 * A);
                Console.WriteLine("X1 = " + X1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + X2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
