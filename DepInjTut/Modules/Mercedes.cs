using DepInjTut.Interfaces;
using DepInjTut.Models;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInjTut.Modules
{
    public class Mercedes : NinjectModule
    {
        public override void Load()
        {
            Bind<IFuelPump>().To<FuelPump>();
            Bind<IEngineParts>().To<EngineParts>();
            Bind<ISparkPlug>().To<SparkPlug>();
            Bind<IEngine>().To<Engine>();
        }
    }
}
