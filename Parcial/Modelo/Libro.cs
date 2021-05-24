namespace Parcial
{
    class Libro
    {
        public int LibroID{get; set;}
        public string Titulo{get; set;}
        public string Año{get; set;}
        public string Categoria{get; set;}

        public override string ToString()=>$"ID:{LibroID}\nTitulo:{Titulo}\nAño:{Año}\nCategoria:{Categoria}";
    }
}