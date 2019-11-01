using Colourful;
using NUnit.Framework;

namespace ImageMatcher.Lib.Tests
{
    public class ColorDifferenceAnalyzerTests
    {
        [Test]
        public void TheSameColorTest()
        {
            var color1 = RGBColor.FromRGB8bit(100, 150, 105);
            var color2 = RGBColor.FromRGB8bit(100, 150, 105);

            var result =
                ColorDifferenceAnalyzer.ComputeColorDifference(ColorConverter.ToLab(color1),
                    ColorConverter.ToLab(color2));

            Assert.AreEqual(0.0d, result);
        }
        
        [Test]
        public void OnePointDifferenceInColor()
        {
            var color1 = RGBColor.FromRGB8bit(100, 150, 105);
            var color2 = RGBColor.FromRGB8bit(101, 150, 105);

            var result =
                ColorDifferenceAnalyzer.ComputeColorDifference(ColorConverter.ToLab(color1),
                    ColorConverter.ToLab(color2));

            Assert.AreEqual( 0.20453188911597528d, result);
        }
        
        [Test]
        public void OneHundredPointsDifferenceInColor()
        {
            var color1 = RGBColor.FromRGB8bit(100, 150, 105);
            var color2 = RGBColor.FromRGB8bit(100, 250, 105);

            var result =
                ColorDifferenceAnalyzer.ComputeColorDifference(ColorConverter.ToLab(color1),
                    ColorConverter.ToLab(color2));

            Assert.AreEqual( 27.275115148843373d, result);
        }
        
        [Test]
        public void MaxDifferenceInColor()
        {
            var color1 = RGBColor.FromRGB8bit(0, 0, 0);
            var color2 = RGBColor.FromRGB8bit(255, 255, 255);

            var result =
                ColorDifferenceAnalyzer.ComputeColorDifference(ColorConverter.ToLab(color1),
                    ColorConverter.ToLab(color2));

            Assert.AreEqual( 100.0d, result);
        }
    }
}