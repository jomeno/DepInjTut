using DepInjTut.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInjTut.Models
{
    public class Engine : IEngine
    {
        private ISparkPlug _plug;
        private IFuelPump _pump;


        public Engine(ISparkPlug plug, IFuelPump pump) 
        {
            _plug = plug;
            _pump = pump;
        }

        public int Combust()
        {
            return _plug.Spark() * _pump.Pump();
        }
    }
}
