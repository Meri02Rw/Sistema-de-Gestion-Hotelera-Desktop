using PMS.Windows;
using System.Windows;

namespace PMS
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Crear y mostrar la ventana de inicio de sesión
            Login loginWindow = new Login();
            loginWindow.Show();
        }
    }
}
