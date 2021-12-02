using System.Collections.Generic;

namespace PreAcademyA.Week3.Esercizi.Prodotti
{
    interface IRepositoryManager<T>
    {
        public List<T> Fetch();
        public List<T> GetByPrice(double price);
    }
}
