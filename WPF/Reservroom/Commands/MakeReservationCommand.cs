using Reservroom.Models;
using Reservroom.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservroom.Commands;

public class MakeReservationCommand : CommandBase
{
    private readonly Hotel hotel;
    private readonly MakeReservationViewModel makeReservationviewModel;
    public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
    {
        this.makeReservationviewModel = makeReservationViewModel;
        this.hotel = hotel;
    }
    public override void Execute(object? parameter)
    {
        Reservation reservation = new Reservation(
            new RoomID(makeReservationviewModel.FloorNumber, makeReservationviewModel.RoomNumber),
            makeReservationviewModel.Username,
            makeReservationviewModel.StartDate,
            makeReservationviewModel.EndDate
        );
        hotel.MakeReservation(reservation);
    }
}
