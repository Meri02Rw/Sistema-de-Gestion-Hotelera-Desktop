using System.Windows;
using System.Windows.Input;
using PMS.MVM.Model;

namespace PMS.Windows
{
    public partial class RecuperarPass : Window
    {
        public RecuperarPass()
        {
            InitializeComponent();

        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove(); // Permite arrastrar la ventana
            }
        }

        private void RestorePassword_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUser2.Text;
            string newPassword = txtPass2.Password;
            string confirmPassword = txtPassconfirm.Password;

            // Verifica si las contraseñas nuevas coinciden
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error de Restore Password", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Verifica si el usuario existe y actualiza la contraseña
            if (Users.UpdatePassword(username, newPassword))
            {
                MessageBox.Show("Contraseña actualizada con éxito", "Restauración exitosa", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("El nombre de usuario no existe", "Error de Restore Password", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            // Crea y muestra la ventana de inicio de sesión
            Login loginWindow = new Login();
            loginWindow.Show(); // Muestra la ventana de inicio de sesión
            this.Close(); // Cierra la ventana principal

        }
    }
}
