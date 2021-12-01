using System;

namespace PreAcademyA.Week3.Esercizi.FigureGeometriche
{
    class Program
    {
        //Scrivere un programma per rappresentare le forme geometriche:​

        //Tutte le classi avranno una proprietà Nome(stringa),
        //un metodo per il calcolo del perimetro
        //un metodo per il calcolo dell’area
        //un metodo che disegni la forma -> stampare nella console i dettagli delle
        //proprietà e dell'area e del perimetro

        //Realizzare le classi che rappresentano:​
        //Un cerchio che avrà anche le coordinate del centro e il raggio
        //Un rettangolo che avrà anche larghezza e altezza
        //Un triangolo che avrà base e altezza

        //Tutte le classi dovranno implementare la propria versione del metodo di calcolo dell’area,
        //il perimetro e di disegno​


        //Aggiungere un'interfaccia che permetta di salvare e leggere i risultati da un file
        //I metodi riceveranno in ingresso il nome del file


        static void Main(string[] args)
        {
            CentroStruct centro = new CentroStruct(-1, -2);
            Cerchio cerchio = new Cerchio();
            cerchio.Centro = centro;
            cerchio.Raggio = 3;
            cerchio.Nome = "Cerchio";
            //cerchio.CalcolaPerimetro();
            //cerchio.CalcolaArea();
            cerchio.DisegnaForma();
            cerchio.LeggiDaFile("ilPathDelMioFile");
            cerchio.ScriviSuFile("ilPathDelMioFile");

            Rettangolo rettangolo = new Rettangolo();
            rettangolo.Nome = "Rettangolo";
            rettangolo.Base = 5;
            rettangolo.Altezza = 10;
            rettangolo.DisegnaForma();

            Triangolo triangolo = new Triangolo();
            triangolo.Nome = "Triangolo";
            triangolo.Lato1 = 6;
            triangolo.Lato2 = 3;
            triangolo.Base = 5;
            triangolo.Altezza = 10;
            triangolo.DisegnaForma();

        }
    }
}
