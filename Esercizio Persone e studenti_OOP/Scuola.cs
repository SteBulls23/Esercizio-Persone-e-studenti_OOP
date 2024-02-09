/* Esercizio: 
1) Realizzare la classe base 'Persona':  
- ha come attributi: 'nome', 'cognome', 'annoNascita';
- realizzare i metodi costruttore vuoto e parametrico;
- l'attributo annoNascita deve poter accettare solo persone nate dopo il 1970 (altrimenti visualizzerà un messaggio di errore).

2) Creare la classe derivata 'Studente':
- ha come attributi aggiuntivi: 'matricola', 'esamiSostenuti';
- realizzare i metodi costruttore vuoto e parametrico; 
- realizzare un metodo Incremento che aggiunge uno al numero di esami sostenuti (ogni volta che viene invocato).

3) Nel main occorre:
- istanziare un oggetto "Persona" con il costruttore vuoto;
- visualizzare i dati dell'istanza sulla console;
- modificare a piacimento i valori dell'istanza.

- istanziare un oggetto 'Studente' con il costruttore vuoto;
- visualizzare i dati dell'istanza sulla console;
- verificare il metodo che incrementa il numero di esami sostenuti (fai una stampa a video prima e dopo averlo utilizzato);
- modificare a piacimento i dati dell'istanza.*/

namespace Esercizio_Persone_e_studenti_OOP
{
    internal class Scuola
    {
        static void Main(string[] args)
        {
            // Creo un oggetto 'Persona', chiamato 'persona' e utilizzo il costruttore vuoto per inizializzare l'oggetto. Per creare l'oggetto utilizzo la parola chiave 'new'.
            Persona persona = new Persona();
            Console.WriteLine("Scrivi il nome della persona!");
            persona.nome = Console.ReadLine();
            Console.WriteLine("Scrivi il cognome della persona!");
            persona.cognome = Console.ReadLine();
            Console.WriteLine("Scrivi l'anno di nascita della persona!");
            persona.annoNascita = Convert.ToInt32(Console.ReadLine());

            persona.visualizzaCaratteristiche(); // Attraverso questa sintassi chiamo ed eseguo il metodo 'visualizzaCaratteristiche' per visualizzare le caratteristiche di una persona.

            // Inizializzando un oggetto con il costruttore vuoto, l'utente è libero di cambiare il valore di un attributo ogni volta che esegue il programma.
            
            // Creo un oggetto 'Studente', chiamato 'studente' e utilizzo il costruttore vuoto per inizializzare l'oggetto. Per creare l'oggetto utilizzo la parola chiave 'new'.
            Studente studente = new Studente();
            Console.WriteLine("Scrivi il nome dello studente!");
            studente.nome = Console.ReadLine();
            Console.WriteLine("Scrivi il cognome dello studente!");
            studente.cognome = Console.ReadLine();
            Console.WriteLine("Scrivi l'anno di nascita dello studente!");
            studente.annoNascita = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Scrivi il numero di immatricolazione dello studente!");
            studente.matricola = Console.ReadLine();
            Console.WriteLine("Scrivi il numero di esami sostenuti dallo studente!");
            studente.esamiSostenuti = Convert.ToInt32(Console.ReadLine());

            studente.visualizzaCaratteristiche(); // Attraverso questa sintassi chiamo ed eseguo il metodo 'visualizzaCaratteristiche' per visualizzare le caratteristiche di uno studente.
            studente.incremento(); // Attraverso questa sintassi chiamo ed eseguo il metodo 'incremento' per incrementare di uno il numero di esami sostenuti dallo studente.

            Console.WriteLine("PROGRAMMA TERMINATO");
        }
    }
}

// Esercizio terminato! Ora puoi eseguire il programma.