using System;
using System.Collections.Generic;

namespace _21.Interfaz3
{

    class Empleado{
        public string Paterno{get; set;}
        public string Materno{get; set;}
        public string Nombre{get; set;}
        public double Salario{get; set;}

        public int CompareTo(Empleado otro){
            if(this.Salario < otro.Salario) return 1;
            else if(this.Salario> otro.Salario) return -1;
            else return 0;
        }
        public override string ToString()=>$"{Nombre} - {Salario}";

        public string ToString(string formato, IFormatProvider proveedor){
            switch(formato){
                case "PMNS" : return $"{Paterno} - {Materno} - {Nombre} - {Salario}";
                case "NPMS" : return $"{Paterno} - {Materno} - {Nombre} - {Salario}";
                case "PMN" : return $"{Paterno} - {Materno} - {Nombre} ";
                default: throw new FormatException("Formato Desconocido");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 3: interfaces integradas");
            List<Empleado> emps = new List <Empleado>{
                new Empleado(){Paterno ="Castañeda", Materno="Ramirez", Nombre="Carlos", Salario=10005.25},
                new Empleado(){Paterno ="Diaz", Materno="Perez", Nombre="Juan", Salario=1105.25},
                new Empleado(){Paterno ="Torres", Materno="Orozco", Nombre="Pedro", Salario=5105.15},
                new Empleado(){Paterno ="Arias", Materno="Rivas", Nombre="Luis", Salario=1005.15},
                new Empleado(){Paterno ="Carrillo", Materno="Correa", Nombre="Maria", Salario=2105.15}
            };

            Console.WriteLine("\nListado de empleados en el orden del salario ascendente, nombre y salario");
            emps.Sort();
            emps.ForEach(e=>Console.WriteLine(e.ToString()));
            Console.WriteLine("\nListado de empleados en el orden del salario descendente, nombre y salario");
            emps.Reverse();
            emps.ForEach(e=>Console.WriteLine(e.ToString()));

            Console.WriteLine("\nListado de empleados con formato personalizado, paterno , materno, nombre y salario");
            emps.ForEach(e=>Console.WriteLine(e.ToString("PMNS", System.Globalization.CultureInfo.CurrentCulture)));

        }
    }
}
