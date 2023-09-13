using MARS.TestTask.DBContext;

namespace MARS.TestTask
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
            if (SqlServerMethods.TryConnectToDB())
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new AutorizationForm());
            }
            else
            {
                MessageBox.Show("Не удалось подключиться к базе данных");
            }
        }
    }
}