using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AS2021_TPSIT_4H_BartoliniLiam_ufficio.Models
{
    class Ufficio
    {
        static List<Pratica> _pratiche = new List<Pratica>();

        public Ufficio()
        {
            // Per i test utilizzo questi dati qui
            _pratiche.Add(new Pratica("Prima pratica", "Liam", "Bartolini", 'A'));
            _pratiche.Add(new Pratica("Seconda pratica", "Er", "Faina", 'A'));
            _pratiche.Add(new Pratica("Terza pratica", "Potenza", "Surreale", 'B'));
            _pratiche.Add(new Pratica("Evasione fiscale", "Stefano", "Lepri", 'D'));
        }

        // Arrow function
        public void ImmissionePratica(string descrizione, string nome, string cognome, char tipoPratica)
        => _pratiche.Add(new Pratica(descrizione, nome, cognome, tipoPratica));

        public Pratica RicercaPratica(int id)
        {
            for (int i = 0; i < 100000000; i++)
            {}
            
            foreach (var p in _pratiche)
                if (p._id == id && p._exist)
                    return p;

            throw new Exception("Pratica non trovata!");
        }

        public string RicercaPratica(char tipoPratica)
        {
            bool isFinded = false;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\tPratiche di tipo: {tipoPratica}\n");
            foreach(var p in _pratiche)
                if (p.Tipo == tipoPratica && p._exist)
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
                if (p._id == id - 1)
                {
                    p._exist = false;
                    return true;
                }
            return false;
        }

        public bool SalvataggioPratiche()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\tSalvataggio in data: {DateTime.Today:dd/MM/yyyy} {DateTime.Now:HH:mm}\n");
            foreach (var p in _pratiche)
                if (p._exist)
                    sb.AppendLine(p.ToString() + "\n\t\t============");
            
            try
            {
                File.AppendAllText("Dati.txt", sb.ToString());
                return true;
            }
            catch
            {
                throw new Exception("Salvataggio pratiche non riuscito!");
            }
        }

        static public bool RipristinoPratiche()
        {
            try
            {
                File.WriteAllText("Dati.txt", "");
                return true;
            }
            catch
            {
                throw new Exception("Ripristino pratiche non riuscito!");
            }
        }
    }
}