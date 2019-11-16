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
        
        public double RunMatcher(string filePath1, string filePath2, bool resizeImage, int resizeTargetWidth)
        {
            var colorMatrix1 = _imageReader.ReadColorMatrix(filePath1, resizeImage, resizeTargetWidth);
            var colorMatrix2 = _imageReader.ReadColorMatrix(filePath2, resizeImage, resizeTargetWidth);

            return _strategy.Process(colorMatrix1, colorMatrix2);
        }

        public double RunMatcher(byte[] data1, byte[] data2, bool resizeImage, int resizeTargetWidth)
        {
            var colorMatrix1 = _imageReader.ReadColorMatrix(data1, resizeImage, resizeTargetWidth);
            var colorMatrix2 = _imageReader.ReadColorMatrix(data2, resizeImage, resizeTargetWidth);

            return _strategy.Process(colorMatrix1, colorMatrix2);
        }
    }
}