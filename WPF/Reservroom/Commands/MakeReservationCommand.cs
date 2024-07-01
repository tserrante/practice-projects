using Reservroom.Exceptions;
using Reservroom.Models;
using Reservroom.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Reservroom.Commands;

public class MakeReservationCommand : CommandBase
{
    private readonly Hotel hotel;
    private readonly MakeReservationViewModel makeReservationviewModel;
    public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
    {
        this.makeReservationviewModel = makeReservationViewModel;
        this.hotel = hotel;

        makeReservationviewModel.PropertyChanged += OnViewModelPropertyChanged;
    }

    private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(MakeReservationViewModel.Username) ||
            e.PropertyName == nameof(MakeReservationViewModel.FloorNumber) ||
            e.PropertyName == nameof(MakeReservationViewModel.RoomNumber))
        {
            OnCanExecuteChanged();
        }
    }

    public override bool CanExecute(object? parameter)
    {
        return !string.IsNullOrEmpty(makeReservationviewModel.Username) &&
            makeReservationviewModel.FloorNumber > 0 &&
            makeReservationviewModel.RoomNumber > 0 &&
            base.CanExecute(parameter);
    }

    public override void Execute(object? parameter)
    {
        Reservation reservation = new Reservation(
            new RoomID(makeReservationviewModel.FloorNumber, makeReservationviewModel.RoomNumber),
            makeReservationviewModel.Username,
            makeReservationviewModel.StartDate,
            makeReservationviewModel.EndDate
        );

        try
        {
            hotel.MakeReservation(reservation);
            MessageBox.Show("Room is successfully reserved.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (ReservationConflictException ex) 
        {
            MessageBox.Show("Room Is already booked.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
