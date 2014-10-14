using DepInjTut.Interfaces;
using DepInjTut.Models;
using DepInjTut.Modules;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInjTut
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            // load required modules
            kernel.Load(new Mercedes());

            var car = new Car(kernel.Get<IEngine>());
            Console.WriteLine("This car was driven miles : {0}", car.Drive());
            Console.ReadKey();

        }
    }
}
