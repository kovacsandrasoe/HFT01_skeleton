using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFT01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 8, 12, 78, 91, 23, 45, 98, 17, 2, 1 };

        }

        static void HelloGerman(string name)
        {
            Console.WriteLine($"Guten Morgen, {name}!"); ;
        }

        static void HelloEnglish(string name)
        {
            Console.WriteLine($"Good Morning, {name}!"); ;
        }

        static void HelloHungarian(string name)
        {
            Console.WriteLine($"Jó reggelt, {name}!"); ;
        }

        static double Sum(IEnumerable<int> collection)
        {
            double sum = 0;
            foreach (var item in collection)
            {
                sum += item;
            }
            return sum;
        }

        static double Average(IEnumerable<int> collection)
        {
            double sum = 0;
            int count = 0;
            foreach (var item in collection)
            {
                sum += item;
                count++;
            }
            return sum / count;
        }

        


    }
}

