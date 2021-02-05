using System;

namespace _5.Ciclos
{
    class Program
    {
        static int Main(string[] args)
        {
            int op,suma=0,c=0;
            Console.Clear();
            if(args.Length==0) { // verifica que se hayan pasado argumentos de linea de comando
                menu();
                return 1;
            }

            op = int.Parse( args[0]);            
            switch (op)
            {   
                case 1: //Num 1 al 100 while
                {
                    c=1;suma=0;
                    while(c<=100){
                        Console.Write("{0} ",c);
                        suma+=c;
                        c++;
                    } 
                    Console.WriteLine("\nLa suma es {0}",suma);
                }break;

                case 2: //100 - 1 do-while
                {
                    c=100;suma=0;
                    do{
                        Console.Write("{0} ",c);
                        suma+=c;
                        c--;
                    }while(c>=1);
                    Console.WriteLine("\nLa suma es {0}",suma);
                }break;

                case 3: 
                {   suma = 0;
                    for(c=500; c<=200;c++){
                        Console.Write("{0} ",c);
                    }
                    Console.WriteLine("\nLa suma es {0}",suma);
                } break;
                
                case 4: { //Num del 2 al 100 en pares con for
                    suma= 0;
                    for(c=2; c<=100;c+=2){
                        Console.Write("{0} ",c);
                    }
                    Console.WriteLine("\nLa suma es {0}",suma);
                }break;

                case 5: //Num del 99 al 1 impares for
                {
                    suma =0;
                      for(c=99; c>=1; c-=2) {
                        Console.Write($"{c} ");
                        suma+=c;
                    }
                    Console.WriteLine($"\n La suma es {suma}");
                } break;

                case 6: { // numeros 272 al 40 decrementos de 4 con do .. while
                    c=272; suma=0;
                    while(c>=40)
                    {
                        Console.Write($"{c} ");
                        suma+=c;
                        c-=4;
                    }
                    Console.WriteLine($"\n La suma es {suma}");
                }
                break;
                default: {Console.WriteLine("Opcion implementada");} break;
            }

            return 0;
        }

        static void menu(){
            Console.Clear();
            Console.WriteLine("[1] Numeros del 1 al 100 usando ciclo while");
            Console.WriteLine("[2] Numeros del 100 al 1 usando ciclo do-while");
            Console.WriteLine("[3] Numeros del 50 al 200 usando ciclo for");
            Console.WriteLine("[4] Numeros del 2 al 200 (solo pares) usando ciclo for");
            Console.WriteLine("[5] Numeros del 99 al 1 usando ciclo for");
            Console.WriteLine("[6] Numeros del 272al 40  decrementos de 4 usando ciclo while");
        }
    }
}
