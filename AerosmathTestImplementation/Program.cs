using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerosmathTestImplementation
{
    public class Program
    {
        public static Dictionary<Unit, double> units = new Dictionary<Unit, double>();
        static void Main(string[] args)
        {
            units.Add(Unit.Inch, 0.0254);
            units.Add(Unit.Foot, 0.3048);
            units.Add(Unit.Yard, 0.9144);
            units.Add(Unit.Mile, 1609.344);
            units.Add(Unit.Milimeter, 0.001);
            units.Add(Unit.Centimeter, 0.01);
            units.Add(Unit.Kilometer, 1000);

            var inchToMeter = ConvertToMeter(Unit.Inch, 100);
            var meterToYard = ConvertFromMeter(Unit.Yard, 53);
            
            Console.WriteLine(string.Format("Original: {0}, New: {1}, Value: {2}", inchToMeter.ConvertedFrom, inchToMeter.ConvertedTo, inchToMeter.ConvertedValue));
            Console.WriteLine(string.Format("Original: {0}, New: {1}, Value: {2}", meterToYard.ConvertedFrom, meterToYard.ConvertedTo, meterToYard.ConvertedValue));
            Console.ReadKey();
        }

        public static ConversionWrapper ConvertToMeter(Unit from, double num)
        {
            var conversionResult = num * Extensions.GetConversionFactor(from);
            return new ConversionWrapper(from, Unit.Meter, conversionResult);
        }

        public static ConversionWrapper ConvertFromMeter(Unit to, double num)
        {
            var conversionResult = num / Extensions.GetConversionFactor(to);
            return new ConversionWrapper(Unit.Meter, to, conversionResult);
        }
    }
}
