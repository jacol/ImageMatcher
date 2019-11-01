using ImageMatcher.Lib.Strategies;
using NUnit.Framework;

namespace ImageMatcher.Lib.Tests
{
    public class StrictMatcherStrategyTests
    {
        private ImageMatcherRunner _runner;

        [SetUp]
        public void Setup()
        {
            var reader = new ImageReader();
            var strategy = new StrictMatcherStrategy();
            
            _runner = new ImageMatcherRunner(reader, strategy);
        }
        
        [Test]
        public void TheSameImagesTest()
        {
            var result = _runner.RunMatcher("TestData/TestImage.png", "TestData/TestImage.png");
            Assert.AreEqual(0.0d, result);
        }
        
        [Test]
        public void TwoDotsDifferentColorTest()
        {
            var result = _runner.RunMatcher("TestData/TestImage.png", "TestData/TestImage_2dots_different_color.png");
            Assert.AreEqual(0.34176909110791132d, result);
        }
        
        [Test]
        public void FourDotsMovedTest()
        {
            var result = _runner.RunMatcher("TestData/TestImage.png", "TestData/TestImage_4_dots_moved.png");
            Assert.AreEqual(0.90828015090319913d, result);
        }
        
        [Test]
        public void InvertedColorsTest()
        {
            var result = _runner.RunMatcher("TestData/TestImage.png", "TestData/TestImage_inverted.png");
            Assert.AreEqual(98.393893594361103d, result);
        }
        
        [Test]
        public void WhiteBlackTest()
        {
            var result = _runner.RunMatcher("TestData/TestImage_white.png", "TestData/TestImage_black.png");
            Assert.AreEqual(100.0d, result);
        }
        
        [Test]
        public void RealPhotoVerySimilarTest()
        {
            var result = _runner.RunMatcher("TestData/RealPhoto1.jpg", "TestData/RealPhoto2.jpg");
            Assert.AreEqual(10.838735083273438d, result);
        }
        
        [Test]
        public void RealPhotoSlightlyMovedTest()
        {
            var result = _runner.RunMatcher("TestData/RealPhoto1.jpg", "TestData/RealPhoto3.jpg");
            Assert.AreEqual(15.668385324615739d, result);
        }
    }
}