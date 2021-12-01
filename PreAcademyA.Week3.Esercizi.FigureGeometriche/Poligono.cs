using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.FigureGeometriche
{
    public abstract class Poligono: FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public override double CalcolaArea()
        {
            return Base * Altezza;
        }
    }
}
