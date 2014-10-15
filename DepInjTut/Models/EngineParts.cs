using DepInjTut.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInjTut.Models
{
    public class EngineParts : IEngineParts
    {
        public ISparkPlug Plug { get; set; }
        public IFuelPump Pump { get; set; }
        public EngineParts(ISparkPlug plug, IFuelPump pump)
        {
            Plug = plug;
            Pump = pump;
        }
    }
}
