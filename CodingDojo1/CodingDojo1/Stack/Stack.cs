using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1.Stack
{
    class Stack<T>
    {
        private StackElement<T> curEle;

        public void Push(T item)
        {
            if (curEle == null)
            {
                curEle = new StackElement<T>() { ValueOfElement = item, Successor = null };
            }
            else
            {
                StackElement<T> temp = new StackElement<T>() { ValueOfElement = item, Successor = curEle };
                curEle = temp;
            }

        }

        public T Pop()
        {
            if (curEle != null)
            {
                T temp = curEle.ValueOfElement;
                curEle = curEle.Successor;
                return temp;
            }
            else
            {
                throw new NullReferenceException(); 
            }
        }

        public T Peek()
        {
            if (curEle != null)
            {
                return curEle.ValueOfElement;
            }
            else
            {
                return default(T);
            }
        }
    }
}
