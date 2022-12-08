using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace etickets.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }

        [Display(Name="Logo")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationship (One to many relatioship between cinema and movies)
        public List<Movie> Movies { get; set; }
    }
}
