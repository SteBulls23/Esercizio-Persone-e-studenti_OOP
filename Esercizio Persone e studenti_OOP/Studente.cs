using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Persone_e_studenti_OOP
{
    // Creo la classe Studente(classe derivata) che estende la classe PPersona, in quanto uno studente è anche una persona. Definisco tutti gli attributi e i metodi 'public' perchè voglio rendere il codice accessibile per tutte le classi.
    internal class Studente : Persona
    {
        // Definisco gli attributi o proprietà della classe studente.
        public string matricola { get; set; } = string.Empty;
        public int esamiSostenuti { get; set; } = 0;

        // Definisco il costruttore vuoto della classe Studente.
        public Studente()
        {
            this.matricola = string.Empty;
            this.esamiSostenuti = 0;
        }

        // Definisco il secondo costruttore, stavolta passandogli dei parametri(overload del metodo costruttore).
        public Studente(string pNome, string pCognome, int pAnnoNascita, string pMatricola, int pEsamiSostenuti) : base(pNome, pCognome, pAnnoNascita)
        {
            this.matricola = pMatricola;
            this.esamiSostenuti = pEsamiSostenuti;
        }

        // Definisco un metodo per visualizzare le caratteristiche dello studente. In questo caso faccio l'override del metodo 'visualizzaCaratteristiche'.
        public override void visualizzaCaratteristiche() // La funzione la definisco void perchè non restituisce nulla.
        {
            if (this.annoNascita >= 1970)
            {
                Console.WriteLine("Nome studente: {0}; Cognome studente: {1}; Anno di nascita studente: {2}; Numero di immatricolazione studente: {3}; Numero di esami sostenuti dallo studente: {4} .", this.nome, this.cognome, this.annoNascita, this.matricola, this.esamiSostenuti);
            }
            else
            {
                Console.WriteLine("Errore! Lo studente è nata prima del 1970!");
            }
        }

        // Definisco un metodo che incrementa di uno il numero di esami sostenuti, ogni volta che viene invocato.
        public void incremento()
        {
            this.esamiSostenuti++;
            Console.WriteLine("Lo studente ha sostenuto {0} esami.", this.esamiSostenuti);
        }
    }
}
