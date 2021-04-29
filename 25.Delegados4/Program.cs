using System;

//Generico

namespace _25.Delegados4
{
    public delegate T Suma<T>(T p1, T p2);
    
    class Program
    {
        static void Main(string[] args)
        {
            Suma<int> d1=Sumar;
            Suma<string> d2=Concatena;
            Console.WriteLine($"La suma es: {d1(20,30)}");
            Console.WriteLine($"La contentacion es: {d2("Cepellin"," Se nos fue")}");
            
        }

        public static int Sumar(int a, int b) => a+b;
        public static string Concatena(string a, string b) => a+b;
        public static string NosePuede(string a, int b) => $"{a}-{b.ToString()}";
    }
}
