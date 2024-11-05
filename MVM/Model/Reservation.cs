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
        public string ReservationSource { get; set; }
        public string ReservationAgent { get; set; }
        public string RoomType { get; set; }
        public string RoomNumber { get; set; }
        public string Address { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfNights { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }
        public List<string> Folios { get; set; }  // Lista de folios

        // Diccionario para almacenar las notas organizadas por tipo
        public Dictionary<string, string> NotesType { get; set; }

        // Constructor que incluye todas las propiedades de la reservacion
        public Reservation(string reservationNumber, string reservationSource, string reservationAgent, string roomType, string roomNumber, string address, int numberOfAdults, int numberOfChildren, int numberOfNights, string phone, string email, string paymentMethod, string status, List<string> folios, Dictionary<string, string> notesType)
        {
            ReservationNumber = reservationNumber;
            ReservationSource = reservationSource;
            ReservationAgent = reservationAgent;
            RoomType = roomType;
            RoomNumber = roomNumber;
            Address = address;
            NumberOfAdults = numberOfAdults;
            NumberOfChildren = numberOfChildren;
            NumberOfNights = numberOfNights;
            Phone = phone;
            Email = email;
            PaymentMethod = paymentMethod;
            Status = status;
            Folios = folios;
            NotesType = notesType;
        }
    }

    public static class ReservationsData
    {
        // Diccionario que almacena las reservaciones
        public static Dictionary<string, Reservation> reservations = new Dictionary<string, Reservation>()
        {
            // Ejemplo de una reservación
            { "001", new Reservation(
                "001",
                "Web Page",
                "John Doe",
                "1 Bedroom Villa",
                "101",
                "557 false street, False Town, Random State, 00000",
                2,
                1,
                5,
                "+0 000 000 0000",
                "johndoe@email.com",
                "Card",
                "Pending",
                new List<string> { "Folio001", "Folio002" },
                new Dictionary<string, string>
                {
                    { "Nota de Llegada", "El huésped llegará tarde, alrededor de las 10 PM." },
                    { "Nota de Recepción", "Solicita un cambio de almohadas." },
                    { "Nota de Gerente", "Cliente frecuente, ofrecer un descuento del 10%." }
                }
            )}
        };

        // Método para agregar una nueva reservación
        public static void AddReservation(Reservation newReservation)
        {
            if (!reservations.ContainsKey(newReservation.ReservationNumber))
            {
                reservations.Add(newReservation.ReservationNumber, newReservation);
            }
            else
            {
                Console.WriteLine("A reservation with this number already exists.");
            }
        }

        // Método para obtener una reservación
        public static Reservation GetReservation(string reservationNumber)
        {
            if (reservations.ContainsKey(reservationNumber))
            {
                return reservations[reservationNumber];
            }
            else
            {
                Console.WriteLine("Reservation not found.");
                return null;
            }
        }
    }
}
