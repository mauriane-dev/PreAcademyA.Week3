using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.Libreria.Entities
{
    class LibroCartaceo : Libro
    {
        public int NumeroDiPagine { get; set; }
        public int QuantitaMagazzino { get; set; }

        public LibroCartaceo()
        {

        }
        public LibroCartaceo(double prezzo, string titolo, string autore, int numPagine, int qntMagazzino)
            : base(prezzo, titolo, autore)
        {
            NumeroDiPagine = numPagine;
            QuantitaMagazzino = qntMagazzino;
        }

        public override string Print()
        {
            return $"LibroCartaceo -> {base.Print()}, Numero di Pagine: {NumeroDiPagine}, Quantità in magazzino: {QuantitaMagazzino}";
        }
    }
}
