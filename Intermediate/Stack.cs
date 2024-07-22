using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class Stack
    {
        private List<int> _stack = new List<int>();

        public void Push()
        {
            Console.WriteLine("Enter an integer : ");
            int value = Convert.ToInt32(Console.ReadLine());
            _stack.Add(value);
        }

        public void Pop()
        {
            for(int i = _stack.Count-1; i >=0 ; i--)
            {
                Console.WriteLine(_stack[i]);
            }
        }
    }
}
