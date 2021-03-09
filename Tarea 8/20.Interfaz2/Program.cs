using System;

namespace _20.Interfaz2
{
    public class Organismo{
        public Organismo(string nombre)=>Nombre=nombre;
        public string Nombre{get; set;}
        public void Respiracion()=>Console.WriteLine("Respirando..");
        public void Movimiento()=>Console.WriteLine("Moviendose..");
        public void Crecimiento()=>Console.WriteLine("Creciendo..");
    }

    public interface IAnimales{
        void Multicelular();
        void SangreCaliente();
    }

    public interface ICanino : IAnimales{
        void Correr();
        void CuatroPatas();
    }

    public interface IAve : IAnimales{
        void Volar();
        void DosPatas(); 
            }

    public class Perro : Organismo, ICanino{
        public Perro(string nombre):base(nombre){}
        public void Multicelular()=>Console.WriteLine("Multicelular perro");
        public void SangreCaliente()=>Console.WriteLine("Sangre Caliente Perro");
        public void Correr()=>Console.WriteLine("Corre Perro");
        public void CuatroPatas()=>Console.WriteLine("CuatroPatas Perro");
    }

    public class Perico : Organismo, IAve{
        public Perico(string nombre): base(nombre){}
        public void Multicelular()=>Console.WriteLine("Multicelular Perico");
        public void SangreCaliente()=>Console.WriteLine("Sangre Caliente Perico");
        public void Volar()=>Console.WriteLine("Vuela Perro");
        public void DosPatas()=>Console.WriteLine("DosPatas Perro");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 2");
            Perro MiPerro = new Perro("Leah");
            Console.WriteLine($"Mi perro llamado {MiPerro.Nombre} esta haciendo lo siguiente");
            MiPerro.Respiracion();
            MiPerro.Movimiento();
            MiPerro.Crecimiento();
            MiPerro.Multicelular();
            MiPerro.SangreCaliente();
            MiPerro.Correr();
            MiPerro.CuatroPatas();

            Perico MiPerico = new Perico("Spark");
            Console.WriteLine($"Mi perico llamado {MiPerico.Nombre} esta haciendo lo siguiente");
            MiPerico.Respiracion();
            MiPerico.Movimiento();
            MiPerico.Crecimiento();
            MiPerico.Multicelular();
            MiPerico.SangreCaliente();
            MiPerico.Volar();
            MiPerico.DosPatas();
        }
    }
}
