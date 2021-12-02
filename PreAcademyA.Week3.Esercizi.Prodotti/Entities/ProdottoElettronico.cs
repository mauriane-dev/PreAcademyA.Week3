using PreAcademyA.Week3.Esercizi.Prodotti.Entities;

namespace PreAcademyA.Week3.Esercizi.Prodotti
{
    class ProdottoElettronico : Prodotto
    {
        public string Produttore { get; set; }
        public string Modello { get; set; }

        public ProdottoElettronico(string codice, double prezzo, string descrizione, string produttore, string modello)
           : base(codice, prezzo, descrizione)
        {
            Produttore = produttore;
            Modello = modello;
        }

        public override string Print()
        {
            return $"{base.Print()} - {Produttore} - {Modello}";
        }
    }
}
