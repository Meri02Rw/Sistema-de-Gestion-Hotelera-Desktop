using PMS.MVM.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace PMS.Windows
{

    public partial class FrontDeskManager : Window
    {

        public FrontDeskManager()
        {
            InitializeComponent();

            this.DataContext = new ReservationsViewModel();

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private bool IsMaximized = false;
        private void Border_MouseLeftButton(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximized = true;
                }
            }
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
            reservationsWindow.Show(); // Muestra la ventana
            this.Close(); // Cierra la ventana principal
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            // Muestra la ventana de Front Desk Manager
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show(); // Muestra la ventana
            this.Close(); // Cierra la ventana principal
        }

    }
}
