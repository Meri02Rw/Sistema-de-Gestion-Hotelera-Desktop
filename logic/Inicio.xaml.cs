using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace hotel_management_system
{
    public partial class Inicio : System.Windows.Controls.UserControl
    {
        private MainWindow mainWindow;

        public Inicio(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void GestorReservas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Text = "Abriendo el Gestor de Reservas...";
        }

        private void RoomMatrix_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Text = "Abriendo la Room Matrix...";
        }

        private void CrearReservas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Text = "Abriendo Crear Reservas...";
        }
    }
}
