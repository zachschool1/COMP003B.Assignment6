namespace COMP003B.Assignment6.Models
{
    public class MovieActor
    {
        public int Id { get; set; }
        public int ActorId { get; set; }

        public int MoviesId { get; set; }

        public virtual Actor? Actor { get; set; }
        public virtual Movies? Movies { get; set; } 


    }
}
