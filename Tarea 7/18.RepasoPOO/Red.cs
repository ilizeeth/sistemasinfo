using System;
using System.Collections.Generic;

public class Red{
    //constructor
    public Red(){Nodos = new List<Nodo>();}

    public Red(string empresa, string propietario, string domiclio) =>
      (Empresa,Propietario,Domicilio)=(empresa,propietario,domiclio);

    public string Empresa{get; set;}
    public string Propietario{get; set;}
    public string Domicilio{get; set;}
    public List<Nodo> Nodos{get; set;}

}