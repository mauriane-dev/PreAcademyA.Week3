using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.Prodotti.Repository
{
    class RepositoryPAlimentare : IRepositoryManager<ProdottoAlimentare>
    {
        static List<ProdottoAlimentare> prodottiAlimentari = new List<ProdottoAlimentare>() { };

        public List<ProdottoAlimentare> Fetch()
        {
            throw new NotImplementedException();
        }

        public List<ProdottoAlimentare> GetByPrice(double price)
        {
            throw new NotImplementedException();
        }

        public List<ProdottoAlimentare> GetByDataDiScadenza(DateTime dt)
        {
            throw new NotImplementedException();
        }
    }
}
