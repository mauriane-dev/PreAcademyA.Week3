namespace PreAcademyA.Week3.Esercizi.Prodotti.Entities
{
    abstract class Prodotto
    {
        public string Codice { get; set; }
        public double Prezzo { get; set; }
        public string Descrizione { get; set; }

        public Prodotto(string codice, double prezzo, string descrizione)
        {
            Codice = codice;
            Prezzo = prezzo;
            Descrizione = descrizione;
        }

        public virtual string Print()
        {
            return $"{Codice} - {Descrizione} - {Prezzo}";
        }
    }
}
