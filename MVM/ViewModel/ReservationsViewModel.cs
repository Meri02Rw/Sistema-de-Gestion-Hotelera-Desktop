using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using PMS.MVM.Model;
using PMS.Core;

namespace PMS.MVM.ViewModel
{
    public class ReservationsViewModel : INotifyPropertyChanged
    {


        private ObservableCollection<Reservation> _reservations;
        public ObservableCollection<Reservation> Reservations
        {
            get { return _reservations; }
            set
            {
                _reservations = value;
                OnPropertyChanged(nameof(Reservations));
            }
        }

        public RelayCommand<string> ViewDetailsCommand { get; }

        public ReservationsViewModel()
        {
            // Convertimos el diccionario de reservaciones en una lista observable
            Reservations = new ObservableCollection<Reservation>(ReservationsData.reservationsList.Values);
            ViewDetailsCommand = new RelayCommand<string>(ShowReservationDetails);

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ShowReservationDetails(string reservationNumber)
        {
            // Mostrar el mensaje con el número de la reserva
            MessageBox.Show($"Mirando más información de la reserva número: {reservationNumber}", "Detalles de la reserva");
        }

    }
}
