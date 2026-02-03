using System;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calculadora de Área de Triángulo ---");
            
            Console.Write("Ingresa la base: ");
            double baseT = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Ingresa la altura: ");
            double alturaT = Convert.ToDouble(Console.ReadLine());
            
            double area = (baseT * alturaT) / 2;
            
            Console.WriteLine($"\nEl área es: {area}");
        }
    }
}