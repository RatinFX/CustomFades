using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CustomFades
{
    public static class Processes
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
    }
}
