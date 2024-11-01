namespace ChangingRoomLocker.Modules.Lockers.Models;

public class LockerOccupation
{
    public Client Client { get; set; }
    public Locker Locker { get; set; }
    public TimeRange Reservation { get; set; }
    public DateTime? ReleaseLockerTime { get; set; }
}
