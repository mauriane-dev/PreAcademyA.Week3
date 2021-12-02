using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.Prodotti
{
    interface IRepositoryManager<T>
    {
        public List<T> Fetch();
        public List<T> GetByPrice(double price);
    }
}
