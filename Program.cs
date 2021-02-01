using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subrutineArrayInArrayOutC
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Pole1 = new int[] { 1, 2, 3, 4, 5 };
            int VelikostPole = Pole1.Length; //5
            int[] Pole2 = new int[VelikostPole];
            // ref pred polem
            NavyseniS(Pole1, ref Pole2);

            for (int a = 0; a < VelikostPole; a++)
            {
                Console.WriteLine(Pole2[a]);
            }

            Console.ReadLine();

        }
        // ref pred polem
        static void NavyseniS(int[] Pole1S, ref int[] Pole2S)
        {
            int VelikostPoleS = Pole1S.Length;
            //int[] Pole2S = new int[VelikostPoleS];

            for (int i = 0; i < VelikostPoleS; i++)
            {
                Pole2S[i] = Pole1S[i] + 10;

            }

        }

    }
}

