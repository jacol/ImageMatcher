namespace ImageMatcher.Lib.Strategies
{
    public interface IMatcherStrategy
    {
        /// <summary>
        /// Implement different strategies for comparing images in terms of similarity. 
        /// </summary>
        /// <param name="colorMatrix1">LAB color matrix of first image</param>
        /// <param name="colorMatrix2">LAB color matrix of second image</param>
        /// <returns>Returns 0 when images are exactly the same. Returns 100 when images are different. Values in range 0-100 depends on strategy.</returns>
        double Process(ImageLabColorMatrix colorMatrix1, ImageLabColorMatrix colorMatrix2);
    }
}