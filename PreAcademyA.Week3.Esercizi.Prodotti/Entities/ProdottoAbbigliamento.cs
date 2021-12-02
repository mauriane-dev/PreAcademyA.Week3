using PreAcademyA.Week3.Esercizi.Prodotti.Entities;

namespace PreAcademyA.Week3.Esercizi.Prodotti
{
    class ProdottoAbbigliamento: Prodotto
    {
        public string Brand { get; set; }
        public TagliaEnum Taglia { get; set; }

        public ProdottoAbbigliamento(string codice, double prezzo, string descrizione, string brand, TagliaEnum taglia)
            : base(codice, prezzo, descrizione)
        {
            Brand = brand;
            Taglia = taglia;
        }

        public override string Print()
        {
            return $"{base.Print()} - {Brand} - {Taglia}";
        }
    }

    enum TagliaEnum
    {
        XS,
        S,
        M,
        L,
        XL
    }
}
