using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Bio is required")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }

    }
}
