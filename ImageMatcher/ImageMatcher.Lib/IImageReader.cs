namespace ImageMatcher.Lib
{
    public interface IImageReader
    {
        ImageLabColorMatrix ReadColorMatrix(string filePath, bool resizeImage, int resizeTargetWidth);
        ImageLabColorMatrix ReadColorMatrix(byte[] data, bool resizeImage, int resizeTargetWidth);
    }
}