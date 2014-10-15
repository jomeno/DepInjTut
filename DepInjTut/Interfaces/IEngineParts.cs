using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInjTut.Interfaces
{
    public interface IEngineParts
    {
        ISparkPlug Plug { get; set; }
        IFuelPump Pump { get; set; }
    }
}
