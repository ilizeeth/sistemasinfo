using System;

namespace _14.Estadisticas
{
    class Funciones
    {
        public static double May(double[] v){
            double n=v[0];
            for(int i=0;i<v.Length;i++){
                if(v[i]>n) n=v[i];
            }
            return n;
        }
        public static double Men(double[] v){
            double n=v[0];
            for(int i=0;i<v.Length;i++){
                if(v[i]<n) n=v[i];
            }
            return n;
        }

        public static double Prom(double[] v){
            double n=0;
            for(int i=0;i<v.Length;i++){
                n+=v[i];
            }
            return n/v.Length;
        }

        public static double Var(double[] v,double p){
            double n=0;
            for(int i=0;i<v.Length;i++){
                n+=Math.Pow(v[i]-p,2);
            }
            return n/v.Length;
        }
    }
}