using Colourful;
using Colourful.Conversion;

namespace ImageMatcher.Lib
{
    public static class ColorConverter
    {
        private static readonly ColourfulConverter Converter;

        static ColorConverter()
        {
            Converter = new ColourfulConverter();
        }
        
        public static LabColor ToLab(RGBColor input)
        {
            return Converter.ToLab(input);
        }
    }
}