using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.MVM.Model
{
    public class Reservation
    {
        public string ReservationNumber { get; set; }
        public string BookingSource { get; set; }
        public string GuestName { get; set; }
        public string RoomType { get; set; }
        public string RoomNumber { get; set; }
        public string Address { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfNights { get; set; }
        public int NumberOfRooms { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }
        public string RoomStatus { get; set; }
        public List<string> Folios { get; set; }
        public Dictionary<string, string> Notes { get; set; }

        // Fechas de Check-in y Check-out
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        // Constructor que incluye todas las propiedades de la reservacion
        public Reservation(string reservationNumber, string bookingSource, string guestName, string roomType,
                       string roomNumber, string address, int numberOfGuests, int numberOfNights, int numberOfRooms,
                       string phoneNumber, string email, string paymentMethod, string status, string roomStatus,
                       List<string> folios, Dictionary<string, string> notes, DateTime checkInDate, DateTime checkOutDate)
        {
            ReservationNumber = reservationNumber;
            BookingSource = bookingSource;
            GuestName = guestName;
            RoomType = roomType;
            RoomNumber = roomNumber;
            Address = address;
            NumberOfGuests = numberOfGuests;
            NumberOfNights = numberOfNights;
            NumberOfRooms = numberOfRooms;
            PhoneNumber = phoneNumber;
            Email = email;
            PaymentMethod = paymentMethod;
            Status = status;
            RoomStatus = roomStatus;
            Folios = folios;
            Notes = notes;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
        public bool IsCheckedIn => CheckInDate <= DateTime.Now && CheckOutDate >= DateTime.Now;

    }

    public static class ReservationsData
    {
            // Diccionario que almacena las reservaciones
            public static Dictionary<string, Reservation> reservationsList = new Dictionary<string, Reservation>()
        {
            // Ejemplo de una reservación
            { "001", new Reservation(
                "001",                 // Número de reserva
                "Web Page",            // Fuente de reserva
                "John Doe",            // Nombre del huésped
                "1 Bedroom Villa",     // Tipo de habitación
                "101",                 // Número de habitación
                "557 false street, False Town, Random State, 00000",  // Dirección
                2,                     // Número de huéspedes
                5,                     // Número de noches
                1,                     // Número de habitaciones
                "+0 000 000 0000",     // Teléfono
                "johndoe@email.com",   // Correo electrónico
                "Card",                // Método de pago
                "Pending",             // Estado
                "Available",             // Estado de habitación 
                new List<string> { "Folio001", "Folio002" },  // Folios asociados
                new Dictionary<string, string>                  // Notas
                {
                    { "Nota de Llegada", "El huésped llegará tarde, alrededor de las 10 PM." },
                    { "Nota de Recepción", "Solicita un cambio de almohadas." },
                    { "Nota de Gerente", "Cliente frecuente, ofrecer un descuento del 10%." }
                },
                DateTime.Now.AddDays(-1),      // Fecha de check-in (ayer)
                DateTime.Now.AddDays(2)        // Fecha de check-out (en 2 días)
            )},


            { "002", new Reservation(
                "002",
                "Direct Call",
                "Jane Smith",
                "2 Bedroom Suite",
                "202",
                "123 Main St, Sample City, 12345",
                4,
                3,
                1,
                "+0 111 111 1111",
                "janesmith@email.com",
                "Cash",
                "Confirmed",
                "Occupied",
                new List<string> { "Folio003", "Folio004" },
                new Dictionary<string, string>
                {
                    { "Nota de Llegada", "Llegará a las 5 PM." },
                    { "Nota de Recepción", "Requiere una cuna en la habitación." },
                    { "Nota de Gerente", "Cliente nuevo." }
                },
                DateTime.Now.AddDays(1),       // Fecha de check-in (mañana)
                DateTime.Now.AddDays(4)        // Fecha de check-out (en 4 días)
            )}
        };

        // Método para agregar una nueva reservación
        public static void AddReservation(Reservation newReservation)
        {
            if (!reservationsList.ContainsKey(newReservation.ReservationNumber))
            {
                reservationsList.Add(newReservation.ReservationNumber, newReservation);
            }
            else
            {
                Console.WriteLine("A reservation with this number already exists.");
            }
        }

        // Método para obtener una reservación
        public static Reservation GetReservation(string reservationNumber)
        {
            if (reservationsList.ContainsKey(reservationNumber))
            {
                return reservationsList[reservationNumber];
            }
            else
            {
                Console.WriteLine("Reservation not found.");
                return null;
            }
        }
    }
}
