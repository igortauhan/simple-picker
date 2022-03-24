using simple_picker.Services.Keyboard;
using simple_picker.Services.PixelColor;
using simple_picker.Services.Values;
using simple_picker.Utils;

namespace simple_picker
{
    public partial class MainForm : Form
    {
        private const string projectSource = "https://github.com/igortauhan/simple-picker";
        private KeyboardHookService _keyboardHookService;

        public MainForm()
        {
            InitializeComponent();
            _keyboardHookService = new KeyboardHookService(
                    this, 
                    new ValuesService(new PixelColorService(), new ColorValueFormatter())
                );
        }

        private void rgbButtonCpy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rgbTextBox.Text);
        }
        private void argbButtonCpy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(argbTextBox.Text);
        }

        private void hexButtonCpy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hexTextBox.Text);
        }
    }
}