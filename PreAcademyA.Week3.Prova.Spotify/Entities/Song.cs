namespace PreAcademyA.Week3.Prova.Spotify.Entities
{
    class Song : MultimedialFile
    {
        public Genre Genre { get; set; }

        public Song(string title, Author author, Genre genre)
            : base(title, author)
        {
            Genre = genre;
        }

        internal override string Print()
        {
            return $"{base.Print()} - {Genre}";
        }
    }

    enum Genre
    {
        Pop,
        Rock,
        Classic,
    }
}
