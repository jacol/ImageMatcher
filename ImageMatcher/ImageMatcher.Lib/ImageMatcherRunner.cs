using ImageMatcher.Lib.Strategies;

namespace ImageMatcher.Lib
{
    public class ImageMatcherRunner
    {
        private readonly IImageReader _imageReader;
        private readonly IMatcherStrategy _strategy;

        public ImageMatcherRunner(IImageReader imageReader, IMatcherStrategy strategy)
        {
            _imageReader = imageReader;
            _strategy = strategy;
        }
        
        public double RunMatcher(string filePath1, string filePath2)
        {
            var colorMatrix1 = _imageReader.ReadColorMatrix(filePath1);
            var colorMatrix2 = _imageReader.ReadColorMatrix(filePath2);

            return _strategy.Process(colorMatrix1, colorMatrix2);
        }
    }
}