using System;
using System.IO;
using static System.Console;

namespace _32.Streams2
{
    class Program
    {
        static string ruta = Path.Combine(Environment.CurrentDirectory,"opciones.bin");
        static void Main(string[] args)
        {
           WriteLine("\nLectura y Escritura de datos en un archivo binario");
            Escribir();
            Leer();
        }

        static void Escribir(){
            WriteLine("\nEscribiendo datos en un archivo en formato binario");
            BinaryWriter f0ps = new BinaryWriter(File.Open(ruta,FileMode.Create));
            f0ps.Write(1.25f);
            f0ps.Write(@"c:\Temp");
            f0ps.Write(10);
            f0ps.Write(true);
            f0ps.Close();
        }

        static void Leer(){
            float radio;
            string  folder;
            int periodo;
            bool estado;
            WriteLine("Leyendo datos del archivo binario {0}",ruta);
            BinaryReader f0ps = new BinaryReader(File.Open(ruta,FileMode.Create));
            radio = f0ps.ReadSingle();
            folder = f0ps.ReadString();
            periodo = f0ps.ReadInt32();
            estado = f0ps.ReadBoolean();
            WriteLine("\nRadio = {0}",radio);
            WriteLine("\nRuta = {0}",folder);
            WriteLine("\nPeriodo = {0}",periodo);
            WriteLine("\nEstado = {0}",estado);
            f0ps.Close();
        }
    }
}
