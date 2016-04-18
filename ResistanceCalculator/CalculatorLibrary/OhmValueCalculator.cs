using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class OhmValueCalculator : IOhmValueCalculator
    {
        public string CalculateOhmValue(ColorBand bandAColor, ColorBand bandBColor, ColorBand bandCColor, ColorBand bandDColor)
        {
            var symbol = bandCColor.Multiplier.Symbol;
            string resistanceValue = string.Empty;
            double value;
            if(symbol == '*')
              value =  (bandAColor.ColorInfo.ColorId * 10 + bandBColor.ColorInfo.ColorId) * bandCColor.Multiplier.Value;
              else
            value =  (bandAColor.ColorInfo.ColorId * 10 + bandBColor.ColorInfo.ColorId) / bandCColor.Multiplier.Value;           

            if (value > 1000)
                return (value / 1000) + " K Ohm : Tolernce "+ bandDColor.Tolerance + " %";
            else
                return value + " Ohm : Tolernce "+ bandDColor.Tolerance + " % ";
        }
    }
}
