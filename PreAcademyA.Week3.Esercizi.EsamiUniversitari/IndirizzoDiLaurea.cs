using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.EsamiUniversitari
{
    class IndirizzoDiLaurea
    {
        public string Nome { get; set; }
        public int AnniDiCorso { get; set; }
        public int Cfu { get; set; }
        public List<Corso> Corsi { get; set; }

        public IndirizzoDiLaurea(string nome, int anniDiCorso, int cfu, List<Corso> corsi)
        {
            Nome = nome;
            AnniDiCorso = anniDiCorso;
            Cfu = cfu;
            Corsi = corsi;
        }
    }

    public struct Corso
    {
        public string Nome { get; set; }
        public int Cfu { get; set; }
        public Corso(string nome, int cfu)
        {
            Nome = nome;
            Cfu = cfu;
        }
    }
}
