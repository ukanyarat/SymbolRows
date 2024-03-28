using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolRows
{
    internal class SymbolRows
    {
        static void Main(string[] args)
        {
            char symbol;
            int row;

            Console.Write("Please enter symbol : ");
            symbol = Convert.ToChar(Console.ReadLine());

            Console.Write("Please enter number of row : ");
            row = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
