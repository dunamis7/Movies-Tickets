using System.ComponentModel.DataAnnotations.Schema;

namespace etickets.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; } // Acts as the foregin key connecting the movie model
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; } 
        

        public int ActorId { get; set; } // Acts as the foregin key connecting the Actor model
        [ForeignKey("ActorId")]
        public Actor Actor { get; set; }
    }
}
