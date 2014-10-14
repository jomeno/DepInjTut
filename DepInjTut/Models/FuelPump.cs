using DepInjTut.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInjTut.Models
{
    public class FuelPump : IFuelPump
    {
        public int Pump()
        {
           return 5;
        }
    }
}
