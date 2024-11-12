namespace ChangingRoomLocker.Modules.Lockers.Models;

public class Locker
{
    public int Id { get; set; }
    public LockerStatus LockerStatus { get; set; }
    public LockerSerialNumber SerialNumber { get; set; }
    public int OrderNumber { get; set; }
    public LockerPosition Position { get; set; }

    //public TimeRange Reservation { get; set; }

    public bool CanBeChosen()
    {
        return LockerStatus == LockerStatus.Available;
    }
}
