using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Prova.Spotify.Entities
{
    abstract class MultimedialFile
    {
        public string Title { get; set; }
        public Author Author { get; set; }

        public MultimedialFile(string title, Author author)
        {
            Title = title;
            Author = author;
        }

        internal virtual string Print()
        {
            return $"{Title} - {Author.Print()}";
        }

        internal object PrintTitle()
        {
            return $"{Title}";
        }
    }
}
