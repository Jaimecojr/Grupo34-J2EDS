using System;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Shared.Entity
{
    public class User
    {
        public int IdUser {get;set;}
        [Required]
        public string NameUser {get;set;}
        [Required]
        public string LastNameUser {get;set;}
        [Required]
        public GenderUser GenderUser {get;set;}
        [Required]
        public string PasswordUser {get;set;}
        [Required]
        public string EmailUser {get;set;}
        public Status StatusUser {get;set;}
        [Required]
        public String ImgUser {get;set;}
    }

    public enum GenderUser
    {
        Femenino = 0,
        Masculino = 1
    }

    public enum Status
    {
        Admin = 0,
        User = 1
    }
}