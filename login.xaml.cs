using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hotel_management_system
{

    public partial class Login : Window
    {

        private Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "admin", "12345" },
            { "user1", "00000" },
            { "user2", "11111" }
        };

        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = user.Text;
            string password = pass.Password;

            if (users.ContainsKey(username) && users[username] == password)
            {
                new Inicio().Show(); 
                this.Close();
            }
            else
            {
                error.Text = "Usuario o contraseña incorrectos.";
            }
        }

        private void RecuperarPassButton_Click(object sender, RoutedEventArgs e)
        {
            new RecuperarPass().Show();
            this.Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}