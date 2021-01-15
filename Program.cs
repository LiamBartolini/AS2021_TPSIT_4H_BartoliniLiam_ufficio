using System;
using AS2021_TPSIT_4H_BartoliniLiam_ufficio.Models;

namespace AS2021_TPSIT_4H_BartoliniLiam_ufficio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bartolini Liam, 4H, ufficio");

            Ufficio ufficio = new Ufficio();
            ufficio.ImmissionePratica("Prova immissione", "Prova", "Immissione", 'H');
            try
            {
                Console.WriteLine(ufficio.RicercaPratica(2));
            }
            catch(Exception e)
            {
                Output(e);
            }

            try
            {
                Console.WriteLine(ufficio.RicercaPratica('A'));
            }
            catch (Exception e)
            {
                Output(e);
            }
        }

        static public void Output(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
    }
}