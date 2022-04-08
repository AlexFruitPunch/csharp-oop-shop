using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop
{
    public class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private double iva;

        public Prodotto(int codice, string nome, string descrizione, double prezzo, double iva)
        {
            this.codice = codice;
            this.nome = nome; 
            this.descrizione = descrizione;
            this.prezzo = prezzo;   
            this.iva = iva;
        }
    }
}
