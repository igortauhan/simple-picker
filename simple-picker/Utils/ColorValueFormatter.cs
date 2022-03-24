using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_picker.Utils
{
    public class ColorValueFormatter : IColorValueFormatter
    {
        public string FormatToRgb(Color color)
        {
            return $"{color.R}, {color.G}, {color.B}";
        }

        public string FormatToArgb(Color color)
        {
            return $"255, {color.R}, {color.G}, {color.B}";
        }

        public string FormatToHex(Color color)
        {
            string r = ConvertToHex(color.R);
            string g = ConvertToHex(color.G);
            string b = ConvertToHex(color.B);
            return $"#{r}{g}{b}";
        }

        private string ConvertToHex(int value)
        {
            return value.ToString("X");
        }
    }
}
