using System.IO;
using ImageMagick;

namespace ImageMatcher.Lib
{
    public class ImageReader : IImageReader
    {
        public ImageLabColorMatrix ReadColorMatrix(string filePath, bool resizeImage, int resizeTargetWidth)
        {
            using MagickImage image = new MagickImage(filePath);
            return ProcessColors(image, resizeImage, resizeTargetWidth);
        }
        public ImageLabColorMatrix ReadColorMatrix(byte[] data, bool resizeImage, int resizeTargetWidth)
        {
            using MagickImage image = new MagickImage(new MemoryStream(data));
            return ProcessColors(image, resizeImage, resizeTargetWidth);
        }

        private static ImageLabColorMatrix ProcessColors(MagickImage image, bool resizeImage, int resizeTargetWidth)
        {
            if (resizeImage)
            {
                double currentRatio = (double)image.Height / (double)image.Width;

                image.Resize(resizeTargetWidth, (int)(resizeTargetWidth * currentRatio));
            }

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