using System;
using System.Collections.Generic;
using System.Linq;

namespace PreAcademyA.Week3.Esercizi.Prodotti.Repository
{
    class RepositoryPAlimentare : IRepositoryManager<ProdottoAlimentare>
    {
        static List<ProdottoAlimentare> prodottiAlimentari = new List<ProdottoAlimentare>() 
        {
            new ProdottoAlimentare("AL01", 3.50, "Gelato", new DateTime(2021, 12,31)),
            new ProdottoAlimentare("AL02", 1.99, "Jogurt", new DateTime(2021, 08,30))
        };

        public List<ProdottoAlimentare> Fetch()
        {
            return prodottiAlimentari;
        }

        public List<ProdottoAlimentare> GetByPrice(double price)
        {
            return prodottiAlimentari.Where(pa => pa.Prezzo <= price).ToList();
        }

        internal List<ProdottoAlimentare> GetByDate(DateTime dt)
        {
            return prodottiAlimentari.Where(pa => pa.DataScadenza >= dt).ToList();
        }
    }
}
