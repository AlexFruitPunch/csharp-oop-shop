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
        private double iva = 22;

        public Prodotto(int codice, string nome, string descrizione, double prezzo)
        {
            this.codice = codice;
            this.nome = nome; 
            this.descrizione = descrizione;
            this.prezzo = prezzo;   
        }

        //--------------- Metodi ----------------



        //------------- Fine Metodi -------------


        //------------- Metodi Getter -------------

        public int GetCodice()
        {
            return codice;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetDescrizione()
        {
            return descrizione;
        }

        public double GetPrezzo()
        {
            return prezzo;
        }

        public double GetIva()
        {
            return iva;
        }

        //------------- Fine Metodi Getter -------------

        //------------- Metodi Setter -------------

        public void SetCodice(int codice)
        {
             this.codice = codice;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }

        public void SetPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }


        //------------- Fine Metodi Setter -------------
    }
}
