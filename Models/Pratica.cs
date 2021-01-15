using System.Text;

namespace AS2021_TPSIT_4H_BartoliniLiam_ufficio.Models
{
    class Pratica
    {
        public bool _exist = true;
        string _descrizione;
        public int _id;
        string _nome;
        string _cognome;
        char _tipo;
        public char Tipo{ get=>_tipo; }
        static int _identificativo = 0;

        public Pratica(string descrizione, string nome, string cognome, char tipoPratica)
        {
            _descrizione = descrizione;
            _nome = nome;
            _cognome = cognome;
            _tipo = tipoPratica;
            _id = _identificativo;
            _identificativo++; // incremento l'identificativo
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pratica numero: {_id+1}");
            sb.AppendLine($"Pratica tipo: {_tipo}");
            sb.AppendLine($"Nome: {_nome}");
            sb.AppendLine($"Cognome: {_cognome}");
            sb.AppendLine($"Descrizione: {_descrizione}");
            return sb.ToString();
        }
    }
}