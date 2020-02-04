using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char[,] Tábla = new char[10,10];
            Feltöltés(Tábla);   
            Kirajzoló(Tábla);

            Console.ReadKey();
        }
        static void Feltöltés(char[,]Tábla)
        {
            for (int sor = 0; sor < pálya.GetLength(0); sor++)
            {

                for (int oszlop = 0; oszlop < pálya.GetLength(1); oszlop++)
                {
                    pálya[sor, oszlop] = '_';
                }
            }
            Random gép = new Random();
            int x2;
            int x;
             for (int sor = 0; sor < 10; sor++)
             {
                do
                {
                    x = gép.Next(1, 10);
                    x2 = gép.Next(1, 10);
                } while (pálya[x, x2] == '_');
                pálya[x, x2] = 'B';
             }

        }
        static void Kirajzoló(char[,]Tábla)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int sor = 0; sor < pálya.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < pálya.GetLength(1); oszlop++)
                {
                    Console.Write($"{pálya[sor, oszlop]}|");
                }
                Console.WriteLine();
            }
        }
    }
}
