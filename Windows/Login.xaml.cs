using System.Windows;
using System.Windows.Input;
using PMS.MVM.Model;

namespace PMS.Windows
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            txtPass.KeyDown += TxtPass_KeyDown; // Suscribe al evento KeyDown
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) // Verifica si la tecla presionada es Enter
            {
                btnLogin_Click(sender, e); // Llama al método de inicio de sesión
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Password;

            if (ValidateUser(username, password))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool ValidateUser(string username, string password)
        {

            // Lógica de validación (base de datos o similar)
            return Users.UserList.ContainsKey(username) && Users.UserList[username] == password;
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

        private void btnRecuperarPass_Click(object sender, RoutedEventArgs e)
        {
            // Crea y muestra la ventana de inicio de sesión
            RecuperarPass recuperarPassWindow = new RecuperarPass();
            recuperarPassWindow.Show(); // Muestra la ventana de inicio de sesión
            this.Close(); // Cierra la ventana principal

        }

    }
}
