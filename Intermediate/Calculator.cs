using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class Calculator
    {
        public void Add( params int[] number)
        {
            Console.WriteLine("Adding numbers that are coming from main function as an argument using params modifier");
        }
        public void WithOutUsingReference(ref int a)
        {
            a += 2;
        }
    }
}
