using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Prova.Spotify.Entities
{
    class Podcast: MultimedialFile
    {
        public string Description { get; set; }
        public List<Episode> Episodes { get; set; }

        public Podcast(string titolo, Author autore, string descrizione, List<Episode> episodi)
            : base(titolo, autore)
        {
            Description = descrizione;
            Episodes = episodi;
        }

        internal override string Print()
        {
            return $"{base.Print()} - {Description}";
        }

        internal string PrintTitle()
        {
            return $"{base.PrintTitle()}";
        }
    }
}
