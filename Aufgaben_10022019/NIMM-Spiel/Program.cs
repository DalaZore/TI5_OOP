using System;
using System.IO.IsolatedStorage;

namespace NIMM_Spiel
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
               Console.WriteLine("Restart the Program and enter the number of pieces as argument! e.g. [Nimm-Spiel 50] to start the game with 50 pieces.");
               Console.ReadKey();
            }
            else
            {
                int n = Convert.ToInt32(args[0]);
                Console.WriteLine("Wilkommen zum Nimm-Spiel! Anzahl Spielsteine: {0}",n);
                while (n > 0)
                {
                    if (n == 1)
                    {
                        Console.WriteLine("Computer ist am Zug! Anzahl Spielsteine: {0}",n);
                        Console.WriteLine("Computer hat verloren!");
                        n = 0;
                    }
                    else
                    {
                        int anz = (n - 1) % 4;
                        if (anz == 0)
                        {
                            anz = 1;
                        }

                        n -= anz;
                        Console.WriteLine("Computer nimmt {0} Steine. Es bleiben noch {1} Steine", anz,n);

                        if (n == 1)
                        {
                            n = 0;
                            Console.WriteLine("Computer ist am Zug! Anzahl Spielsteine: {0}",n);
                            Console.WriteLine("Computer Gewinnt!");
                        }
                        else
                        {
                            Console.WriteLine("Spieler ist am Zug! Anzahl Spielsteine: {0}",n);
                            do
                            {
                                Console.WriteLine("Wie viele Steine nimmst du?");
                                anz = Int32.Parse(Console.ReadLine());
                            } while (anz < 1 || anz > 3);

                            n -= anz;
                            Console.WriteLine("Der Spieler entnimmt {0} Steine. Es bleiben noch {1} Steine übrig",anz,n);
                        }
                    }
                }
            }
        }
    }
}