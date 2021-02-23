using System;
using System.Collections.Generic;

    Red mired=null;
    
    Inicializa(ref mired);
    Reporte(mired);

    void Inicializa(ref Red r){
        r = new Red(){Empresa="Red Patito",Propietario="Mr. Pato",Domicilio="Av. Guerrero 123, Zacatecas"};
        r.Nodos.Add(new Nodo{Ip="192.168.0.10",Tipo="Servidor",Puertos=5,Saltos=10,So="Linux"});
        r.Nodos.Add(new Nodo{Ip="192.168.0.12",Tipo="Equipo activo",Puertos=2,Saltos=12,So="ios"});
        r.Nodos.Add(new Nodo{Ip="192.168.0.20",Tipo="Computadora",Puertos=8,Saltos=5,So="Windows"});
        r.Nodos.Add(new Nodo{Ip="192.168.0.15",Tipo="Servidor",Puertos=10,Saltos=22,So="Linux"});

    }

    void Reporte(Red r){
        Console.WriteLine("Empresa de seguridad en redes SA de CV\n");
        Console.WriteLine("Datos generales de la red:\n");
        Console.WriteLine($"Empresa: {r.Empresa}");
        Console.WriteLine($"Propietario: {r.Propietario}");
        Console.WriteLine($"Domicilio: {r.Domicilio}");

        Console.WriteLine("\nDatos generales de los nodos: \n");
        r.Nodos.ForEach(n=>Console.WriteLine(n.ToString()));

    }
        