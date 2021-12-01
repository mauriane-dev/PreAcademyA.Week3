using PreAcademyA.Week3.Generics.DbManager;
using PreAcademyA.Week3.Generics.Entities;
using System;

namespace PreAcademyA.Week3.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Padre p = new Padre();
            p.Id = 1;
            p.Nome = "Padre";

            PadreDbManager pdbM = new PadreDbManager();
            pdbM.Add(p);

            Figlio1 f1 = new Figlio1();
            f1.Id = 1;
            f1.Nome = "Figlio1";
            f1.Eta = 10;

            Figlio1DbManager f1dbM = new Figlio1DbManager();
            f1dbM.Add(f1);
        }
    }
}
