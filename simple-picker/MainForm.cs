using simple_picker.Services.Mouse;
using simple_picker.Services.PixelColor;
using simple_picker.Utils;

namespace simple_picker
{
    public partial class MainForm : Form
    {
        private readonly IPixelColorService _pixelColorService;
        private readonly IColorValueFormatter _formatter;

        public MainForm(IPixelColorService pixelColorService, IColorValueFormatter colorValueFormatter)
        {
            InitializeComponent();
            _pixelColorService = pixelColorService;
            _formatter = colorValueFormatter;
        }
    }
}