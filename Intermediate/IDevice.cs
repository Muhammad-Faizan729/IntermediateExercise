using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        bool IsOn { get; }
    }
}
