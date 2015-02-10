using System;
using System.ComponentModel.DataAnnotations;

namespace Source
{
    public partial class User
    {
        [Required]
        public int UserId { get; set;}
        [Required]
        public string Name { get; set;}
        [Required]
        public string Username { get; set;}
        [Required]
        public int TimesLoggedIn { get; set;}
        [Required]
        public DateTime DateCreatedUtc { get; set;}
        public DateTime? LastLoggedInUtc { get; set;}
        public Pet FavouritePet { get; set;}
    }

    public partial class Pet
    {
        [Required]
        public int PetId { get; set;}
        [Required]
        public string Name { get; set;}
    }
}