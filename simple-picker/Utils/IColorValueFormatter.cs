
namespace simple_picker.Utils
{
    public interface IColorValueFormatter
    {
        string FormatToRgb(Color color);
        string FormatToHex(Color color);
    }
}