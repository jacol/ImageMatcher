using Colourful;

namespace ImageMatcher.Lib
{
    public class ImageLabColorMatrix
    {
        private LabColor[,] _data;

        public ImageLabColorMatrix(int width, int height)
        {
            _data = new LabColor[width, height];
        }

        public void AddColor(int x, int y, byte r, byte g, byte b)
        {
            _data[x, y] = ColorConverter.ToLab(RGBColor.FromRGB8bit(r, g, b));
        }

        public LabColor this[int x, int y] => _data[x, y];
    }
}