using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistanceCalculator.Models
{
    public class ColorBandCollection
    {
        public ColorBandCollection(BandGroup bandAColor, BandGroup bandBColor, BandGroup bandCColor, BandGroup bandDColor)
        {
            BandAColor = bandAColor;
            BandBColor = bandBColor;
            BandCColor = bandCColor;
            BandDColor = bandDColor;
        }
        public BandGroup BandAColor { get; private set; }
        public BandGroup BandBColor { get; private set; }
        public BandGroup BandCColor { get; private set; }
        public BandGroup BandDColor { get; private set; }
    }   

    public class BandGroup
    {
        public BandGroup(string name, List<ColorBand> colorBands)
        {
            Name = name;
            ColorBands = colorBands;
        }

        public string Name { get; private set; }
        public List<ColorBand> ColorBands { get; private set; }
    }
}
