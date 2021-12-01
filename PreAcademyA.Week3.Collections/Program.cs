using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using System.Linq;

namespace PreAcademyA.Week3.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array -> è tipizzato, ne devo conoscere la grandezza

            int[] arrayDiInteri = new int[4];
            arrayDiInteri[0] = 9;
            //arrayDiInteri[1] = "";

            // ArrayList -> non è tipizzato, non devo conoscere a priori la grandezza

            ArrayList arrayList = new ArrayList();
            arrayList.Add(9);
            arrayList.Add("");
            arrayList.Add(true);

            //foreach(var elem in arrayList)
            //{
            //    elem = elem + 1;
            //}

            // Queue -> non sono tipizzate -> quando chiedo un elemento mi restutuisce sempre il più vecchio
            //  il primo che ho inserito

            Queue queue = new Queue();
            // inserimento
            queue.Enqueue(3);
            queue.Enqueue("Ciao");
            queue.Enqueue(true);

            // restituzione senza eliminazione
            var elemento = queue.Peek(); // 3
            // restituzione con eliminazione
            var elemento2 = queue.Dequeue(); //3, "Ciao", true

            // Stack -> non tipizzato  -> restituisce sempre l'elemento più "giovane"
            // l'ultimo che ho inserito

            Stack stack = new Stack();

            //inserimento
            stack.Push(3);
            stack.Push("Ciao");
            stack.Push(true);

            // restituzione senza eliminazione

            stack.Peek();  //true

            //restituzione con eliminazione
            stack.Pop();   // true, "Ciao", 3

            #region Dictionary

            // Dictionary -> fortemente tipizzato, non devo conoscere a priori la grandezza
            // Dictionary<key, value>
            // quando l'elemento è formato da una coppia chiave - valore
            Dictionary<int, string> dictionary1 = new Dictionary<int, string>();
            Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
            Dictionary<int, Persona> dictionary3 = new Dictionary<int, Persona>();
            // Aggiunta di un elemento
            dictionary1.Add(12, "Gatto"); //Posizione 1 ma la chiave è 12
            dictionary1.Add(25, "Cane");
            dictionary1.Add(35, "Topo");
            // dictionary1.Add(35, ""); -> Non posso aggiungere un elemento con la stessa chiave

            // Contiene elemento?
            bool containsKey = dictionary1.ContainsKey(3);
            bool containsValue = dictionary1.ContainsValue("Cane");

            // Restituisce il numero di elementi
            dictionary1.Count();

            // ritornarna l'elemento in quella posizione
            var elementoDelDictionary = dictionary1.ElementAt(3);

            // ritorna tutte le chiavi
            var tutteLeChiavi = dictionary1.Keys;
            // ritorna tutti i valori
            var tuttiIValori = dictionary1.Values;

            // ciclo per prendere la singola chiave o il singolo valore
            foreach(var singleElement in dictionary1)
            {
                Console.WriteLine($"{singleElement.Key}, {singleElement.Value}");
            }

            // Restituisce il valore data la chiave
            var value = dictionary1.GetValueOrDefault(2);

            // Restituisce il valore data la chiave verificando se esiste
            bool exists = dictionary1.TryGetValue(1, out string value2);

            //Eliminare un elemento
            bool èStatoEliminato = dictionary1.Remove(12);
            bool èStatoEliminato2 = dictionary1.Remove(12, out string valoreElemEliminato);

            #endregion


            #region Lista
            // Lista -> fortemente tipazzata, non ne devo conoscere a priori la grandezza

            List<string> laMiaLista = new List<string>();

            //Aggiunta 
            laMiaLista.Add("PrimaStringa");    // 0
            laMiaLista.Add("SecondaStringa");  // 1
            laMiaLista.Add("TerzaStringa");    // 2
            //laMiaLista.Add(3);
            // Ammette duplicati
            laMiaLista.Add("TerzaStringa");

            // Restituisce il numero di elementi
            laMiaLista.Count();

            bool contieneQuelValore = laMiaLista.Contains("PrimaStringa");

            bool èStatoCancellato = laMiaLista.Remove("PrimaStringa");
            // elimina l'elemento in quella posizione
            laMiaLista.RemoveAt(2);

            // Ordina gli elementi nella lista
            laMiaLista.Sort();
            // inverte l'ordine degli elementi della lista
            laMiaLista.Reverse();

            foreach(var elementoNellaLista in laMiaLista)
            {
                Console.WriteLine($"{elementoNellaLista}");
            }

            #endregion
        }
    }
}
