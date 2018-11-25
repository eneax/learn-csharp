using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack _stack = new Stack();

            int ini = 0;
            int max = 5;

            for (int i = ini; i <= max; i++)
            {
                _stack.Push(i);
            }

            for (int i = ini; i <= max; i++)
            {
                Console.WriteLine(_stack.Pop());
            }

            Console.ReadLine();
        }
    }

    public class Stack
    {
        private List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("You cannot add a null object to the stack.");
            }

            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("There are no elements in the stack yet.");
            }

            var index = _list.Count - 1;

            var toReturn = index;

            _list.RemoveAt(index);

            return (toReturn);
        }
    }
}
