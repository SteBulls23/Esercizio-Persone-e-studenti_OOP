using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Persone_e_studenti_OOP
{
    // Creo la classe Persona(classe base). Definisco tutti gli attributi e i metodi 'public' perchè voglio rendere il codice accessibile per tutte le classi.
    internal class Persona
    {
        // definisco gli attributi o proprietà della classe Persona.
        public string nome { get; set; } = string.Empty;
        public string cognome { get; set; } = string.Empty;
        public int annoNascita { get; set; } = 0;

        // Definisco il costruttore vuoto della classe Persona.
        public Persona()
        {
            this.nome = string.Empty;
            this.cognome = string.Empty;
            this.annoNascita = 0;
        }

        // Definisco il secondo costruttore, stavolta passandogli dei parametri(overload del metodo costruttore).
        public Persona(string pNome, string pCognome, int pAnnoNascita)
        {
            this.nome = pNome;
            this.cognome = pCognome;
            this.annoNascita= pAnnoNascita;
        }

        // Definisco un metodo per visualizzare le caratteristiche della persona. Lo definisco 'virtual', così consento al metodo di essere sottoposto a override nella classe derivata 'Studente'.
        public virtual void visualizzaCaratteristiche() // La funzione la definisco void perchè non restituisce nulla.
        {
            if (this.annoNascita >= 1970)
            {
                Console.WriteLine("Nome persona: {0}; Cognome persona: {1}; Anno di nascita persona: {2} .", this.nome, this.cognome, this.annoNascita);
            }
            else
            {
                Console.WriteLine("Errore! La persona è nata prima del 1970!");
            }
        }
    }
}
