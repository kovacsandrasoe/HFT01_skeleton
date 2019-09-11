using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DelegatesVSEvents
{
    class GenericStack<T>
    {
        T[] array;
        int pointer;

        public GenericStack(int size)
        {
            array = new T[size];
            pointer = 0;
        }

        public void Push(T item)
        {
            if (pointer >= array.Length)
            {
                throw new ArgumentException("Stackoverflow :D!");
            }
            array[pointer] = item;
            pointer++;
        }

        public T Pop()
        {
            if (pointer == 0)
            {
                throw new ArgumentException("Stack is empty!");
            }
            return array[--pointer];
        }
    }
}
