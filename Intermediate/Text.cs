using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class Text : PresentationOfObject
    {
        public int write;
        public int read;

        public void WriteText()
        {
            Console.WriteLine("Text has been written");
        }
        public void ReadText()
        {
            Console.WriteLine("Text has been read successfully");
        }
    }
}
