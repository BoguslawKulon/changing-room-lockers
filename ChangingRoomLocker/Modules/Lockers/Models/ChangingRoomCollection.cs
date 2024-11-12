
using ChangingRoomLocker.Modules.Lockers.Exceptions;

namespace ChangingRoomLocker.Modules.Lockers.Models;

public class ChangingRoomCollection
{
    private List<ChangingRoom> _rooms = new List<ChangingRoom>();

    public void AddRoom(ChangingRoom changingRoom)
    {
        _rooms.Add(changingRoom);
    }

    internal Locker ChooseOneLocker()
    {
        foreach (var room in _rooms)
        {
            if (room.Available)
            {
                return room.Lockers.First();
            }
        }

        throw new NotEmptyLockerException();
    }
}
