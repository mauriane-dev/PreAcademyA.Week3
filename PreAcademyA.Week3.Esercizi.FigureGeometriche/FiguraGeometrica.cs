using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.FigureGeometriche
{
    public abstract class FiguraGeometrica : IFileManager
    {
        public string Nome { get; set; }
        //public double Perimetro { get; set; }
        //public double Area { get; set; }

        //public abstract void CalcolaPerimetro();
        //public abstract void CalcolaArea();

        public abstract double CalcolaPerimetro();
        public abstract double CalcolaArea();

        public abstract void DisegnaForma();

        public void ScriviSuFile(string fileName)
        {
            Console.WriteLine("Sto scrivendo....");
        }

        public void LeggiDaFile(string fileName)
        {
            Console.WriteLine("Sto leggendo....");
        }
    }
}
