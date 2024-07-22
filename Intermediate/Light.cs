using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class Light:IDevice
    {
        public bool IsOn {  get; set; }
        public void TurnOn()
        {
            Console.WriteLine("Light is Turn ON ");
            IsOn = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is Turn OFF");
            IsOn = false;
        }
    }
}
