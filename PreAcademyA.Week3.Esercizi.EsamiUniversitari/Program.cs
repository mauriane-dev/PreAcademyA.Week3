using System;
using static PreAcademyA.Week3.Esercizi.EsamiUniversitari.DichiarazioneIndirizziCorsi;

namespace PreAcademyA.Week3.Esercizi.EsamiUniversitari
{
    /*   Creare una Console App che gestisca l’iscrizione ad un esame di uno Studente.
             Lo studente è definito con:
                   Nome
                   Cognome
                   AnnoDiNascita
                   Immatricolazione
                   Esami
                   RichiestaLaurea

             L’immatricolazione ha le seguenti caratteristiche:
                   Matricola
                   DataInizio
                   IndirizzoDiLaurea
                   FuoriCorso
                   CFUAccumulati

             Un Indirizzo di laurea è dato da un 
                  Nome
                  AnniDiCorso
                  Cfu per ottenere la laurea
                  Lista di corsi associati.

             Un Corso ha 
                  Nome
                  CFU


             Un Esame si riferisce ad un corso e tiene conto se esso è stato passato.

             I Corsi di Laurea sono Matematica, Fisica, Informatica, Ingegneria, Lettere.

             La matricola dello studente deve essere univoca(autogenerata e read-only -questi facoltativi)

             Uno studente può richiedere un esame solo se
                   esso è presente nel Indirizzo di Laurea associato allo studente,
                   se i CFU del corso associato all’esame non superino i CFU massimi del Indirizzo di laurea
                   se non ha il flag richiestaLaurea assegnato a vero.

            Nel caso le condizioni siano verificate, lo studente aggiunge l’esame alla lista Esami.
            Scrivere un metodo EsamePassato che, dato un esame, vada ad aggiornare i CFU accumulati dallo studente, 
            metta il flag Passato sull’esame e verifichi se con tale esame sono stati raggiunti i CFU necessari per richiedere la laurea (e quindi metta il flag Richiestalaurea a true);

            Consigli:
               -Potrebbe essere utile creare un paio di metodi ad hoc per creare al volo delle liste di corsi, corsi di laurea…
               -Visto che le classi sono collegate strettamente l’una con le altre, verificate l’inizializzazione di ciascuna sia adeguata e che i riferimenti siano corretti
         */


    class Program
    {
        static void Main(string[] args)
        {
            // Studente appena immatricolato
            Console.WriteLine("Inserisci il nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome");
            string cognome = Console.ReadLine();
           
            int annoNascita;
            do
            {
                Console.WriteLine("Inserisci l'anno di nascita");
            } while(!int.TryParse(Console.ReadLine(), out annoNascita));

            var values = Enum.GetValues(typeof(IndirizziDiLaurea));
            IndirizziDiLaurea indirizzoScelto;
            do
            {
                Console.WriteLine("Scegli un indirizzo di laurea");
                int count = 1;
                foreach (var idl in values)
                {
                    Console.WriteLine($"Premi {count} per l'indirizzo di Laurea {idl}");
                    count++;
                }
            } while (!Enum.TryParse(Console.ReadLine(), out indirizzoScelto));

            Studente studente = new Studente(nome, cognome, annoNascita, indirizzoScelto);
        }
    }
}
