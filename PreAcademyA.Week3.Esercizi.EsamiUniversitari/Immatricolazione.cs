using System;
using static PreAcademyA.Week3.Esercizi.EsamiUniversitari.DichiarazioneIndirizziCorsi;

namespace PreAcademyA.Week3.Esercizi.EsamiUniversitari
{
    class Immatricolazione
    {
        private static int matricola = 0;

        public string Matricola { get; set; }
        public DateTime DataInizio { get; set; }
        public IndirizzoDiLaurea CorsoLaurea { get; set; }
        public bool FuoriCorso { get; set; }
        public int CfuAccumulati { get; set; }

        public Immatricolazione()
        {

        }

        public Immatricolazione(DateTime dataInizio, IndirizziDiLaurea indirizzoScelto)
        {
            Matricola = Convert.ToString(matricola);
            DataInizio = dataInizio;
            //CorsoLaurea = DichiarazioneIndirizziCorsi.InizializeIndirizziCorsi(indirizzoScelto);
            CfuAccumulati = 0;
            FuoriCorso = CalculateFuoriCorso(dataInizio, CorsoLaurea.AnniDiCorso);
        }
        public  bool CalculateFuoriCorso(DateTime dataInizio, int anniDiCorso)
        {
            if (dataInizio.AddYears(anniDiCorso).Year > DateTime.Now.Year)
                return false;
            return true;
        }
    }
}
