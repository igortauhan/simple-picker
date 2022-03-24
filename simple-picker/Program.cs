using simple_picker.Services.PixelColor;
using simple_picker.Utils;

namespace simple_picker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(new PixelColorService(), new ColorValueFormatter()));
        }
    }
}