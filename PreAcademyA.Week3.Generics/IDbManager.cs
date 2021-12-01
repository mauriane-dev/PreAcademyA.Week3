using PreAcademyA.Week3.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Generics
{
    interface IDbManager<T>
    {
        public void Add(T t);
        public List<T> Fetch();
        public void Remove(T t);
    }
}
