using System;
using System.CodeDom.Compiler;
using System.Threading;

namespace Spinnen_Kaefer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int done = 0;
            Console.WriteLine("Spinnen und Kaeferprogramm: (Spinnen haben 8 Beine und Kaefer haben 6 Beine");
            Console.Write("Wieviele Beine sind in der Spinnen und kaeferschachtel: ");
            int SumBeine = Int32.Parse(Console.ReadLine());

                int anzSpinnen = 0;
                int anzKaefer = 0;
                while (SumBeine > 0)
                {
                    done = 1;
                    while (SumBeine % 6 != 0)
                    {
                        SumBeine = SumBeine - 8;
                        anzSpinnen++;
                        if (SumBeine < 0)
                        {
                            done = 0;
                            break;
                        }
                    }
                    while (SumBeine > 0)
                    {
                        SumBeine = SumBeine - 6;
                        anzKaefer++; 
                        if (SumBeine < 0)
                        {
                            done = 0;
                            break;
                        }
                    }
                    
                if (done != 1)
                {
                    Console.WriteLine("Es gibt keine Lösung!");
                }
                else
                {
                    Console.WriteLine("In der Schachtel befinden sich {0} Spinnen und {1} Kaefer",anzSpinnen,anzKaefer);
                }
            }

            
        }
    }
}