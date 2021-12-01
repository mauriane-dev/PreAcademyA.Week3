using System.Collections.Generic;

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

    public class Corso
    {
        public string Nome { get; set; }
        public int Cfu { get; set; }
        public Corso(string nome, int cfu)
        {
            Nome = nome;
            Cfu = cfu;
        }
    }
    public class Esame:Corso
    {
        public bool Passato { get; set; }
        public Esame(string nome, int cfu, bool passato)
            :base(nome, cfu)
        {
            Passato = passato;
        }
    }
}
