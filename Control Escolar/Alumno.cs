using System;
using System.Collections.Generic;

public class Alumno: IFormattable{

    public Alumno(){ Calificaciones = new  int [3];}

    public Alumno(string nombre, int edad, DateTime fechaing, int becado , int [] calificaciones)=>
        (nombre, edad, fechaing,becado,calificaciones)=(Nombre,Edad,Fechaing,Becado,Calificaciones);

    public string Nombre{get; set;}
    public int Edad{get; set;}
    public DateTime Fechaing{get; set;}
    public int Becado{get; set;}
    public int [] Calificaciones{get; set;}

    public int Antiguedad() => DateTime.Now.Year-Fechaing.Year;

    public static int Prom(int[] v){
        int n=0;
        for(int i=0;i<v.Length;i++){
            n+=v[i];
            
        }
        return n/v.Length;
        
    }

    


    


    public override string ToString() =>
       $"Nombre: {Nombre,-12} Edad: {Edad,-3} Fechaing{Fechaing.ToString("dd/mm/yy"),-3} Becado: {Becado,-3} Califs: {Calificaciones + string.Join(",",Calificaciones)} Antiguedad: {Antiguedad().ToString()} Prom:{Prom(Calificaciones),-3}  Mensaje:";

    public string ToString(string formato, IFormatProvider proveedor){
        switch(formato){
            case "D1":
             return  $"Nombre: {Nombre,-12}  Fechaing{Fechaing.ToString("dd/mm/yy"),-3} Califs: {Calificaciones + string.Join(",",Calificaciones)}  Prom:{Prom(Calificaciones),-3}";
            case "D2": 
             return   $"Nombre: {Nombre,-12} Edad: {Edad,-3}  Becado: {Becado,-3} ";
            default: return  "";
        }
    } 
}