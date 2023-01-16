namespace EFCodeFirstNTierMapping.DATA
{
    public class ActorFilm : BaseEntity
    {
        public int WorkDays { get; set; }
        public int ActorID { get; set; }
        public int FilmID { get; set; }

        // Navigations Property

        public virtual Film FilmOfActor { get; set; }
        public virtual Actor ActorOfFilm { get; set; }
    }
}