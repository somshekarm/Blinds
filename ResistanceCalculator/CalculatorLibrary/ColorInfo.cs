using System;

namespace CalculatorLibrary
{
    public class ColorInfo
    {
        public ColorInfo(int colorId)
        {
            Name = Enum.Parse(typeof(Color), colorId.ToString()).ToString();
            ColorId = colorId == 12 ? 1: colorId;
        }

        public string Name { get; set; }
        public int ColorId { get; set; }
    }
}