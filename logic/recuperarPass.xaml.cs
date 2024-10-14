using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace hotel_management_system
{

    public partial class RecuperarPass : System.Windows.Controls.UserControl
    {
        private MainWindow mainWindow;

        public RecuperarPass(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            language.SelectedIndex = 0;

        }

        private void RestorePassword_Click(object sender, RoutedEventArgs e)
        {
            string username = user.Text;
            string newPassword = pass.Password;
            string confirmPassword = confirmPass.Password;

            if (newPassword != confirmPassword)
            {
                mensaje.Text = "Las contraseñas no coinciden";
                return;
            }


            if (!Login.users.ContainsKey(username))
            {
                mensaje.Text = "El nombre de usuario no existe";
                return;
            }

            Login.users[username] = newPassword;
            mensaje.Foreground = System.Windows.Media.Brushes.Green;
            mensaje.Text = "Contraseña actualizada con éxito";

        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.MostrarLogin();
        }

    }
}
