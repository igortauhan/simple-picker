using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_picker.Utils
{
    public class ColorValueFormatter : IColorValueFormatter
    {
        public String FormatToRgb(Color color)
        {
            return $"RGB: {color.R}, {color.G}, {color.B}";
        }
    }
}
