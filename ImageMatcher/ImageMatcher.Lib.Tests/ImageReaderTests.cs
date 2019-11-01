using NUnit.Framework;

namespace ImageMatcher.Lib.Tests
{
    public class ImageReaderTests
    {
        [Test]
        public void ReadSimpleImageTest()
        {
            var reader = new ImageReader();
            var colorMatrix = reader.ReadColorMatrix("TestData/TestImage.png");

            //first pixel (red)
            Assert.AreEqual(55.100831158860558d, colorMatrix[0,0].L);
            Assert.AreEqual(52.60782794942925d, colorMatrix[0,0].a);
            Assert.AreEqual(21.035096125556542d, colorMatrix[0,0].b);
            
            //last pixel (red)
            Assert.AreEqual(55.100831158860558d, colorMatrix[19,19].L);
            Assert.AreEqual(52.60782794942925d, colorMatrix[19,19].a);
            Assert.AreEqual(21.035096125556542d, colorMatrix[19,19].b);
            
            //last in first column (white)
            Assert.AreEqual(100.0d, colorMatrix[0,19].L);
            Assert.AreEqual(0.0d, colorMatrix[0,19].a);
            Assert.AreEqual(0.0d, colorMatrix[0,19].b);
            
            //first blue (1,1)
            Assert.AreEqual(49.58078276303641d, colorMatrix[1,1].L);
            Assert.AreEqual( 19.763688202490581d, colorMatrix[1,1].a);
            Assert.AreEqual(-62.088208069818563d, colorMatrix[1,1].b);
        }
    }
}