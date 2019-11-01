using Colourful;
using Colourful.Conversion;
using Colourful.Difference;

namespace ImageMatcher.Lib
{
    public static class ColorDifferenceAnalyzer
    {
        private static readonly CIEDE2000ColorDifference Ciede2000ColorDifference;
        static ColorDifferenceAnalyzer()
        {
            Ciede2000ColorDifference = new CIEDE2000ColorDifference();
        }
        public static double ComputeColorDifference(LabColor color1, LabColor color2)
        {
            return Ciede2000ColorDifference.ComputeDifference(color1, color2);
            
        }
    }
}