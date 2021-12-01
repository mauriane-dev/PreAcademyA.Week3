using PreAcademyA.Week3.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Generics.DbManager
{
    class Figlio1DbManager : IDbManager<Figlio1>
    {
        static List<Figlio1> figli1 = new List<Figlio1>();

        public void Add(Figlio1 t)
        {
            figli1.Add(t);
        }

        public List<Figlio1> Fetch()
        {
            return figli1;
        }

        public void Remove(Figlio1 t)
        {
            figli1.Remove(t);
        }
    }
}
