using System;
using Peliculas.Shared.Entity;
using System.Collections.Generic;
namespace Peliculas.Client.Services
{
    public class ServiceMovie:IServiceMovie
    {
        public List<Movie> PeliculasGuardadas = new List<Movie>();
        public void AddMovie(Movie nuevaMovie)
        {
            PeliculasGuardadas.Add(nuevaMovie);
        }

        public List<Movie> GetMovies(){
            PeliculasGuardadas.Add(new Movie(){Titulo = "Ganas no me faltan", ID= "1", Duracion=80.2, Categorias =new List<Category>(){new Category(){IdCategory=1, NameCategory="Aventuras"}, new Category(){IdCategory=1, NameCategory="Aventuras"}}, Idioma="Español", OrigenPais="Colombia", Actores=new List<string>(){"Juan Hernandez","Tito Babuino"}, Director="Guillermo", PublicationDate = new DateTime(2021,09,12)});
            PeliculasGuardadas.Add(new Movie(){Titulo = "Las vegas", ID= "2", Duracion=90.1, Categorias =new List<Category>(){new Category(){IdCategory=1, NameCategory="Aventuras"}, new Category(){IdCategory=1, NameCategory="Aventuras"}}, Idioma="Ruso", OrigenPais="Ecuador", Actores=new List<string>(){"Tino Asprilla","Adam Sandler"}, Director="Robert", PublicationDate = new DateTime(2021,02,11)});
            PeliculasGuardadas.Add(new Movie(){Titulo = "Navidad en hawai", ID= "3", Duracion=67.2, Categorias =new List<Category>(){new Category(){IdCategory=1, NameCategory="Aventuras"}, new Category(){IdCategory=1, NameCategory="Aventuras"}}, Idioma="Japones", OrigenPais="Japon", Actores=new List<string>(){"Laura Plank","Obito Uchiha"}, Director="Cristina", PublicationDate = new DateTime(2021,03,13)});
            return PeliculasGuardadas;
            
        }
    }
}