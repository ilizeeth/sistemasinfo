using System;
using static System.Console;
using System.IO;
using static System.IO.Path;
using static System.IO.Directory;
using static System.Environment;

namespace _30.Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
           WriteLine("Trabajando con informacion del sistema,archivos y rutas");
           //SistemaArchivos();
           //UnidadesDisco();
           //Directorios();
           Archivos();
        }

        static void Archivos(){
            WriteLine("\nTrabajando con archivos");
            var dir=Combine(GetCurrentDirectory(),"datos","archivo");
            string arcTexto = Combine(dir,"notas.txt");
            string archrespaldo = Combine(dir,"notas.bak");

            //Revisar si existe la ruta donde estaran los archivos
            if(!Exists(dir))
                CreateDirectory(dir);
            //Revisar si existe el archivo de texto
            WriteLine($"Existe el archivo de texto ? {File.Exists(arcTexto)}");
            //Crear un archivo de texto y escribir una linea en el
            WriteLine("Creando un archivo de texto ...");
            StreamWriter txt = File.CreateText(arcTexto);
            txt.WriteLine("Saludos desde un archivo creado en C#");
            txt.Close();
            WriteLine($"Existe el archivo de texto ? {File.Exists(arcTexto)}");

            //Crear una copia del archivo original
            WriteLine("Creando una copia del archivo de texto...");
            File.Copy(sourceFileName:arcTexto,destFileName:archrespaldo,overwrite:true);
            WriteLine($"Existe el archivo de respaldo ? {File.Exists(archrespaldo)}");

            //Borrar archivo de respaldo
            File.Delete(archrespaldo);
            WriteLine($"Existe el archivo de respaldo ? {File.Exists(archrespaldo)}");

            //Leer archivo de texto
            WriteLine($"Leyendo contenido del archivo de texto: {GetFileName(arcTexto)}");
            StreamReader res = File.OpenText(arcTexto);
            WriteLine(res.ReadToEnd());
            res.Close();

            //Informacion del arhivo
            var info = new FileInfo(arcTexto);
            WriteLine("\nInformacion sobre un archivo existente ");
            WriteLine($"El archivo {arcTexto}");
            WriteLine($"Nombre del archivo: {GetFileName(arcTexto)}, Extension:{GetExtension(arcTexto)}");
            WriteLine($"Contiene{info.Length} bytes");
            WriteLine($"Ultima vez que se accedio: {info.LastAccessTime}");
            WriteLine($"Es de solo lectura ? {info.IsReadOnly}");
            WriteLine($"Fecha de creacion: {info.CreationTime}");

            //Cambiar nombre al archivo
            WriteLine("Cambiando el nombre del archivo");
            string nvoNombre = Combine(GetCurrentDirectory(),"apuntes.doc");
            WriteLine($"Existe el archivo renombrado? {File.Exists(nvoNombre)}");
        }
        static void Directorios(){
            WriteLine("\nTrabajando con Directorios");
            var nvaCarpeta = Combine(GetCurrentDirectory(),"datos","codigofuente");
            WriteLine($"Trabajando con: {nvaCarpeta}");
            //Revisar si existe
            WriteLine($"El directorio ya existe ? {Exists(nvaCarpeta)}");
            //Creando directorio
            WriteLine("Creando directorio --");
            CreateDirectory(nvaCarpeta);
            WriteLine($"El directorio ya existe ? {Exists(nvaCarpeta)}");
            WriteLine("Confirma que el directorio existe, luego presiona <ENTER>");
            ReadLine();
            //Borrar directorio
            WriteLine("Borrando el directorio y su contenido ...");
            Delete(nvaCarpeta,recursive:true);
            
        }

        static void UnidadesDisco(){
            WriteLine("Trabajando con unidades de disco logicas");
            WriteLine("\n");
            WriteLine("|{0,-30}|{1,-10}|{2,-7}|{3,18}| {4,18}|","Nombre","Tipo","Formato","Tamaño","Espacio Libre");
            foreach(DriveInfo drive in DriveInfo.GetDrives()){
                if(drive.IsReady){
                WriteLine("{0,-30} {1,-10} {2,-7} {3,18:N0} {4,18:N0}",drive.Name,drive.DriveType,drive.DriveFormat,drive.TotalSize);
                }else{
                     WriteLine("{0,-30} {1,-10} ",drive.Name,drive.DriveType);
                }
            }
        }
        
        static void SistemaArchivos(){
            WriteLine("\nInformacion del Sistema de Archivos");
            WriteLine("{0,-33} {1}","Separado de ruta:",PathSeparator);
            WriteLine("{0,-33} {1}", "Separado de  directorios:",DirectorySeparatorChar);
            WriteLine("{0,-33} {1}", "Directorio actual:",GetCurrentDirectory());
            WriteLine("{0,-33} {1}", "Directorio del sistema:",SystemDirectory);
            WriteLine("{0,-33} {1}", "Directorio temporal:",GetTempPath());
            WriteLine("{0,-33} {1}", "Directorio del sistema:",GetFolderPath(SpecialFolder.System));
            WriteLine("{0,-33} {1}","Directorio de Mis Documentos",GetFolderPath(SpecialFolder.MyDocuments));
            WriteLine("{0,-33} {1}","Directorio de aplicacion",GetFolderPath(SpecialFolder.ApplicationData));
            WriteLine("{0,-33} {1}","Directorio personal",GetFolderPath(SpecialFolder.Personal));

        }
    }
}
