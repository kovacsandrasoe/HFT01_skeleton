using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OuterVariableTrap
{
    class Program
    {
        static void Main(string[] args)
        {
            //we have several SDXC cards...1GB, 2GB, 4GB
            //task: calculate how much cards have to buy to store the entire data?

            Action<int> calculators = null;

            for (int i = 1; i <= 4096; i *= 2)
            {
                calculators += (dataSize) =>
                {
                    Console.WriteLine($"{i} GB CARD: {(dataSize / i) + 1} PIECE");
                };
            }

            calculators(1643); //GB

            Console.ReadLine();


        }
    }
}
