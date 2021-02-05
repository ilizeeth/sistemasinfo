using System;

namespace _14.Estadisticas
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX=100;
            int n=0;
            double[] valores;

            double mayor=0,menor=0,promedio=0,varianza=0,desvest=0;
            Console.WriteLine("Programa que genera estadisticas de numeros\n");
            Console.WriteLine("Cuantos elementos deseas calcular?: "); n=int.Parse(Console.ReadLine());

            if(n>MAX){
                Console.WriteLine("El maximo numero de elementos es {0}",MAX);
            }
            else{
                valores=new double[n];
                //leer valores del usuario
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("valores[{0}]",i+1);
                    valores[i]=double.Parse(Console.ReadLine());
                }

                //Calculos
                mayor=Funciones.May(valores);
                menor=Funciones.Men(valores);
                promedio=Funciones.Prom(valores);
                varianza=Funciones.Var(valores,promedio);
                desvest=Math.Sqrt(varianza);

                //Salida
                Console.WriteLine("El numero mayor es: {0}",mayor);
                Console.WriteLine("El numero menor es: {0}",menor);
                Console.WriteLine("El promedio es: {0}",promedio);
                Console.WriteLine("La varianza es: {0}",varianza);
                Console.WriteLine("La desviacion estandar es: {0}",desvest);
            }

        }
    }
}
