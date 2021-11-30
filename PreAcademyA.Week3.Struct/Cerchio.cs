using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Struct
{
    /// <summary>
    /// Scrivere una classe che descriva un cerchio
    /// Un cerchio ha raggio, coordinata X del centro e coordinata Y del centro
    /// Scrivere un metodo che ne calcoli la circonferenza
    /// </summary>
    class Cerchio
    {
        public double Raggio { get; set; }
        //public int CoordinataX { get; set; }
        //public int CoordinataY { get; set; }
        public CentroStruct Centro { get; set; }

        public Cerchio()
        {

        }
        public Cerchio(double raggio, CentroStruct cs)
        {
            Raggio = raggio;
            Centro = cs;
        }

        public double CalcolaCirconferenza()
        {
            double circonferenza = 2 * Raggio * Math.PI;
            return circonferenza;
        }
    }
    internal struct CentroStruct
    {
        public int X;
        public int Y;
        public CentroStruct(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
