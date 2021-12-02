using System;
using System.Collections.Generic;
using System.Linq;

namespace PreAcademyA.Week3.Esercizi.Prodotti.Repository
{
    class RepositoryPAbbigliamento : IRepositoryManager<ProdottoAbbigliamento>
    {
        static List<ProdottoAbbigliamento> prodottiAbbigliamento = new List<ProdottoAbbigliamento>
        {
            new ProdottoAbbigliamento("AB01", 23.67, "Maglia a maniche corte", "Zara",TagliaEnum.S),
            new ProdottoAbbigliamento("AB02", 9.99, "Costume", "Zara", TagliaEnum.M),
            new ProdottoAbbigliamento("AB03", 50.24, "Cappotto", "Max Mara", TagliaEnum.M),
            new ProdottoAbbigliamento("AB04", 24.55, "Felpa", "Zara", TagliaEnum.L)
        };

        public List<ProdottoAbbigliamento> Fetch()
        {
            return prodottiAbbigliamento;
        }

        public List<ProdottoAbbigliamento> GetByPrice(double price)
        {
            return prodottiAbbigliamento.Where(pa => pa.Prezzo <= price).ToList();
        }

        internal List<ProdottoAbbigliamento> GetBySize(TagliaEnum taglia)
        {
            return prodottiAbbigliamento.Where(pa => pa.Taglia == taglia).ToList();
        }
    }
}
