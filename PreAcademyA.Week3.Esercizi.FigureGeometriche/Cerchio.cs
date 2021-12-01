using System;

namespace PreAcademyA.Week3.Esercizi.FigureGeometriche
{
    public class Cerchio : FiguraGeometrica
    {
        public double Raggio { get; set; }
        public CentroStruct Centro { get; set; }

        //public override void CalcolaArea()
        //{
        //    //Area = Raggio * Raggio * 3.14;
        //    Area = Math.Pow(Raggio, 2) * Math.PI;
        //}

        //public override void CalcolaPerimetro()
        //{
        //    Perimetro = 2 * Math.PI * Raggio;
        //}

        public override double CalcolaArea()
        {
            //Area = Raggio * Raggio * 3.14;
            return Math.Pow(Raggio, 2) * Math.PI;
        }

        public override double CalcolaPerimetro()
        {
            return 2 * Math.PI * Raggio;
        }

        public override void DisegnaForma()
        {
            Console.WriteLine($"{Nome} -> Raggio: {Raggio} - Centro : ({Centro.X} , {Centro.Y}) - " +
                $"Perimetro: {CalcolaPerimetro()} - Area : {CalcolaArea()}");
        }
    }

    public struct CentroStruct
    {
        public int X { get; set; }
        public int Y { get; set; }

        public CentroStruct(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
