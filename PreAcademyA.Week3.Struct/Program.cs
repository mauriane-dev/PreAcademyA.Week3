using System;

namespace PreAcademyA.Week3.Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            CentroStruct cs = new CentroStruct(3, -2); // con construttore
            cs.X = 9;    // senza construtttore
            cs.Y = -4;   // senza construtttore

            Cerchio cerchio = new Cerchio();
            cerchio.Raggio = 5.34;
            cerchio.Centro = cs;

            Cerchio cerchio2 = new Cerchio(21.7, cs);
        }
    }
}
