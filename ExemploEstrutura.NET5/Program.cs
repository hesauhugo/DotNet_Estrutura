using System;

namespace ExemploEstrutura.NET5
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio = 0;
            double.TryParse(Console.ReadLine(),out raio);
            double volume = pi * Convert.ToDouble(4.0/3.0) * System.Math.Pow( raio , 3 );
            Console.WriteLine($"VOLUME = {volume.ToString("0.000")}");
        }
    }
}
