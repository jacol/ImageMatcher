using NUnit.Framework;

namespace ImageMatcher.Lib.Tests
{
    public class ImageLabColorMatrixTests
    {
        [Test]
        public void FourDifferentColorsTest()
        {
            var matrix = new ImageLabColorMatrix(2, 2);
            matrix.AddColor(0, 0, 10, 20, 30);
            matrix.AddColor(1, 0, 120, 230, 130);
            matrix.AddColor(0, 1, 60, 50, 40);
            matrix.AddColor(1, 1, 132, 221, 39);
            
            //first point
            Assert.AreEqual(5.8508421241227389d, matrix[0,0].L);
            Assert.AreEqual(-1.4962768959702193d, matrix[0,0].a);
            Assert.AreEqual(-8.2548250495584838d, matrix[0,0].b);
            
            //second point
            Assert.AreEqual(21.655220595591864d, matrix[0,1].L);
            Assert.AreEqual(3.280509548974714d, matrix[0,1].a);
            Assert.AreEqual( 8.1445067737438315d, matrix[0,1].b);
            
            //third point
            Assert.AreEqual(83.050799346571111d, matrix[1,0].L);
            Assert.AreEqual( -48.362370827319864d, matrix[1,0].a);
            Assert.AreEqual( 38.474842882762729d, matrix[1,0].b);
            
            //fourth point
            Assert.AreEqual(80.230934014636588d, matrix[1,1].L);
            Assert.AreEqual( -47.580683430828493d, matrix[1,1].a);
            Assert.AreEqual( 71.103078949925276d, matrix[1,1].b);
        }
    }
}