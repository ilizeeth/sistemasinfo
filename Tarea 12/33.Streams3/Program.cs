using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace _33.Streams3
{
      [Serializable]
        public class Empelado{
            public int Id{get; set;}
            public string Nombre {get; set;}
            public double Salario{get; set;}
            public override string ToString() => $"Id:{Id,-3},Nombre:{Nombre,-12},Salario:{Salario,10:N0}";
        }

    class Program
    {
        static string ruta = Path.Combine(Environment.CurrentDirectory,"datos.xml");
        
      
        static void Main(string[] args)
        {
            Console.WriteLine("Escribir y leer datos en un formato XML");
            List<Empelado> emps = new List<Empelado>(){
                new Empelado{Id=1,Nombre="Juan Perez",Salario=5300},
                new Empelado{Id=2,Nombre="Maria Lopez",Salario=6500},
                new Empelado{Id=3,Nombre="Gerardo Jimenez",Salario=15300},
                new Empelado{Id=4,Nombre="Claudia Reyes",Salario=3000}
            };

            WriteLine("Serializar datos de empleados...");
            FileStream fEmps = File.Open(ruta,FileMode.Create);
            XmlSerializer xmlEmps = new XmlSerializer(typeof(List<Empelado>));
            xmlEmps.Serialize(fEmps,emps);
            fEmps.Close();

            WriteLine("Desearilizar datos en el archivo {0}",ruta);
            //List<Empelado> emps2= new List<Empelado> ();
            FileStream femp2= File.Open(ruta,FileMode.Open);
            XmlSerializer xmlemp2 = new XmlSerializer(typeof(List<Empelado>));
            List<Empelado> emps2 = (List<Empelado>)xmlemp2.Deserialize(femp2);
        }
    }
}
