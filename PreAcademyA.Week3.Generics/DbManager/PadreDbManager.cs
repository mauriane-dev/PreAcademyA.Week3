using PreAcademyA.Week3.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Generics.DbManager
{
    class PadreDbManager: IDbManager<Padre>
    {
        static List<Padre> padri = new List<Padre>();

        public void Add(Padre t)
        {
            padri.Add(t);
        }

        public List<Padre> Fetch()
        {
            return padri;
        }

        public void Remove(Padre t)
        {
            padri.Remove(t);
        }
    }
}
