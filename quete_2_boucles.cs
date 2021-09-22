using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quete_2_boucles
{
    class Program
    {
        static void Main(string[] args)
        {
                string[] moves = new string[32];
            for (int i = 0; i < moves.Length; i++)
            {
                Console.WriteLine("enter dance move : ");
                string dancemove = Console.ReadLine();
                if (dancemove != "done")
                {
                    moves[i] = dancemove;
                }
                else
                {
                  break;
                }
            }
            Console.WriteLine("Choose the number of iteration ");
            int iteration = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < iteration; i++)
            {
                Console.WriteLine("take the move dance : " + moves[i]);
            }
        }
    }
}
