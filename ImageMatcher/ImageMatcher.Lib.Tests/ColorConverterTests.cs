using Colourful;
using NUnit.Framework;

namespace ImageMatcher.Lib.Tests
{
    
    public class ColorConverterTests
    {
        [Test]
        public void RgbToLabConvertTest()
        {
            RGBColor input = RGBColor.FromRGB8bit(100, 180, 20);
            var output = ColorConverter.ToLab(input);
            
            Assert.AreEqual(66.210907448350753d, output.L, "L value invalid");
            Assert.AreEqual(-43.228098886804013d, output.a, "a value invalid");
            Assert.AreEqual(62.622271435015122d, output.b, "b value invalid");
        }
    }
}