using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace etickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Profile Picture")] //Using annotations to display things to the user
        [Required(ErrorMessage = "Profile picture is required")]
        public string ProfilePictureURL { get; set; }


        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Fullname is required")]
        [StringLength(50,MinimumLength =7, ErrorMessage ="Fullname must be between 7 and 50 characters")]
        public string FullName { get; set; }

        [Display(Name ="Biography")]
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
