using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace etickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerID { get; set; }

        [Display(Name="Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name ="Full Name")]
        public string FullName { get; set; }

        [Display(Name ="Biography")]
        public string Bio { get; set; }


        //Relationship (One to many relatioship between producer and movies)
        public List<Movie> Movies { get; set; }

    }
}


