namespace GameCollectionManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // u� i�in 
            Application.ThreadException += Application_ThreadException;
            //winform i�in
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);


            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // �nce giri� ekran� ba�ar�l� giri�te main forma giri� yap�ld�
            LoginForm login = new LoginForm();
            Application.Run(login);
            if (login.IsAuthenticated) {
                Application.Run(new MainForm(login.User));
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.ExceptionObject.ToString());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }
    }
}