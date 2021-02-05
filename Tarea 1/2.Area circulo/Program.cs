using System;

namespace _2.Area_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
           double radio,area;
           Console.WriteLine("Calculando el area de un circulo\n");
           Console.WriteLine("Dame el radio: ");
           radio=float.Parse(Console.ReadLine());
           area=Math.PI * Math.Pow(radio,2);
           Console.WriteLine("El area del circulo es {0}",area);
           

        }
    }
}
