//Programa que calcula el vector promedio
using System;

namespace _8.VecProm
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vector= {10,15,20,25,30,35,40,45,40,55,
                            10,15,20,25,30,35,40,45,40,55,
                            10,15,20,25,30,35,40,45,40,55,
                            10,15,20,25,30,35,40,45,40,55,
                            10,15,20,25,30,35,40,45,40,55};
            int suma=0,nmp=0;
            float prom;
            Console.WriteLine("Programa que calcula el promedio de un vector de 50 valores constantes");
            
            //Calcular suma de los elementos del arreglo
             for(int i=0;i<vector.Length;i++){
                Console.Write("{0} ",vector[i]);
                suma+=vector[i]; //Suma los elementos del vector
            }
            
            //Calcular promedio
            prom=suma/vector.Length;
            //Calcular cuantos elementos del arreglo es mayor al promedio
            Console.WriteLine("\n\n");
            Console.WriteLine("La suma de los numeros del vector es: {0}",suma);

            for(int i=0;i<vector.Length;i++){
                if(vector[i]>prom){
                    Console.Write("{0}",vector[i]);
                    nmp++;
                }
            }
            Console.WriteLine("\nEl promedio es: {0} \n",prom); //Muestra el promedio en pantalla
            //Mostrar cuantos elementos son mayores al promedio 
            Console.WriteLine("\nElementos mayores al promedio: {0}  \n",nmp);
        }
    }
}
