using System;
using System.Text;

namespace AS2021_TPSIT_4H_BartoliniLiam_ufficio.Models
{
    class Pratica
    {
        public bool _exist = true;
        string _descrizione;
        static int _id;
        public int Id { get => _id; }
        string _nome;
        string _cognome;
        char _tipo;
        public char Tipo{ get=>_tipo; }
        
        public Pratica(string descrizione, string nome, string cognome, char tipoPratica)
        {
            _descrizione = descrizione;
            _nome = nome;
            _cognome = cognome;
            _tipo = tipoPratica;
            _id++;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pratica numero: {_id}");
            sb.AppendLine($"Pratica tipo: {_tipo}");
            sb.AppendLine($"Nome: {_nome}");
            sb.AppendLine($"Cognome: {_cognome}");
            sb.AppendLine($"Descrizione: {_descrizione}");
            return sb.ToString();
        }
    }
}