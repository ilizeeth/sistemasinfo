//Generar 20 num aleatorios, sacarles su cubo y guardarlos en otro vector
using System;

namespace _10.Cubo
{
    class Program
    {
        static void Main(string[] args)
        {
           double[] A = new double[20];
           double[] B = new double[20];

           Random rnd=new Random();

           //Generar numeros aleatorios para el vector A 
           for(int i=0;i<A.Length;i++){
               A[i]=rnd.Next(-10,50);
               B[i]=Math.Pow(A[i],3); //Eleva los elementos de A al cubo y lo guarda en B
           }
           //Mostrar resultados
           Console.WriteLine("\nElementos de A"); imprime(A);
           Console.WriteLine("\nElementos de B"); imprime(B);
        }

        static void imprime(double[] v){
            for(int i=0;i<v.Length;i++)
                Console.Write($"{v[i]} ");       
            }
    }
}
