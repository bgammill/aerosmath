using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerosmathTestImplementation
{
    public class ConversionWrapper
    {
        public Unit ConvertedFrom { get; private set; }
        public Unit ConvertedTo { get; private set; }
        public double ConvertedValue { get; private set; }

        public ConversionWrapper(Unit from, Unit to, double value)
        {
            this.ConvertedFrom = from;
            this.ConvertedTo = to;
            this.ConvertedValue = value;
        }
    }
}
