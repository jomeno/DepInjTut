using DepInjTut.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInjTut.Models
{
    public class Car
    {
        public IEngine _engine { get; set; }
        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public int Drive() 
        {
            return _engine.Combust();
        }
        
        
    }
}
