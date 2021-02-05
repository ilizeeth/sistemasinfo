using System;

namespace _6.Pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            char tam,cub,don;;
            string[] ings;
            string tamaño,ingredientes="",cubierta,donde;
            

            Console.Clear();
            if(args.Length==0){ //Revisar que exitan parametros en la linea de comandos
                Menu();
                return 1;
            }
             //Elegir tamaño
            tam=char.Parse(args[0].ToUpper()); //Tomar el primer parametro
            if(tam=='P') tamaño="pequeña";
            else if (tam=='M') tamaño="Mediana";
            else tamaño="Grande";

             //Elegir Ingrediente
            ings=args[1].Split("+");//Separa los ingredientes en base al signo y toma el parametro 2
            foreach(string i in ings){
                switch(char.Parse(i.ToUpper())){
                    case 'E': ingredientes="Extraqueso"; break;
                    case 'C': ingredientes="Champiñones"; break;
                    case 'P': ingredientes="Piña"; break;
                }
            }

            //Tipo de Cubierta
            cub=char.Parse(args[2].ToUpper()); //Toma el tercer parametro
            cubierta=cub=='D' ? "Delgada" : "Gruesa";

            //Elegir donde comer
            don=char.Parse(args[2].ToUpper());
            donde=don=='A' ? "Aqui" :  "Llevar";
            

            //Resultado del pedido
            Console.WriteLine("Tu pizza quedo integrada de la siguiente manera: \n");
            Console.WriteLine("Tamaño: {0}",tamaño);
            Console.WriteLine("Ingredientes: {0}",ingredientes);
            Console.WriteLine("Cubierta: {0}",cubierta);
            Console.WriteLine("Donde: {0}",donde);
            return 0;
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("\nElige como deseas armar tu pedido de pizza\n");
            Console.WriteLine("Tamaño: (P)equeña (M)ediana (G)rande");
            Console.WriteLine("Ingredientes: (E)xtra queso, (C)hampiñones, (P)iña unidos por +" );
            Console.WriteLine("Cubierta: (D)elgada, (G)ruesa" );
            Console.WriteLine("Donde la comes: (A)qui, (L)levar");
        }
    }
}
