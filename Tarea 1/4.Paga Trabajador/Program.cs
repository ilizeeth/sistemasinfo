//Paga trabajador
using System;

namespace _4.Paga_Trabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int horas;
            float paga, tasa =0.10F;
            float impuesto, pagabruta,paganeta;
            Console.WriteLine("Calcula de la paga de un trabajador \n");
            Console.WriteLine("Nombre del trabajador: "); nombre=Console.ReadLine();
            Console.WriteLine("\nHoras Trabajadas: "); horas=int.Parse(Console.ReadLine());
            Console.WriteLine("\nPaga por hora: "); paga=float.Parse(Console.ReadLine());

            pagabruta=horas*paga;
            impuesto=pagabruta*tasa;
            paganeta=pagabruta-impuesto;
            
            Console.WriteLine("\nEstimado: "+ nombre);
            Console.WriteLine($"Trabajaste {horas} horas, con una paga por hota de {paga}\n");
            Console.WriteLine("Paga bruta: {0}",pagabruta);
            Console.WriteLine("Impuesto: {0}",impuesto);
            Console.WriteLine("Impuesto: {0}",impuesto);
            Console.WriteLine("Paga neta: {0}",paganeta);



        }
    }
}
