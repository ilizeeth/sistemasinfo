using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.IO;

Escuela miescuela =null;
string ruta = Path.Combine(Environment.CurrentDirectory,"datosescuela");

Inicializa(ref miescuela);
//Reporte(miescuela);
//xmlSerializa(miescuela);
jsonSerializa(miescuela);
//Utilerias.reporteProfes(miescuela);
//Utilerias.ReportEstudiante(miescuela);

void xmlSerializa(Escuela escuela){
    WriteLine("\nSerializando datos en formato xml...");
    Utilerias.xmlGraba(ruta,escuela);

    Escuela otraescuela = new Escuela();
    WriteLine("\n Cargando datos del archivo {0}",ruta);
    Utilerias.xmlLeer(ruta,ref otraescuela);
    Reporte(otraescuela);
}

void jsonSerializa(Escuela escuela){
    WriteLine("\nSerializando datos en formato json...");
    Utilerias.jsonGraba(ruta,escuela);

    Escuela otraescuela = new Escuela();
    WriteLine("\nCargando datos del archivo {0}",ruta);
    Utilerias.jsonLeer(ruta,ref otraescuela);
    Reporte(otraescuela);
}



void Inicializa(ref Escuela e){
    e= new Escuela(){Nombre="Universidad Patito SA de CV", Encargado="Ing. Juan Perez",Domicilio="Av. De la Juventud 348"};

    //Agregar profesores a la escuela

    e.Profes.Add(new Profesor{Nombre="Jose Diaz", Fechaing=DateTime.Parse("01/01/2018"),Grupo="1A",Materia="Fisica",Salario=1200});
    e.Profes.Add(new Profesor{Nombre="Maria Perez", Fechaing=DateTime.Parse("10/02/2016"),Grupo="2A",Materia="Algebra",Salario=3400});
    e.Profes.Add(new Profesor{Nombre="Claudia Sid", Fechaing=DateTime.Parse("01/04/2019"),Grupo="4B",Materia="Calculo",Salario=3800});
    e.Profes.Add(new Profesor{Nombre="Carlos Lopez", Fechaing=DateTime.Parse("10/03/2016"),Grupo="8A",Materia="Quimica",Salario=1000});

    //Agregar Alumnos a profesores
    e.Profes[0].Alumnos.Add(
        new Alumno{
            Nombre="Fatima Soto", 
            Edad=23, 
            Fechaing=DateTime.Parse("01/01/2019"),
            Becado=1,
            Calificaciones = new int[] {7,7,7}});
     e.Profes[0].Alumnos.Add(
        new Alumno{
            Nombre="Damian Díaz", 
            Edad=25, 
            Fechaing=DateTime.Parse("01/01/2016"),
            Becado=0,
            Calificaciones = new int[] {8,8,8}});
     e.Profes[0].Alumnos.Add(
        new Alumno{
            Nombre="Fatima Soto", 
            Edad=23, 
            Fechaing=DateTime.Parse("01/01/2018"),
            Becado=1,
            Calificaciones = new int[] {6,6,6}});
    
     e.Profes[1].Alumnos.Add(
        new Alumno{
            Nombre="Maria Ochoa", 
            Edad=20, 
            Fechaing=DateTime.Parse("01/10/2018"),
            Becado=1,
            Calificaciones = new int[] {9,9,9}});
    e.Profes[1].Alumnos.Add(
        new Alumno{
            Nombre="Carlos Díaz", 
            Edad=23, 
            Fechaing=DateTime.Parse("01/10/2018"),
            Becado=0,
            Calificaciones = new int[] {8,8,8}});

    e.Profes[3].Alumnos.Add(
        new Alumno{
            Nombre="Jose Ochoa", 
            Edad=19, 
            Fechaing=DateTime.Parse("01/10/2016"),
            Becado=0,
            Calificaciones = new int[] {6,6,6}});
}

void Reporte(Escuela e){
    Console.WriteLine(">> Datos Generales de la Escuela:\n");
    Console.WriteLine($"Nombre: {e.Nombre}");
    Console.WriteLine($"Encargado: {e.Encargado}");
    Console.WriteLine($"Domicilio: {e.Domicilio}");

     Console.WriteLine($"\nTotal Profesores: {e.Profes.Count}");
     Console.WriteLine($"Total alumnos: {e.TotAlum()}");
     //Console.WriteLine($"Total alumnos becados: {e.TotBec()}");
     Console.WriteLine($"Total salario profesores: ${e.TotSal()}");

    Console.WriteLine("\n>>Datos Generales de los Profesores:\n");
    e.Profes.ForEach(n=>Console.WriteLine(n.ToString()));
    Console.WriteLine($"\nMayor Salario: {e.MaySal()}");
    Console.WriteLine($"Menor Salario: {e.MenSal()}");

    Console.WriteLine("\n>> Alumnos por Profesor:\n");
    foreach(Profesor n in e.Profes){
        Console.WriteLine($"\n >Nombre: {n.Nombre}, Grupo: {n.Grupo}");
        n.Alumnos.ForEach(v=>Console.WriteLine(v.ToString()));
        //Console.WriteLine($"Mayor Promedio:{e.MayProm()}");
        
    }

    
}