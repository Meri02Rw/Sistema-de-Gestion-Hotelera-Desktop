using PMS.Windows;
using System.Windows;

namespace PMS
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded; // Suscribirse al evento Loaded
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Centrar la ventana en la pantalla
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized; // Minimiza la ventana.
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Cierra la ventana.
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            // Crea y muestra la ventana de inicio de sesión
            Login loginWindow = new Login();
            loginWindow.Show(); // Muestra la ventana de inicio de sesión
            this.Close(); // Cierra la ventana principal
        }
        private void btnReservations_Click(object sender, RoutedEventArgs e)
        {
            // Muestra la ventana de reservations
            FormReservations reservationsWindow = new FormReservations();
            reservationsWindow.Show(); // Muestra la ventana de inicio de sesión
            this.Close(); // Cierra la ventana principal
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                this.DragMove(); // Permite mover la ventana al hacer clic y arrastrar.
            }
        }
    }
}
