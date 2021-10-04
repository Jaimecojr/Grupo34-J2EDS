using System;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Shared.Entity
{
    public class Category
    {
        public int IdCategory {get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string NameCategory {get;set;}
        
    }
}