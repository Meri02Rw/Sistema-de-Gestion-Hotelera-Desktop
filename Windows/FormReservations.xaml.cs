using PMS.MVM.Model;
using System;
using System.Windows;
using System.Windows.Controls;


namespace PMS.Windows
{
    /// <summary>
    /// Lógica de interacción para FormularioReservaciones.xaml
    /// </summary>
    public partial class FormReservations : Window
    {
     
        public FormReservations()
        {
            InitializeComponent();
        }

        private void NextToGuestInfo_Click(object sender, RoutedEventArgs e)
        {
            // Cambia a la pantalla de "Guest Information"
            GeneralInfoPanel.Visibility = Visibility.Collapsed;
            GuestInfoPanel.Visibility = Visibility.Visible;
            SubtitleLabel.Content = "Guest Information";

            // Cambiar visibilidades de los botones
            NextButton.Visibility = Visibility.Collapsed;
            NextToPaymentButton.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Visible;
            BackToGuestButton.Visibility = Visibility.Collapsed;
            SaveButton.Visibility = Visibility.Collapsed;
        }

        private void NextToPaymentInfo_Click(object sender, RoutedEventArgs e)
        {
            // Cambia a la pantalla de "Payment Information"
            GuestInfoPanel.Visibility = Visibility.Collapsed;
            PaymentInfoPanel.Visibility = Visibility.Visible;
            SubtitleLabel.Content = "Payment Information";

            // Cambiar visibilidades de los botones
            NextToPaymentButton.Visibility = Visibility.Collapsed;
            BackButton.Visibility = Visibility.Collapsed;  
            BackToGuestButton.Visibility = Visibility.Visible; 
            SaveButton.Visibility = Visibility.Visible; 
        }

        private void BackToGeneralInfo_Click(object sender, RoutedEventArgs e)
        {
            // Regresa a la pantalla de "General Information"
            GuestInfoPanel.Visibility = Visibility.Collapsed;
            GeneralInfoPanel.Visibility = Visibility.Visible;
            SubtitleLabel.Content = "General Information";

            // Restaurar visibilidades de los botones
            NextButton.Visibility = Visibility.Visible;
            NextToPaymentButton.Visibility = Visibility.Collapsed;
            BackButton.Visibility = Visibility.Collapsed;
            BackToGuestButton.Visibility = Visibility.Collapsed;
            SaveButton.Visibility = Visibility.Collapsed;
        }

        private void BackToGuestInfo_Click(object sender, RoutedEventArgs e)
        {
            // Regresa a la pantalla de "Guest Information"
            PaymentInfoPanel.Visibility = Visibility.Collapsed;
            GuestInfoPanel.Visibility = Visibility.Visible;
            SubtitleLabel.Content = "Guest Information";

            // Restaurar visibilidades de los botones
            NextToPaymentButton.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Visible; 
            BackToGuestButton.Visibility = Visibility.Collapsed;
            SaveButton.Visibility = Visibility.Collapsed;
        }


        // Guardar la reservación
        private void SaveReservation_Click(object sender, RoutedEventArgs e)
        {
            // Validar si el número de reservación no está vacío y si es un número válido
            if (string.IsNullOrEmpty(ReservationNumber.Text))
            {
                MessageBox.Show("Please enter a reservation number.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Creamos la instancia de reservación usando los valores capturados
            Reservation newReservation = new Reservation(
                ReservationNumber.Text,
                (ReservationSource.SelectedItem as ComboBoxItem)?.Content.ToString(),
                ReservationAgent.Text,
                (RoomType.SelectedItem as ComboBoxItem)?.Content.ToString(),
                RoomNumber.Text,
                Address.Text,
                int.Parse(NumberOfAdults.Text),
                int.Parse(NumberOfChildren.Text),
                0,  // Aquí puede ser calculado o ingresado según el diseño
                Phone.Text,
                Email.Text,
                (PaymentMethod.SelectedItem as ComboBoxItem)?.Content.ToString(),
                "Pending",  // Estado inicial de la reservación
                new List<string>(),  // Lista vacía inicial para los folios
                new Dictionary<string, string>()  // Notas vacías para inicializar
            );

            // Guardar la nueva reservación en el diccionario
            ReservationsData.AddReservation(newReservation);

            MessageBox.Show("Reservation saved successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            // Limpiar los campos después de guardar
            ClearFields();
        }

        private void ClearFields()
        {
            ReservationNumber.Clear();
            ReservationSource.SelectedIndex = -1;
            ReservationAgent.Clear();
            RoomType.SelectedIndex = -1;
            RoomNumber.Clear();
            NumberOfAdults.Clear();
            NumberOfChildren.Clear();
            Phone.Clear();
            Email.Clear();
            Address.Clear();
            PaymentMethod.SelectedIndex = -1;
        }


        private void PaymentMethod_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Obtener el ComboBox desde el sender
            System.Windows.Controls.ComboBox comboBox = (System.Windows.Controls.ComboBox)sender;

            // Verificar si el ComboBox tiene un ítem seleccionado
            if (comboBox.SelectedItem != null)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

                // Verificar si el ítem seleccionado es "Card"
                if (selectedItem.Content.ToString() == "Card")
                {
                    // Mostrar los campos de número de tarjeta
                    CardNumberLabel.Visibility = Visibility.Visible;
                    CardNumber.Visibility = Visibility.Visible;
                }
                else
                {
                    // Ocultar los campos de número de tarjeta
                    CardNumberLabel.Visibility = Visibility.Collapsed;
                    CardNumber.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void GoToHome_Click(object sender, RoutedEventArgs e)
        {
            // Muestra la ventana de reservations
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show(); // Muestra la ventana de inicio de sesión
            this.Close(); // Cierra la ventana principal
        }


    }

}

