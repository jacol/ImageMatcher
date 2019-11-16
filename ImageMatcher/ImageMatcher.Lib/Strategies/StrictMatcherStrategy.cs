using System;
using System.Diagnostics;

namespace ImageMatcher.Lib.Strategies
{
    public class StrictMatcherStrategy : IMatcherStrategy
    {
        public double Process(ImageLabColorMatrix colorMatrix1, ImageLabColorMatrix colorMatrix2)
        {
            if (colorMatrix1.Width != colorMatrix2.Width || colorMatrix1.Height != colorMatrix2.Height)
            {
                return 100.0;
            }

            double counter = 0d;
            double sum = 0.0d;
            
            for (int x = 0; x < colorMatrix1.Width; x++)
            {
                for (int y = 0; y < colorMatrix1.Height; y++)
                {
                    var color1 = colorMatrix1[x, y];
                    var color2 = colorMatrix2[x, y];
                    
                    var result = ColorDifferenceAnalyzer.ComputeColorDifference(color1, color2);

                    if (result > 0.0d)
                    {
                        counter++;
                    }
                    
                    sum += result;
                }
            }

            if (Math.Abs(counter) < 0.00001) return 0.0d;
            return (sum / counter) * (counter / (colorMatrix1.Width * colorMatrix1.Height));
        }
    }
}