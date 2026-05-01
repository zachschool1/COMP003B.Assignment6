using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual ICollection<MovieActor> MovieActor { get; set; }
    }
}
