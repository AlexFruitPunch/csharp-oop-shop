/*Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
Un prodotto è caratterizzato da:
codice (numero intero)
-nome
-descrizione
-prezzo
-iva
Usate opportunamente ai modificatori di accesso (public, private), i costruttori,
i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
Il codice prodotto sia accessibile solo in lettura
Gli altri attributi siano accessibili sia in lettura che in scrittura
Il prodotto esponga sia un metodo per avere il prezzo base
uno per avere il prezzo comprensivo di iva
Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
Nel vostro programma principale, testate tutte le funzionalità della classe Prodotto, creando vari prodotti e
stampandone il loro contenuto. */

using CsharpShop;

//Inizializzazione Variabili

Console.WriteLine("----------- Shop -----------");
Console.WriteLine("\nInserisci i dati del prodotto");

//Codice
Random r = new Random();
int mioCodice = r.Next(00000000,10000000);

//Nome
Console.Write("Nome: ");
string mioNome = (Console.ReadLine());

//descrizione
Console.Write("Descrizione: ");
string mioDescrizione = (Console.ReadLine());

//prezzo
Console.Write("Prezzo: ");
double mioPrezzo = double.Parse(Console.ReadLine());

//categoria
Console.Write("Categoria - [alimentari/Spezie/Carni/Altro]: ");
string miaCategoria = Console.ReadLine().ToLower();

Prodotto mioProdotto = new Prodotto(mioCodice, mioNome, mioDescrizione, mioPrezzo, miaCategoria);




