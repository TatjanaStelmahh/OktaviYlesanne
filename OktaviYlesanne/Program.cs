using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktaviYlesanne
{
    class Program
    {
        //enum Noodid { C = 260, D = 290, E = 330, F=350, G=390, P=037};

        //static void Main(string[] args)


        //{
        //    var array  = Enum.GetValues(typeof(Noodid)).Cast<Noodid>().ToArray();
        //    Console.WriteLine(array);



        //    Console.Beep(390, 400); //G
        //    Console.Beep(330, 400); //E
        //    Console.Beep(390, 400); //G
        //    Console.Beep(330, 400); //E
        //    Console.Beep(390, 400); //G
        //    Console.Beep(037, 400);
        //    Console.Beep(390, 400); //G



        static void Laula(string s)

        {
            string noodid = "C.D.E.F.G.A.H";

            Dictionary<char, int> sagedused =
            new Dictionary<char, int>
            {
                { 'C', 440},
                { 'D', 493},
                { 'E', 554},
                { 'F', 587},
                { 'G', 659},
                { 'A', 739},
                { 'H', 830},
                { 'B', 830},
                { 'P', 037}
            };

            Dictionary<char, int> sagedused2 =
           new Dictionary<char, int>
           {
                { 'C', 261},
                { 'D', 293},
                { 'E', 330},
                { 'F', 349},
                { 'G', 391},
                { 'A', 440},
                { 'H', 494},
                { 'B', 494},
                { 'P', 037}
           };


            Dictionary<char, int> sagedusedUP =
            new Dictionary<char, int>
            {
                { 'C', 1046},
                { 'D', 1175},
                { 'E', 1318},
                { 'F', 1397},
                { 'G', 1568},
                { 'A', 1760},
                { 'H', 1960},
                { 'B', 830},
                { 'P', 037}
            };

            Dictionary<char, int> sagedusedDOWN =
           new Dictionary<char, int>
           {
                { 'C', 65},
                { 'D', 73},
                { 'E', 82},
                { 'F', 87},
                { 'G', 97},
                { 'A', 110},
                { 'H', 123},
                { 'B', 123},
                { 'P', 037}
           };

            Dictionary<char, int> sagedusedMID =
           new Dictionary<char, int>
           {
                { 'C', 131},
                { 'D', 147},
                { 'E', 165},
                { 'F', 175},
                { 'G', 196},
                { 'A', 220},
                { 'H', 246},
                { 'B', 246},
                { 'P', 037}
           };

            foreach (var x in s)
            {
                //              if (x == 'P') Task.Delay(500).Wait();
                //                if (x == 'P') Thread.Sleep(500);
                //else
                //{
                //    int i = noodid.IndexOf(x);
                //    int j = (int)(440 * Math.Pow(2, i / 12.0));
                //    Console.Beep(j, 300);
                //}
                //                else 
                Console.Beep(sagedusedDOWN[x],400);
            }
        }

        static void Main(string[] args)

        {

            double pooltoon = Math.Pow(2, 1 / 12);
            /* c = 0, d = 2, e = 4, f = 5, g = 7, a = 9, h = 11, c = 12*/
            // p on paus
            string jubalinnukesed_salm1 = "GEGEGPGPFEFGEPPPGEGEGPGPFEFGEPPP";
            string jubalinnukesed_salm2 = "EEEEFEDCDDDFEDCPPPEEEEFEDCDDDFEDCPPP";
            string rongisoit = "CDEFGGGPCDEFGGGPFFFFEEEPDDDDCCCPFFFPEEEPDDDDCCCP";
            string sepapoisid = "CDECCDECEFGPPEFGPPP" +
                                "GAGFEPCPGAGFEPCPCPDECPPPCPDECPPP";
           
            string christmas = "CFFGFEDDPDGGAGFECPCAABAGFDPCCDGEFPP" +
                                "CFFFEPEFEDCPGAGFCCPCCDGEFPP" +
                                "CFFGFEDDPDGGAGFECPCAABAGFDPCCDGEFPP" +
                                "CFFGFEDDPDGGAGFECPCAABAGFDPCCDGEFPP";
            string starwars = "CPGPGGGCFEDGCFED" + 
                              "GFEFDCGGGGFEDCGFCEDGFEFDFGGAAEDCCDEDABFEGGAADCGDDGFEDCGAACDEDGGABCAGGFDDCGDDCGGGGFED";

            string imperial = "AAAFCAFCAPPEEEFCAFCAFC";

            Laula(imperial);

            for (int i = 1000; i < 25; i++)
            {
                int j = (int)(440 * Math.Pow(2, i / 12.0));
                Console.Beep(j, 100);
            }


        }
    }
}
