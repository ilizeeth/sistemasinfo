using System;
using System.Collections.Generic;

public class Profesor{

    public Profesor(){Alumnos = new List<Alumno>();}

    public Profesor(string nombre, DateTime fechaing,string grupo,string materia,int salario) =>
        (nombre,fechaing,grupo,materia,salario)=(Nombre,Fechaing,Grupo,Materia,Salario);

    public string Nombre{get; set;}    
    public DateTime Fechaing{get; set;}    
    public string Grupo{get; set;}    
    public string Materia{get; set;}    
    public int Salario{get; set;}
    public List<Alumno> Alumnos {get; set;}
    public int Antiguedad() => DateTime.Now.Year-Fechaing.Year;

      

  

    public override string ToString() =>
       $"Nombre: {Nombre,-10}    FechaIng: {Fechaing.ToString("dd/mm/yy"),-12} Grupo: {Grupo,-3}   Materia: {Materia,-3}   Salario: {Salario.ToString(),-8} Alumnos: {Alumnos.Count.ToString(),-3}  Antiguedad:{Antiguedad().ToString(),-3} ";
}