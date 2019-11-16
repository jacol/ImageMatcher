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
            var result = _runner.RunMatcher("TestData/TestImage.png", "TestData/TestImage.png", true, 320);
            Assert.AreEqual(0.0d, result);
        }
        
        [Test]
        public void TwoDotsDifferentColorTest()
        {
            var result = _runner.RunMatcher("TestData/TestImage.png", "TestData/TestImage_2dots_different_color.png", true, 320);
            Assert.AreEqual(0.43517366908356153d, result);
        }
        
        [Test]
        public void FourDotsMovedTest()
        {
            var result = _runner.RunMatcher("TestData/TestImage.png", "TestData/TestImage_4_dots_moved.png", true, 320);
            Assert.AreEqual(0.75996903930308601d, result);
        }
        
        [Test]
        public void InvertedColorsTest()
        {
            var result = _runner.RunMatcher("TestData/TestImage.png", "TestData/TestImage_inverted.png", true, 320);
            Assert.AreEqual(96.729338944477092d, result);
        }
        
        [Test]
        public void WhiteBlackTest()
        {
            var result = _runner.RunMatcher("TestData/TestImage_white.png", "TestData/TestImage_black.png", true, 320);
            Assert.AreEqual(100.0d, result);
        }
        
        [Test]
        public void RealPhotoVerySimilarTest()
        {
            var result = _runner.RunMatcher("TestData/RealPhoto1.jpg", "TestData/RealPhoto2.jpg", true, 320);
            Assert.AreEqual(9.1255822983677426d, result);
        }
        
        [Test]
        public void RealPhotoSlightlyMovedTest()
        {
            var result = _runner.RunMatcher("TestData/RealPhoto1.jpg", "TestData/RealPhoto3.jpg", true, 320);
            Assert.AreEqual(14.330084670483437d, result);
        }
    }
}