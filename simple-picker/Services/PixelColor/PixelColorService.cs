using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_picker.Services.PixelColor;

public class PixelColorService : IPixelColorService
{
    public Color GetPixelColor(int x, int y)
    {
        /* https://stackoverflow.com/a/50039929 */

        Bitmap bitmap = new Bitmap(1, 1);
        Rectangle bounds = new Rectangle(x, y, bitmap.Width, bitmap.Height);

        using (Graphics g = Graphics.FromImage(bitmap))
        {
            g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
        }

        return bitmap.GetPixel(0, 0);
    }
}
