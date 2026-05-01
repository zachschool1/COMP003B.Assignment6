using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Movies
    {
        public int MoviesId { get; set; }

        [Required]
        public string Title { get; set; }

        public virtual ICollection<MovieActor>? MovieActor { get; set; }

    }
}
