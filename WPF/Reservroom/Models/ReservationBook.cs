using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservroom.Exceptions;
namespace Reservroom.Models;

public class ReservationBook
{
    private readonly List<Reservation> reservations;

    public ReservationBook()
    {
        reservations = new List<Reservation>();
    }
    public IEnumerable<Reservation> GetAllReservations()
    {
        return reservations;
    }
    public IEnumerable<Reservation> GetReservationForUser(string username)
    {
        return reservations.Where(x => x.Username == username);
    }
    public void AddReservation(Reservation reservation)
    {
        foreach (Reservation existingReservation in reservations)
        {
            if (existingReservation.Conflicts(reservation)) 
            {
                throw new ReservationConflictException(existingReservation, reservation);
            }
        }
        reservations.Add(reservation);
    }
}
