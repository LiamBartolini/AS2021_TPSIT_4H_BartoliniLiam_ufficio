using System;
using System.Collections.Generic;
using System.Text;

namespace AS2021_TPSIT_4H_BartoliniLiam_ufficio.Models
{
    class Ufficio
    {
        List<Pratica> _pratiche = new List<Pratica>();

        public Ufficio()
        {
            _pratiche.Add(new Pratica("Prima pratica", "Liam", "Bartolini", 'A'));
            _pratiche.Add(new Pratica("Seconda pratica", "Er", "Faina", 'C'));
            _pratiche.Add(new Pratica("Terza pratica", "Potenza", "Surreale", 'B'));
            _pratiche.Add(new Pratica("Evasione fiscale", "Stefano", "Lepri", 'D'));
        }

        public void ImmissionePratica(string descrizione, string nome, string cognome, char tipoPratica) => _pratiche.Add(new Pratica(descrizione, nome, cognome, tipoPratica));

        public Pratica RicercaPratica(int id)
        {
            foreach(var p in _pratiche)
                if (p.Id == id)
                    return p;

            throw new Exception("Pratica non trovata!");
        }

        public string RicercaPratica(char tipoPratica)
        {
            bool isFinded = false;
            StringBuilder sb = new StringBuilder();
            foreach(var p in _pratiche)
                if (p.Tipo == tipoPratica)
                {
                    sb.AppendLine(p.ToString());
                    isFinded = true;
                }
            
            if (isFinded)
                return sb.ToString();    
            else
                throw new Exception($"Pratiche di tipo {tipoPratica} non trovate");
        }

        public bool EliminazionePratica(int id)
        {
            foreach(var p in _pratiche)
                if (p.Id == id)
                {
                    p._exist = false;
                    return true;
                }
            return false;
        }

        public bool SalvataggioPratiche()
        {
            return true;
        }
    }
}