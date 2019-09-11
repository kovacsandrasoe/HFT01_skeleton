using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DelegatesVSEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIFO data structure
            GenericStack<int> numberStack = new GenericStack<int>(10);
            numberStack.Push(54);
            numberStack.Push(62);
            numberStack.Push(17);
            numberStack.Push(23);

            Console.WriteLine(numberStack.Pop());
            Console.WriteLine(numberStack.Pop());
            Console.WriteLine(numberStack.Pop());
            Console.WriteLine(numberStack.Pop());

            //01. create push event

            //02. create externally attached comparer!

            Console.ReadKey();
        }
    }
}
