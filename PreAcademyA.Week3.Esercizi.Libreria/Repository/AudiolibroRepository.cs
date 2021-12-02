using PreAcademyA.Week3.Esercizi.Libreria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.Libreria.Repository
{
    class AudiolibroRepository : IDbManager<Audiolibro>
    {
        static List<Audiolibro> audiolibri = new List<Audiolibro>()
        {
            new Audiolibro(32.7, "La Divina Commedia", "Dante Alighieri", new Durata(5, 32, 04)),
            new Audiolibro(28.5, "La coscienza di Zeno", "Itali Svevo", new Durata(4, 48, 56)),
            new Audiolibro(12.9, "Iliade", "Omero", new Durata(0, 32, 32))
        };
        public List<Audiolibro> Fetch()
        {
            return audiolibri;
        }

        internal bool Exists(Audiolibro al)
        {
            bool esisteAudiolibro = audiolibri.Contains(al);
            return esisteAudiolibro;
        }

        internal void Add(Audiolibro al)
        {
            audiolibri.Add(al);
        }

        internal List<Audiolibro> GetByDurata(Durata d)
        {
            List<Audiolibro> audiolibriDurata = new List<Audiolibro>();
            foreach(var al in audiolibri)
            {
                if(al.Durata.Ore < d.Ore)
                {
                    audiolibriDurata.Add(al);
                }
                else if(al.Durata.Ore == d.Ore)
                {
                    if (al.Durata.Minuti < d.Minuti)
                    {
                        audiolibriDurata.Add(al);
                    }
                    else if (al.Durata.Minuti == d.Minuti)
                    {
                        if (al.Durata.Secondi <= d.Secondi)
                        {
                            audiolibriDurata.Add(al);
                        }
                    }
                }
            }
            return audiolibriDurata;
        }
    }
}
