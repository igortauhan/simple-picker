using simple_picker.Services.Keyboard;
using simple_picker.Services.PixelColor;
using simple_picker.Services.Values;
using simple_picker.Utils;

namespace simple_picker
{
    public partial class MainForm : Form
    {
        private KeyboardHookService _keyboardHookService;

        public MainForm()
        {
            InitializeComponent();
            _keyboardHookService = new KeyboardHookService(
                    this, 
                    new ValuesService(new PixelColorService(), new ColorValueFormatter())
                );
        }
    }
}