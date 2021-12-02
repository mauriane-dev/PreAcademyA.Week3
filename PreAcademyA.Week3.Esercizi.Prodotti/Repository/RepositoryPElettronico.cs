using System;
using System.Collections.Generic;
using System.Linq;

namespace PreAcademyA.Week3.Esercizi.Prodotti.Repository
{
    class RepositoryPElettronico : IRepositoryManager<ProdottoElettronico>
    {
        static List<ProdottoElettronico> prodottiElettronici = new List<ProdottoElettronico>
        {
            new ProdottoElettronico("EL01", 200, "Cuffie", "Samsung", "Cuffiette"),
            new ProdottoElettronico("EL02", 899.99, "Cellulare", "Samsung", "Cellulare")
        };
        public List<ProdottoElettronico> Fetch()
        {
            return prodottiElettronici;
        }

        public List<ProdottoElettronico> GetByPrice(double price)
        {
            return prodottiElettronici.Where(pa => pa.Prezzo <= price).ToList();
        }

        public List<ProdottoElettronico> GetByMarca(string marca)
        {
            return prodottiElettronici.Where(pa => pa.Produttore == marca).ToList();
        }
    }
}
