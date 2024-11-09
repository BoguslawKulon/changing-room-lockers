namespace ChangingRoomLocker.Modules.Lockers.Models;

public class ChangingRoom
{
    private readonly HashSet<Locker> _lockers = new HashSet<Locker>();

    public int Id { get; set; }
    public Gender Type { get; set; }
    public RoomSymbol RoomSymbol { get; set; }
    public IEnumerable<Locker> Lockers => _lockers;
    public bool Available { get; set; }

}
