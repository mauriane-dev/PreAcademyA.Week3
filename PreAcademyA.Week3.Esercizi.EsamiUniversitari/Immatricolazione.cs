using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public Immatricolazione(DateTime dataInizio, IndirizziDiLaurea indirizzoScelto)
        {
            Matricola = Convert.ToString(matricola);
            DataInizio = dataInizio;
            CorsoLaurea = DichiarazioneIndirizziCorsi.InizializeIndirizziCorsi(indirizzoScelto);
            CfuAccumulati = 0;
            FuoriCorso = CalculateFuoriCorso(dataInizio, CorsoLaurea.AnniDiCorso);
        }
        private bool CalculateFuoriCorso(DateTime dataInizio, int anniDiCorso)
        {
            if (dataInizio.AddYears(anniDiCorso) < DateTime.Now)
                return false;
            return true;
        }
    }
}
