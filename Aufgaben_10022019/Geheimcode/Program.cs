using System;
using System.Threading;

// Ich konnte leider den Fehler nicht finden! evtl. etwas mit Public / Private aber kann es nicht genau eingrenzen...

namespace GeheimCode
{
    public class GeheimCode
    {
        private string code;

        public GeheimCode(String c)
        {
            code = c;
        }

        public bool vergleichen(GeheimCode geheim)
        {
            return code == geheim.code;
        }
    }
    class Program
    {
        static void testAuswerten(bool valid)
        {
            if (valid)
                Console.WriteLine("Code o.k.");
            else
                Console.WriteLine("Code falsch");
        }

        static void Main(string[] args)
        {
            GeheimCode code1;
            GeheimCode code2;
            GeheimCode code3;

            code1 = new GeheimCode("abc");
            code2 = new GeheimCode("def");
            code3 = new GeheimCode("abc");

            testAuswerten(code1.vergleichen(code2));
            testAuswerten(code1.vergleichen(code3));
            testAuswerten(code2.vergleichen(code3));

            Thread.Sleep(5000);
        }
    }
}
