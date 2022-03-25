using simple_picker.Services.Mouse;
using simple_picker.Services.PixelColor;
using simple_picker.Utils;

namespace simple_picker.Services.Values
{
    public class ValuesService
    {
        private readonly IPixelColorService _pixelColorService;
        private readonly IColorValueFormatter _colorValueFormatter;

        public ValuesService(IPixelColorService pixelColorService, IColorValueFormatter colorValueFormatter)
        {
            _pixelColorService = pixelColorService;
            _colorValueFormatter = colorValueFormatter;
        }

        public string ValueRgb()
        {
            Color color = GetColor();
            return _colorValueFormatter.FormatToRgb(color);
        }

        public string ValueArgb()
        {
            Color color = GetColor();
            return _colorValueFormatter.FormatToArgb(color);
        }

        public string ValueHex()
        {
            Color color = GetColor();
            return _colorValueFormatter.FormatToHex(color);
        }

        private Color GetColor()
        {
            Point mouse = MouseService.GetMousePosition();
            return _pixelColorService.GetPixelColor(mouse.X, mouse.Y);
        }
    }
}
