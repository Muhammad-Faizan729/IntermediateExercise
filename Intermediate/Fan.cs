using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class Fan : IDevice
    {
        public bool IsOn { get; set; }
        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Fan is turn ON");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Fan is Turn OFF");
        }
    }
}
