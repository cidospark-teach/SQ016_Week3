using Todo.Services;

namespace MyTodo.UI
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
            GlobalConfig.Instantiate();

            ManageTask manageForm = new ManageTask(GlobalConfig.TodoService);
            Application.Run(new Form1(GlobalConfig.TodoService, manageForm));
        }
    }
}