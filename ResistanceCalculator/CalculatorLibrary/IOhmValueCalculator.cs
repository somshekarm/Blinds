namespace CalculatorLibrary
{
    public interface IOhmValueCalculator
    {
        string CalculateOhmValue(ColorBand bandAColor, ColorBand bandBColor, ColorBand bandCColor, ColorBand bandDColor);
    }
}