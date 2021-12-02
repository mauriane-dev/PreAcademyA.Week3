using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.Libreria
{
    interface IDbManager<T>
    {
        public List<T> Fetch();
    }
}
