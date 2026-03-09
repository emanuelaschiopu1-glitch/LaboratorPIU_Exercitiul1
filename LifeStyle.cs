using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDay
{
    public class LifeStyle
    {
        public int OreSomn { get; set; }
        public double CantitateApa { get; set; } 

        public LifeStyle()
        {
            OreSomn = 0;
            CantitateApa = 0;
        }

        public void Feedback()
        {
            Console.WriteLine("\nFeedback stil de viață:");

            if (OreSomn < 7)
                Console.WriteLine($"Ai dormit doar {OreSomn} ore. Încearcă să dormi mai mult!");
            else
                Console.WriteLine($"Ai dormit {OreSomn} ore. Somn bun!");

            if (CantitateApa < 2)
                Console.WriteLine($"Ai băut doar {CantitateApa} litri de apă. Bea mai multă apă!");
            else if (CantitateApa <= 2.5)
                Console.WriteLine($"Ai băut {CantitateApa} litri de apă. Bravo, suficient!");
            else
                Console.WriteLine($"Ai băut {CantitateApa} litri de apă. Atentie, prea multă apă!");
        }
    }
    
}
