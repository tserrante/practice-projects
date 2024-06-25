using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservroom.ViewModels;

public class MakeReservationViewModel : ViewModelBase
{
    private string username;
    private int floorNumber;
    private int roomNumber;
    private DateTime startDate;
    private DateTime endDate;
    public string Username
    {
        get => username;
        set
        {
            username = value;
            OnPropertyChanged(nameof(Username));
        }
    }

    public int FloorNumber 
    { 
        get => floorNumber; 
        set
        {
            floorNumber = value;
            OnPropertyChanged(nameof(FloorNumber));
        }
    }
    public int RoomNumber
    {
        get => roomNumber;
        set
        {
            roomNumber = value;
            OnPropertyChanged(nameof(roomNumber));
        }
    }

    public DateTime StartDate 
    { 
        get => startDate; 
        set 
        { 
            startDate = value;
            OnPropertyChanged(nameof(StartDate));
        } 
    }
    public DateTime EndDate
    {
        get => endDate;
        set
        {
            endDate = value;
            OnPropertyChanged(nameof(EndDate));
        }
    }

    public ICommand SubmitCommand { get; }
    public ICommand CancelCommand { get; }
    public MakeReservationViewModel()
    {
        
    }
}
