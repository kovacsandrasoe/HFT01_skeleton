using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonMeth_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> friends = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                friends.Add(new Person());
            }

            //Filtering: older than 30
            //01. Use named method matching Predicate<T>


            //02. Use anonymus method matching Predicate<T>


            //03. Use lambda expression matching Predicate<T>






            //Sorting:  by name length

            //01. Use named method matching Comparison<T>>


            //02. Use anonymus method matching Comparison<T>


            //03. Use lambda expression matching Comparison<T>
        }
    }
}
