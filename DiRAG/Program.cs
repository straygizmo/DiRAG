using DiRAG.Services;
using System.Globalization;

namespace DiRAG
{
    internal static class Program
    {
        public static ILocalizationService? LocalizationService { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Initialize localization service
            LocalizationService = new LocalizationService();

            Application.Run(new Forms.MainForm());
        }
    }
}