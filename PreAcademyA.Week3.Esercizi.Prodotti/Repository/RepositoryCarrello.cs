using PreAcademyA.Week3.Esercizi.Prodotti.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.Prodotti.Repository
{
    class RepositoryCarrello
    {
        static List<Prodotto> prodotti = new List<Prodotto>();

        public void Add(Prodotto p)
        {
            prodotti.Add(p);
        }

        internal List<Prodotto> Fetch()
        {
            return prodotti;
        }
    }
}
