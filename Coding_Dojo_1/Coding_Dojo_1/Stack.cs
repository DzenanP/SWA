using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Dojo_1
{
    class Stack<T>
    {
        private StackElement<T> current;

        public void Push(T value)
        {
            if(current == null)
            {
                current = new StackElement<T> { ValueOfElements = value, Next = null };
            }
            else
            {
                StackElement<T> tmp = new StackElement<T>() { ValueOfElements = value, Next = current };
                current = tmp;
            }
        }
        public T Pop()
        {
            if (current != null)
            {
                T tmp = current.ValueOfElements;
                current = current.Next;
                return tmp;
            }
            else
            {
                return default;
            }
        }

        public T Peek()
        {
            if(current != null)
            {
                return current.ValueOfElements;
            }
            else
            {
                return default;
            }
        }
    }
}
