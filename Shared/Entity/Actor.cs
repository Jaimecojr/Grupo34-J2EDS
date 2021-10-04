using System;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Shared.Entity
{
    public class Actor
    {
        public int ActorId {get;set;}
        [Required]
        public string ActorName {get;set;}
        [Required]
        public Gender Gender {get;set;}
        [Required]
        public DateTime BirthDate {get;set;}
        [Required]
        public string Bio {get;set;}
        [Required]
        public string ActorImg {get;set;}
    }

    public enum Gender
    {
        Femenino = 0,
        Masculino = 1
    }
}