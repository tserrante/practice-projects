using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservroom.Models;

public class Hotel
{
    private readonly ReservationBook reservationBook;

    public string Name { get; }

    public Hotel(string name)
    {
        reservationBook = new ReservationBook();
        Name = name;
    }
    public IEnumerable<Reservation> GetReservations()
    {
        return reservationBook.GetAllReservations();
    }
    public IEnumerable<Reservation> GetReservationsForUser(string username)
    {
        return reservationBook.GetReservationForUser(username);
    }
    public void MakeReservation(Reservation reservation)
    {
        reservationBook.AddReservation(reservation);
    }
}
