using PreAcademyA.Week3.Esercizi.Prodotti.Entities;
using System;

namespace PreAcademyA.Week3.Esercizi.Prodotti
{
    class ProdottoAlimentare: Prodotto
    {
        public DateTime DataScadenza { get; set; }

        public ProdottoAlimentare(string codice, double prezzo, string descrizione, DateTime dataScadenza)
            : base(codice, prezzo, descrizione)
        {
            DataScadenza = dataScadenza;
        }

        public override string Print()
        {
            return $"{base.Print()} - {DataScadenza.ToShortDateString()}";
        }
    }
}
