using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class PresentationOfObject
    {
        public int Width;
        public int Height;

        public void Copy()
        {
            Console.WriteLine("Text Copied to clipboard");
        }
        public void duplicate()
        {
            Console.WriteLine("Text has been duplicated");
        }
    }
}
