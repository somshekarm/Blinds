using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class ColorBand
    {

        private ColorBand() { }
        public ColorInfo ColorInfo { get; set; }
        public ColorMutliplier Multiplier { get; set; }
        public string HexaDecimalValue { get; set; }
       
        public int Tolerance { get; set; }
        public static ColorBand Info(Color color)
        {           
            switch (color)
            {
                case Color.None:
                    return new ColorBand()
                    {
                        ColorInfo = new ColorInfo(Convert.ToInt32(color)),
                        Multiplier = new ColorMutliplier('*', 1),
                        Tolerance = 1
                    };
                case Color.Black:
                    return new ColorBand()
                    {
                        ColorInfo = new ColorInfo(Convert.ToInt32(color)),
                        HexaDecimalValue = "#000000",
                        Multiplier = new ColorMutliplier('*', 1),
                        Tolerance = 1
                    };
                case Color.Brown:
                    return new ColorBand()
                    {
                        ColorInfo = new ColorInfo(Convert.ToInt32(color)),
                        HexaDecimalValue = "#a52a2a",
                        Multiplier = new ColorMutliplier('*', 10),
                        Tolerance = 1
                    };
                case Color.Red:
                    return new ColorBand()
                    {
                        ColorInfo = new ColorInfo(Convert.ToInt32(color)),
                        HexaDecimalValue = "#ff0000",
                        Multiplier = new ColorMutliplier('*', 100),
                        Tolerance = 2
                    };
                case Color.Orange:
                    return new ColorBand()
                    {
                        ColorInfo = new ColorInfo(Convert.ToInt32(color)),
                        HexaDecimalValue = "#ffa500",
                        Multiplier = new ColorMutliplier('*', 1000),
                        Tolerance = 1
                    };
                case Color.Yellow:
                    return new ColorBand()
                    {
                        ColorInfo = new ColorInfo(Convert.ToInt32(color)),
                        HexaDecimalValue = "#ffff00",
                        Multiplier = new ColorMutliplier('*', 10000),
                        Tolerance = 1
                    };
                case Color.Green:
                    return new ColorBand()
                    {
                        ColorInfo = new ColorInfo(Convert.ToInt32(color)),
                        HexaDecimalValue = "#008000",
                        Multiplier = new ColorMutliplier('*', 100000),
                        Tolerance = 1
                    };
                case Color.Blue:
                    return new ColorBand()
                    {
                        ColorInfo = new ColorInfo(Convert.ToInt32(color)),
                        HexaDecimalValue = "#0000ff",
                        Multiplier = new ColorMutliplier('*', 10),
                        Tolerance = 1
                    };
                case Color.Violet:
                    return new ColorBand()
                    {
                        ColorInfo = new ColorInfo(Convert.ToInt32(color)),
                        HexaDecimalValue = "#ee82ee",
                        Multiplier = new ColorMutliplier('*', 1000000),
                        Tolerance = 1
                    };
                case Color.Grey:
                    return new ColorBand()
                    {
                        ColorInfo = new ColorInfo(Convert.ToInt32(color)),
                        HexaDecimalValue = "#808080",
                        Multiplier = new ColorMutliplier('*', 1),
                        Tolerance = 1
                    };
                case Color.White:
                    return new ColorBand()
                    {
                        ColorInfo = new ColorInfo(Convert.ToInt32(color)),
                        HexaDecimalValue = "#ffffff",
                        Multiplier = new ColorMutliplier('*', 1),
                        Tolerance = 1
                    };
                case Color.Silver:
                    return new ColorBand()
                    {
                        ColorInfo = new ColorInfo(Convert.ToInt32(color)),
                        HexaDecimalValue = "#c0c0c0",
                        Multiplier = new ColorMutliplier('/', 100),
                        Tolerance = 10
                    };
                case Color.Gold:
                    return new ColorBand()
                    {
                        ColorInfo = new ColorInfo(Convert.ToInt32(color)),
                        HexaDecimalValue = "#ffd700",
                        Multiplier = new ColorMutliplier('/', 10),
                        Tolerance = 5
                    };                    
                default:
                    return new ColorBand();  
            }
        }
    }
}