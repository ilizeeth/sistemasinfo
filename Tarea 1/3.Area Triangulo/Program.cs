//Programa que calcula el area del triangulo
using System;

namespace _3.Area_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {   
            float baseT, altura, area;
            Console.WriteLine("Calculando el area del triangulo\n");
            Console.WriteLine("Dame la base:");
            baseT=float.Parse(Console.ReadLine());
            Console.WriteLine("\nDame la altura:");
            altura=float.Parse(Console.ReadLine());
            
            area=(baseT*altura)/2;

            Console.WriteLine($"El area es {area}");

        }
    }
}
