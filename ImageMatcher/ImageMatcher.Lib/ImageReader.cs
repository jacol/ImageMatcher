using ImageMagick;

namespace ImageMatcher.Lib
{
    public class ImageReader : IImageReader
    {
        public ImageLabColorMatrix ReadColorMatrix(string filePath)
        {
            using MagickImage image = new MagickImage(filePath);
            var result = new ImageLabColorMatrix(image.Width, image.Height);
                
            var pixels = image.GetPixels();

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    var color = pixels[x, y].ToColor();
                    result.AddColor(x, y, color.R, color.G, color.B);
                }
            }

            return result;
        }
    }
}