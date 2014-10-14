using DepInjTut.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInjTut.Models
{
    public class SparkPlug : ISparkPlug
    {
        public int Spark()
        {
            return 3;
        }
    }
}
