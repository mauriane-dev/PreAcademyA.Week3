using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.FigureGeometriche
{
    public class Triangolo : Poligono
    {
        public double Lato1 { get; set; }
        public double Lato2 { get; set; }

        public override double CalcolaArea()
        {
            return base.CalcolaArea() / 2;
        }

        public override double CalcolaPerimetro()
        {
            return Lato1 + Lato2 + Base;
        }

        public override void DisegnaForma()
        {
            Console.WriteLine($"{Nome} -> Base: {Base} - Altezza : {Altezza} - Lato1 : {Lato1} - Lato2: {Lato2}" +
                $"Perimetro: {CalcolaPerimetro()} - Area : {CalcolaArea()}");
        }
    }
}
