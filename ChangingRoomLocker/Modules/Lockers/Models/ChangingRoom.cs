namespace ChangingRoomLocker.Modules.Lockers.Models;

public class ChangingRoom
{
    private readonly HashSet<Locker> _lockers = new HashSet<Locker>();

    public int Id { get; set; }
    public Gender Type { get; set; }
    public RoomSymbol RoomSymbol { get; set; }
    public bool Available { get; set; }
    public IEnumerable<Locker> Lockers => _lockers;

    public ChangingRoom(string roomSymbol, Gender roomType, int lockerRows, int lockerColumns, bool available = true)
    {
        RoomSymbol = new RoomSymbol(roomSymbol);
        Type = roomType;
        Available = available;

        var orderNumber = 1;
        for (int columnIndex = 1; columnIndex <= lockerColumns; columnIndex++)
        {
            for (int rowIndex = 1; rowIndex <= lockerRows; rowIndex++)
            {
                _lockers.Add(new Locker {
                    LockerStatus = LockerStatus.Available,
                    OrderNumber = orderNumber++,
                    Position = new LockerPosition(rowIndex, columnIndex),
                    SerialNumber = new LockerSerialNumber($"{roomSymbol}-{rowIndex.ToString().PadLeft(3, '0')}{columnIndex.ToString().PadLeft(3, '0')}")
                });
            }
        }
    }

}
