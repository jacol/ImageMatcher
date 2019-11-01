namespace ImageMatcher.Lib.Strategies
{
    public interface IMatcherStrategy
    {
        double Process(ImageLabColorMatrix colorMatrix1, ImageLabColorMatrix colorMatrix2);
    }
}