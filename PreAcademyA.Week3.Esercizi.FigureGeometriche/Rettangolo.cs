using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.FigureGeometriche
{
    public class Rettangolo : Poligono
    {
        public override double CalcolaPerimetro()
        {
            return (Base + Altezza) * 2;
        }

        public override void DisegnaForma()
        {
            Console.WriteLine($"{Nome} -> Base: {Base} - Altezza : {Altezza} - " +
               $"Perimetro: {CalcolaPerimetro()} - Area : {CalcolaArea()}");
        }
    }
}
