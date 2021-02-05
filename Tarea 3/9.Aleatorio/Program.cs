//Programa que genera dos vectores de 15 elementos aleatorios y los suma en un vector
using System;

namespace _9.Aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tamaño=15;
            int [] A =new int[tamaño];
            int [] B =new int[tamaño];
            int [] C =new int[tamaño];
            Random rnd = new Random();
            for(int i=0;i<tamaño;i++){
                A[i]=rnd.Next(1,100);
                B[i]=rnd.Next(1,100);
                C[i]=A[i]+B[i];
            }
             Console.WriteLine("\nPrograma que genera dos vectores de 15 elementos aleatorios y los suma en un tercer vector");
            Console.WriteLine("\n\nElementos en el vector A: "); imprime(A);
            Console.WriteLine("\nElementos en el vector B: "); imprime(B);
            Console.WriteLine("\nElementos en el vector C: "); imprime(C);
           
        }
        
        static void imprime(int[] v){
            for(int i=0;i<v.Length; i++){
                Console.Write("{0} ",v[i]);
                //Console.WriteLine("\n\n");
            }
        }
    }
}
