using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Prova.Spotify.Entities
{
    class Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int YearBirth { get; set; }

        public Author(string name, string surname, int year)
        {
            Name = name;
            Surname = surname;
            YearBirth = year;
        }

        public string Print()
        {
            return $"Autore: {Name} - {Surname} - {YearBirth}";
        }
    }
}
