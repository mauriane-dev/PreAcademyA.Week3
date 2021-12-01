using System;
using static PreAcademyA.Week3.Esercizi.EsamiUniversitari.DichiarazioneIndirizziCorsi;

namespace PreAcademyA.Week3.Esercizi.EsamiUniversitari
{
    class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoNascita { get; set; }
        public Immatricolazione Immatricolazione { get; set; }
        public bool RichiestaLaurea { get; set; }

        public Studente()
        {

        }
        public Studente(string nome, string cognome, int annoDiNascita, IndirizziDiLaurea indirizzoScelto)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoNascita = annoDiNascita;
            Immatricolazione = new Immatricolazione(DateTime.Now, indirizzoScelto);
        }
        public Studente(string nome, string cognome, int annoDiNascita, DateTime dt, IndirizziDiLaurea indirizzoScelto)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoNascita = annoDiNascita;
            Immatricolazione = new Immatricolazione(dt, indirizzoScelto);
        }
    }
}
