using NLog;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace RaportEksportow
{
    internal static class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        [STAThread]
        static void Main()
        {
            try
            {
                // formatowanie daty do yyyy-MM-dd, custom cultureinfo
                CultureInfo customCulture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
                customCulture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
                CultureInfo.DefaultThreadCurrentCulture = customCulture;
                CultureInfo.DefaultThreadCurrentUICulture = customCulture;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, "Błąd aplikacji");
                MessageBox.Show($"Błąd aplikacji: {ex.Message}");
            }
        }
    }
}
