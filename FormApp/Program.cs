using FormApp.Exceptions;

namespace FormApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var log = string.Empty;
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(new FormApp());
            }
            catch(OurOwnException ex)
            {
                log=ex.Message;
            }
            catch(Exception ex)
            {
                log = ex.Message;
            }
        }
    }
}