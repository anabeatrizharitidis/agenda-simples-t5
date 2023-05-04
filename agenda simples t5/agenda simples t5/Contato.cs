using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_simples_t5
{
    internal class Contato
   {
        private string primeiroNome;
        private string sobrenome;
        private string telefone;

        public string PrimeiroNome    
        { 
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "00-00000-0000";
                }
            }
        }
        public Contato()
        {
            PrimeiroNome ="AnaBeatriz";
            Sobrenome = "Haritidis";
            Telefone = "00-00000-0000";
         }
        public Contato(string primeiroNome, string sobrenome, string telefone)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        public override string ToString()
        {
            string saída = String.Empty;
            saída += String.Format("{0}, {1}", PrimeiroNome,Sobrenome);
            saída += String.Format("{0}-{1}-{2}",
                Telefone.Substring(0)
                Telefone.Substring
                Telefone.Substring
               ;        }
    }
}

    
