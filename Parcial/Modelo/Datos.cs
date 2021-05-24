
namespace Parcial
{
    class Datos 
    {   
        public int DatosID{get;set;}
        public string UrlLibro{get; set;}
        public string Autor{get; set;}

        public  override string ToString()=>$"ID:{DatosID}\nUrlLibro{UrlLibro}\nAutor{Autor}";
    }
}