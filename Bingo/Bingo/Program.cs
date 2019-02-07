using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //Zähler für die Arrays

            Random ZufallsZahl = new Random();

            bool p = false; //Zur überprüfung ob der Spieler gewonnen hat
            int pk = 0; // gibt an, wie viele Zahlen beim Spieler mit der Zufallszahl übereinstimmen

            bool c = false; //Zur überprüfung ob der Computer gewonnen hat
            int ck = 0; // gibt an, wie viele Zahlen beim Spieler mit der Zufallszahl übereinstimmen

            int AnzZahlen = 9; //Anzahl der Zahlen die in den Kästchen stehen


            Random Geg = new Random(); //Zufallszahl für die Zahlen vom Gegner


            int[] ZahlP = new int[AnzZahlen]; //Array Zahlen vom Spieler
            int[] ZahlC = new int[AnzZahlen]; //Array Zahlen vom Computer

            



            for (x = 0; x < AnzZahlen; x++) //Zahlen des Gegners
            {
                ZahlC[x] = Geg.Next(0, 50);
            }


            for (x = 0; x < AnzZahlen; x++) //Zahleneingabe für Spieler
            {
                int i = x + 1;
                Console.Write("Trage deine {0}. Bingo Zahl ein (1-50): ", i);
                ZahlP[x] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            //Erstellen vom Spielfeld
            Console.WriteLine("\n      Du\t\t\t\tGegner");

            Console.WriteLine("┌─┬─┬─┐\t\t\t\t┌─┬─┬─┐");
            Console.WriteLine("│  │  │  │\t\t\t\t│  │  │  │");
            Console.WriteLine("├─┼─┼─┤\t\t\t\t├─┼─┼─┤");
            Console.WriteLine("│  │  │  │\t\t\t\t│  │  │  │");
            Console.WriteLine("├─┼─┼─┤\t\t\t\t├─┼─┼─┤");
            Console.WriteLine("│  │  │  │\t\t\t\t│  │  │  │");
            Console.WriteLine("└─┴─┴─┘\t\t\t\t└─┴─┴─┘");
            //

            //Eintragen der Zahlen vom Spieler
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(ZahlP[0]);

            Console.SetCursorPosition(6, 3);
            Console.WriteLine(ZahlP[1]);

            Console.SetCursorPosition(10, 3);
            Console.WriteLine(ZahlP[2]);


            Console.SetCursorPosition(2, 5);
            Console.WriteLine(ZahlP[3]);

            Console.SetCursorPosition(6, 5);
            Console.WriteLine(ZahlP[4]);

            Console.SetCursorPosition(10, 5);
            Console.WriteLine(ZahlP[5]);


            Console.SetCursorPosition(2, 7);
            Console.WriteLine(ZahlP[6]);

            Console.SetCursorPosition(6, 7);
            Console.WriteLine(ZahlP[7]);

            Console.SetCursorPosition(10,7);
            Console.WriteLine(ZahlP[8]);
            //


            //Eintragen der Zahlen vom Computer
            Console.SetCursorPosition(42, 3);
            Console.WriteLine(ZahlC[0]);

            Console.SetCursorPosition(46, 3);
            Console.WriteLine(ZahlC[1]);

            Console.SetCursorPosition(50, 3);
            Console.WriteLine(ZahlC[2]);


            Console.SetCursorPosition(42, 5);
            Console.WriteLine(ZahlC[3]);

            Console.SetCursorPosition(46, 5);
            Console.WriteLine(ZahlC[4]);

            Console.SetCursorPosition(50, 5);
            Console.WriteLine(ZahlC[5]);


            Console.SetCursorPosition(42, 7);
            Console.WriteLine(ZahlC[6]);

            Console.SetCursorPosition(46, 7);
            Console.WriteLine(ZahlC[7]);

            Console.SetCursorPosition(50, 7);
            Console.WriteLine(ZahlC[8]);
            //



            while (p == false && c == false)
            {
                int a = ZufallsZahl.Next(0, 50);
                
                Console.SetCursorPosition(25, 10);
                Console.WriteLine(a); //schreiben der Zufallszahl
                

                for (x = 0; x < AnzZahlen; x++) //Vergleicht die Zufallszahl mit den anderen zahlen
                {
                    if (a == ZahlC[x])
                    {
                        pk++;
                    }

                    if (a == ZahlP[x])
                    {
                        ck++;
                    }
                }


                if (pk == AnzZahlen && ck == AnzZahlen) //Überprüft ob jemand alle Zahlen hatte
                {
                    p = true;
                    c = true;
                }

                else if (pk == AnzZahlen)
                {
                    p = true;
                }

                else if (ck == AnzZahlen)
                {
                    c = true;
                }

                System.Threading.Thread.Sleep(1000);
            }

            //Wer hat Gewonnen
            if (p == true && c == true)
            {
                Console.SetCursorPosition(25, 12);
                Console.WriteLine("Unentschieden");
            }

            if (p == true)
            {
                Console.SetCursorPosition(25, 12);
                Console.WriteLine("Du gewinnst");
            }

            if (c == true)
            {
                Console.SetCursorPosition(25, 12);
                Console.WriteLine("Computer gewinnt");
            }
            //

            Console.ReadKey();
        }
    }
}
