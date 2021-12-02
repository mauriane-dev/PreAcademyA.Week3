using PreAcademyA.Week3.Esercizi.Libreria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.Libreria
{
    class LibroCartaceoRepository: IDbManager<LibroCartaceo>
    {
        static List<LibroCartaceo> libriCartacei = new List<LibroCartaceo>()
        {
            new LibroCartaceo(45.65, "I Promessi Sposi", "Alessandro Manzoni", 500, 43),
            new LibroCartaceo(47.5, "La Divina Commedia", "Dante Alighieri", 12, 549),
            new LibroCartaceo(12.9, "1984", "George Orwell", 100, 84)
        };

        public List<LibroCartaceo> Fetch()
        {
            return libriCartacei;
        }

        internal bool Exists(string titolo)
        {
            foreach(var libro in libriCartacei)
            {
                if(libro.Titolo == titolo)
                {
                    return true;
                }
            }
            return false;
        }

        internal void UpdateQuantity(string titolo, int qnt)
        {
            LibroCartaceo lc = libriCartacei.Where(lc => lc.Titolo == titolo).ToList()[0];
            lc.QuantitaMagazzino = qnt;
        }

        //Libro che l'utente vuole aggiungere ma che c'è già in magazzino
        internal void UpdateQuantity2(LibroCartaceo libroDaAggiungere)
        {
            // Il libro presente già in magazzino
            LibroCartaceo lc = libriCartacei.Where(lc => lc.Titolo == libroDaAggiungere.Titolo).ToList()[0];

            // qnt del l presente in magazz + qnt del libro che utente vuole agg
            int nuovaQuantita = lc.QuantitaMagazzino + libroDaAggiungere.QuantitaMagazzino;
            lc.QuantitaMagazzino = nuovaQuantita;
        }

        internal List<LibroCartaceo> GetByPrice(double p)
        {
            List<LibroCartaceo> lc = new List<LibroCartaceo>();
            foreach(var libro in libriCartacei)
            {
                if (libro.Prezzo > p)
                {
                    lc.Add(libro);
                }
            }

            return lc;
            //return libriCartacei.Where(lc => lc.Prezzo > p).ToList();
        }
    }
}
