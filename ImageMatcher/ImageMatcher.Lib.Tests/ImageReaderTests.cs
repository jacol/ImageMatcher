using NUnit.Framework;

namespace ImageMatcher.Lib.Tests
{
    public class ImageReaderTests
    {
        [Test]
        public void ReadSimpleImageTest()
        {
            var reader = new ImageReader();
            var colorMatrix = reader.ReadColorMatrix("TestData/TestImage.png", true, 320);

            //first pixel (red)
            Assert.AreEqual(50.252996909873247d, colorMatrix[0,0].L);
            Assert.AreEqual(58.680595771207265d, colorMatrix[0,0].a);
            Assert.AreEqual(27.000150547984148d, colorMatrix[0,0].b);
            
            //last pixel (red)
            Assert.AreEqual(68.086668207681399d, colorMatrix[19,19].L);
            Assert.AreEqual(10.91862983913494d, colorMatrix[19,19].a);
            Assert.AreEqual(-33.122098763792643d, colorMatrix[19,19].b);
            
            //last in first column (white)
            Assert.AreEqual(88.001894799108271d, colorMatrix[0,19].L);
            Assert.AreEqual(14.334361565523201d, colorMatrix[0,19].a);
            Assert.AreEqual(6.0035517114861214d, colorMatrix[0,19].b);
            
            //first blue (1,1)
            Assert.AreEqual(50.916902744193109d, colorMatrix[1,1].L);
            Assert.AreEqual(58.67958091222242d, colorMatrix[1,1].a);
            Assert.AreEqual(26.72909383915718d, colorMatrix[1,1].b);
        }
    }
}