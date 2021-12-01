using System;
using System.Collections.Generic;
using System.Linq;

namespace PreAcademyA.Week3.Esercizi.EsamiUniversitari
{
    static class DichiarazioneIndirizziCorsi
    {
        public static IndirizzoDiLaurea InizializeIndirizziCorsi(IndirizziDiLaurea indirizzoScelto)
        {
            if (indirizzoScelto == IndirizziDiLaurea.Matematica)
            {
                List<Corso> corsiMatematica = new List<Corso>();
                corsiMatematica.Add(new Corso("Algebra", 30));
                corsiMatematica.Add(new Corso("Analisi Matematica", 40));
                corsiMatematica.Add(new Corso("Geometria", 30));
                corsiMatematica.Add(new Corso("Informatica", 50));
                corsiMatematica.Add(new Corso("Probabilita", 10));
                corsiMatematica.Add(new Corso("Fisica", 20));

                int totalCfu = 0;
                foreach(var corso in corsiMatematica)
                {
                    totalCfu += corso.Cfu;
                }
                //int tc = corsiMatematica.Sum(c => c.Cfu);

                IndirizzoDiLaurea indirizzo = new IndirizzoDiLaurea(IndirizziDiLaurea.Matematica.ToString(), 3, totalCfu, corsiMatematica);
                return indirizzo;
            }
            else if(indirizzoScelto == IndirizziDiLaurea.Lettere)
            {
                List<Corso> corsiLettere = new List<Corso>();
                corsiLettere.Add(new Corso("Letteratura", 30));
                corsiLettere.Add(new Corso("Storia", 40));
                corsiLettere.Add(new Corso("Scrittura", 30));
                corsiLettere.Add(new Corso("Italiano", 50));
                corsiLettere.Add(new Corso("Giornalismo", 10));
                corsiLettere.Add(new Corso("Latino", 20));

                int totalCfu = 0;
                foreach (var corso in corsiLettere)
                {
                    totalCfu += corso.Cfu;
                }
                int tc = corsiLettere.Sum(c => c.Cfu);

                IndirizzoDiLaurea indirizzo = new IndirizzoDiLaurea(IndirizziDiLaurea.Lettere.ToString(), 3, totalCfu, corsiLettere);
                return indirizzo;
            }
            else if (indirizzoScelto == IndirizziDiLaurea.Fisica)
            {
                List<Corso> corsiFisica = new List<Corso>();
                corsiFisica.Add(new Corso("Fisica generale", 25));
                corsiFisica.Add(new Corso("Fisica teorica", 35));
                corsiFisica.Add(new Corso("Analisi Matematica", 30));
                corsiFisica.Add(new Corso("Meccanica", 50));
                corsiFisica.Add(new Corso("Informatica", 10));
                corsiFisica.Add(new Corso("Elettromagnetismo", 20));

                int totalCfu = 0;
                foreach (var corso in corsiFisica)
                {
                    totalCfu += corso.Cfu;
                }
                int tc = corsiFisica.Sum(c => c.Cfu);

                IndirizzoDiLaurea indirizzo = new IndirizzoDiLaurea(IndirizziDiLaurea.Fisica.ToString(), 3, totalCfu, corsiFisica);
                return indirizzo;
            }
            else if (indirizzoScelto == IndirizziDiLaurea.Informatica)
            {
                List<Corso> corsiInformatica = new List<Corso>();
                corsiInformatica.Add(new Corso("C", 25));
                corsiInformatica.Add(new Corso("Basi di Dati", 35));
                corsiInformatica.Add(new Corso("Html", 30));
                corsiInformatica.Add(new Corso("Java", 50));
                corsiInformatica.Add(new Corso("Logica dei calcolatori", 40));

                int totalCfu = 0;
                foreach (var corso in corsiInformatica)
                {
                    totalCfu += corso.Cfu;
                }
                int tc = corsiInformatica.Sum(c => c.Cfu);

                IndirizzoDiLaurea indirizzo = new IndirizzoDiLaurea(IndirizziDiLaurea.Informatica.ToString(), 3, totalCfu, corsiInformatica);
                return indirizzo;
            }
            else
            {
                List<Corso> corsiIngegneria = new List<Corso>();
                corsiIngegneria.Add(new Corso("Analisi matematica", 25));
                corsiIngegneria.Add(new Corso("Automatica", 35));
                corsiIngegneria.Add(new Corso("Elettronica", 30));
                corsiIngegneria.Add(new Corso("Geometria", 50));
                corsiIngegneria.Add(new Corso("Inglese", 45));

                int totalCfu = 0;
                foreach (var corso in corsiIngegneria)
                {
                    totalCfu += corso.Cfu;
                }
                int tc = corsiIngegneria.Sum(c => c.Cfu);

                IndirizzoDiLaurea indirizzo = new IndirizzoDiLaurea(IndirizziDiLaurea.Ingegneria.ToString(), 3, totalCfu, corsiIngegneria);
                return indirizzo;
            }
        }
        public enum IndirizziDiLaurea
        {
            Matematica = 1,
            Lettere = 2,
            Fisica = 3,
            Informatica = 4,
            Ingegneria = 5
        }
    }
}
