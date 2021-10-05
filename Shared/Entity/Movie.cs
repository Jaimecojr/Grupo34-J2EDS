using System;
using System.Collections.Generic;
namespace Peliculas.Shared.Entity
{
    public class Movie
    {

        public string Titulo{get;set;}
        public string ID{get;set;}
        public double Duracion{get;set;}/* la duracion en minutos */
        
        public List<Category> Categorias{get;set;}
        public string Idioma{get;set;}
        public string OrigenPais{get;set;}
        public List<string> Actores{get;set;}
        public string Director{get;set;}
        public string Sinopsis{get;set;}
        public DateTime PublicationDate {get;set;}
        public string MovieImage {get;set;}

        public string convertDouble2S(){
            return Duracion.ToString("F2");
        }       
    }
}