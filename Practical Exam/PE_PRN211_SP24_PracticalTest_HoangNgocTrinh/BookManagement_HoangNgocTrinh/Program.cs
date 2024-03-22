namespace BookManagement_HoangNgocTrinh
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

            Application.Run(new LoginForm());
        }   //new màn hình chính, từ màn hình chính mới new
            //màn hình detail

    }
}