using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CustomFades
{
    public static class Helper
    {
        public static void OpenUrl(string url)
        {
            // From https://stackoverflow.com/a/43232486
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show(
                        ex.Message,
                        "Something went wrong",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    throw;
                }
            }
        }

        public static void OpenRatinFXWebsite()
        {
            OpenUrl("https://ratinfx.github.io");
        }

        public static void ShowAbout(string text)
        {
            MessageBox.Show(text, "About", MessageBoxButtons.OK);
        }

        public static void ChangeTheme(MenuStrip menuStrip)
        {
            menuStrip.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
        }

        public class CustomProfessionalColors : ProfessionalColorTable
        {
            public Color Highlight { get; set; } = Color.FromArgb(45, 45, 45);
            public CustomProfessionalColors() { }
            public override Color MenuItemBorder => Color.Transparent;
            public override Color MenuItemSelected => Highlight;
            public override Color MenuItemPressedGradientBegin => Highlight;
            public override Color MenuItemPressedGradientEnd => Highlight;
            public override Color MenuItemSelectedGradientBegin => Highlight;
            public override Color MenuItemSelectedGradientEnd => Highlight;
        }
    }
}
