using Reservroom.Commands;
using Reservroom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservroom.ViewModels;

public class ReservationListingViewModel : ViewModelBase
{
    private readonly ObservableCollection<ReservationViewModel> reservations;
    public IEnumerable<ReservationViewModel> Reservations => reservations;
    public ICommand MakeReservationCommand { get; }

    public ReservationListingViewModel()
    {
        MakeReservationCommand = new NavigateCommand();

        reservations = new ObservableCollection<ReservationViewModel>();

        reservations.Add(new ReservationViewModel(
                            new Reservation(
                                new RoomID(1, 3), 
                                "Person A", 
                                new DateTime(2000, 1, 1),
                                new DateTime(2000, 1, 2)
                             )));

        reservations.Add(new ReservationViewModel(
                            new Reservation(
                                new RoomID(2, 7),
                                "Person B",
                                new DateTime(2000, 2, 1),
                                new DateTime(2000, 2, 2))));

        reservations.Add(new ReservationViewModel(
                            new Reservation(
                                new RoomID(1, 5),
                                "Person C",
                                new DateTime(2000, 3, 1),
                                new DateTime(2000, 3, 2))));

    }
}
