using System;
using AS2021_TPSIT_4H_BartoliniLiam_ufficio.Models;

namespace AS2021_TPSIT_4H_BartoliniLiam_ufficio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ufficio ufficio = new Ufficio();
            
            Console.WriteLine(ufficio.RicercaPratica(2));
        }
    }
}