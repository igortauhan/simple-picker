using simple_picker.Services.Mouse;
using simple_picker.Services.PixelColor;

namespace simple_picker
{
    public partial class MainForm : Form
    {
        IPixelColorService _pixelColorService;

        public MainForm(IPixelColorService pixelColorService)
        {
            InitializeComponent();
            _pixelColorService = pixelColorService;
        }

        private void pickButton_Click(object sender, EventArgs e)
        {
            Point mouse = MouseService.GetMousePosition();
            Color color = _pixelColorService.GetPixelColor(mouse.X, mouse.Y);
            hexLabelText.Text = color.ToString();
        }
    }
}