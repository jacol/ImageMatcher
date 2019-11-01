namespace ImageMatcher.Lib
{
    public interface IImageReader
    {
        ImageLabColorMatrix ReadColorMatrix(string filePath);
    }
}