using Reservroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservroom.ViewModels;

public class ReservationViewModel : ViewModelBase
{
    private readonly Reservation reservation;
    public string RoomID => reservation.RoomID?.ToString();
    public string Username => reservation.Username;
    public DateTime StartTime => reservation.StartTime;
    public DateTime EndTime => reservation.EndTime;

    public ReservationViewModel(Reservation reservation)
    {
        this.reservation = reservation;
    }
}
