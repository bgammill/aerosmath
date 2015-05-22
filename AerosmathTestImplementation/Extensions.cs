using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerosmathTestImplementation
{
    public static class Extensions
    {
        public static double GetConversionFactor(Unit unit)
        {
            Program.units.Single(x => x.Key == unit).Value;
        }
    }
}
