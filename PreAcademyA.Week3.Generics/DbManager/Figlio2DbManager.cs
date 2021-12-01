using PreAcademyA.Week3.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Generics.DbManager
{
    class Figlio2DbManager : IDbManager<Figlio2>
    {
        static List<Figlio2> figli2 = new List<Figlio2>();
        public void Add(Figlio2 t)
        {
            figli2.Add(t);
        }

        public List<Figlio2> Fetch()
        {
            return figli2;
        }

        public void Remove(Figlio2 t)
        {
            figli2.Remove(t);
        }
    }
}
