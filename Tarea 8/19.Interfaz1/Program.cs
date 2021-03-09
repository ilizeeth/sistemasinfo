using System;

namespace _19.Interfaz1
{
    class Program
    {
        public interface IAnimal{
            string Nombre{get; set;}
            void LLorar();
        }
        
        class Perro : IAnimal{
            public Perro(string nombre)=> Nombre = nombre;
            public string Nombre{get; set;}
            public void Llorar() => Console.WriteLine("Woff woff");
        }

        class Gato : IAnimal{
            public Gato(string nombre,string raza)=> (Nombre,Raza) = (nombre,raza) ;
            public string Nombre{get; set;}
            public string Raza{get; set;}
            public void Llorar() => Console.WriteLine("Miua Miau");
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 1 de Interfaces");
            Perro MiPerro = new Perro("El capitan");
            Console.WriteLine($"El perro {MiPerro.Nombre}, llora asi: ");
            MiPerro.Llorar();

            Gato MiGato = new Gato("Pancho", "Irlandes");
            Console.WriteLine($"El gato {MiGato.Nombre} de raza {MiGato.Raza} llora así:");
            MiGato.Llorar();
        }
    }
}
