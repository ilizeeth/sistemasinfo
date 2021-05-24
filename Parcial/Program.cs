using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using static System.Console;
using System.Text.RegularExpressions;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            string Url="https://es.pdfdrive.com/";
            
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(Url);

            int bookID=0;
            List <Libro> libros = new List<Libro>();
            List <Datos> data = new List<Datos>();
           DataContext db = new DataContext();

           //Categorias
            var ListaC = doc.DocumentNode.SelectNodes("//div[@class='categories-list']//a[@href]").Select(a=>a.Attributes["href"].Value);
            foreach(var l in ListaC){
                string site =Url;
                site+=l.ToString();
                doc = web.Load(site);
            }
             string Categories = doc.DocumentNode.SelectSingleNode("//div[@class='collection-title']").InnerText;
             var  title = doc.DocumentNode.SelectNodes("//div[@class='file-right']/a/h2");

             if(title is not null){
                var Books = doc.DocumentNode.SelectNodes("//div[@class='file-right']//a[@href]");

                foreach(var l in Books){
                Libro book = new Libro();
                Datos datos = new Datos();
                string site = Url+l.Attributes["href"].Value;
                doc = web.Load(site);
                bookID++; 

                //Scrapeando para la tabla de libros
                 //Obtener el Id de los libros 
                book.LibroID=bookID;
                //Obtener el titulo de los libros
                book.Titulo = doc.DocumentNode.SelectSingleNode("//div[@class='ebook-right-inner']/h1").InnerText;
                //Obetener el año de publicacipn
                book.Año=  doc.DocumentNode.SelectSingleNode("//div[@class='ebook-file-info']/span[3]").InnerText;
                book.Categoria = Categories;        

                
                //Scraping Datos
                
                //ID datos
                datos.DatosID=bookID;
                //Autor
                string autor = "";
                var Autor =doc.DocumentNode.SelectNodes("//div[@class='ebook-author']/a/span");
                if(Autor is not null){
                    foreach(var a in Autor){
                        autor+=(a.InnerText+" ");
                    }
                    datos.Autor=autor;
                }else
                    datos.Autor="No se encontro autor";
                //URL del libro
                var urlbook = doc.DocumentNode.SelectNodes("//div[@class='ebook-left']/a[@href]").Select(a=>a.Attributes["href"].Value);
                foreach(var e in urlbook){
                    datos.UrlLibro=("https://es.pdfdrive.com"+e.ToString());
                }

                libros.Add(book);
                data.Add(datos);

                }
                
             }
             //Vaciar la info en la base de datos
            foreach(var l in libros){
                db.Add(l);
            }
            foreach(var l in data){
                db.Add(l);
            }
            WriteLine("Creando base de datos");
            db.SaveChanges();

            //Consultas

            WriteLine("\n\n\n");

            WriteLine("1. Obtener todos los libros");
            var total = db .libros.ToList();
            total.ForEach(a=>WriteLine(a.ToString()));
            WriteLine($"\nTotal: {total.Count}");

            WriteLine("\n2.Libros con inicial L");
            var ini=db.libros.Where(i=>i.Titulo.StartsWith("L")).ToList();
            ini.ForEach(i=>WriteLine(i.ToString()));
            WriteLine($"\nLibros con inicial L: {ini}");

            WriteLine("3. Obtener los libros con año de publicación 2010");
            var year = db.libros.Where(i=>i.Año.Equals("2010")).ToList();
            year.ForEach(i=>WriteLine(i.ToString()));
            WriteLine($"\nLibros con año de publicacion 2010: {year}");

            WriteLine("4.Obtener todos los autores");
            var Autores = db.data.ToList();
            Autores.ForEach(a=>WriteLine(a.ToString()));
            WriteLine($"\nTotal:{Autores.Count}");

            
        }

        
        
    }
}
